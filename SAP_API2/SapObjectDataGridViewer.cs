// SapObjectDataGridViewer.cs
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using SAPFEWSELib;
using SAP_API;                // StaticVariables, MemberParams, …
using SAP_API.GUI;

namespace SAP_API.GUI.Helpers          // Namespace bei Bedarf anpassen
{
    public partial class SapObjectDataGridViewer : Form
    {
        // ------------------------  STATIC FLAGS  -------------------------
        public static string SapFieldNameFromGridView { get; set; }
        public static bool GridViewIsOpen { get; set; }
        public static bool GridViewIsClosed { get; set; }

        // ------------------------  CTOR / INIT  --------------------------
        public SapObjectDataGridViewer()
        {
            InitializeComponent();

            Button1.Click += Button1_Click;
            Button2.Click += Button2_Click;
            Button3.Click += Button3_Click;
            Button4.Click += Button4_Click;
            Button5.Click += Button5_Click;
            Button6.Click += Button6_Click;
            Button8.Click += Button8_Click;

            Load += (_, __) => GridViewIsOpen = true;
            FormClosing += (_, __) =>
            {
                GridViewIsOpen = false;
                GridViewIsClosed = true;
            };
        }

        // ------------------------  DATA HELPERS  ------------------------
        private static DataTable CreateDataTable()
        {
            var t = new DataTable();
            t.Columns.Add("SapFieldName", typeof(string));
            t.Columns.Add("SapFieldText", typeof(string));
            t.Columns.Add("SapFieldType", typeof(string));
            t.Columns.Add("SapFieldToolTip", typeof(string));
            t.Columns.Add("SapFieldDefaultToolTip", typeof(string));
            t.Columns.Add("SapObject", typeof(object));
            t.Columns.Add("ID", typeof(string));
            return t;
        }

        private static void ScanSapElementsAndFillDataTable(dynamic guiSession, DataTable tbl)
        {
            StaticVariables.dt_SapElementCollection = tbl;
            ScanFields.ScanAll(guiSession, StaticVariables.application);
        }

        // ------------------------  BUTTON‑HANDLER  -----------------------
        private void Button1_Click(object? sender, EventArgs e)
        {
            dynamic guiSession = SapGuiConnection.GetSapGuiSession();
            var table = CreateDataTable();

            ScanSapElementsAndFillDataTable(guiSession, table);

            DataGridView1.DataSource = StaticVariables.dt_SapElementCollection;
            DataGridView1.AutoResizeColumns();

            // --- Fix: explizite string‑Konvertierung -----------------------
            var ds = CheckDatabase(Convert.ToString(guiSession.Parent.Description),
                                   Convert.ToString(guiSession.Info.Transaction));
            // ----------------------------------------------------------------

            DataGridView2.DataSource = ds.Tables[0];
            DataGridView2.AutoResizeColumns();

            DataGridView3.DataSource = ds.Tables[0].Clone();
            DataGridView3.AutoResizeColumns();
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            try
            {
                StaticVariables.SapGuiTypeInfoDt = null;
                DataGridView2.DataSource = null;

                var sapGuiType = (SapGuiComponentType)Enum.Parse(
                                    typeof(SapGuiComponentType),
                                    DataGridView1.CurrentRow!.Cells[2].Value!.ToString()!);

                MemberParams.GetGuiTypeInfo(sapGuiType);
            }
            catch
            {
                MessageBox.Show("No Selection");
            }
        }

        private void Button3_Click(object? s, EventArgs e) { }
        private void Button4_Click(object? s, EventArgs e) { }

        private void Button5_Click(object? s, EventArgs e)
        {
            GuiSession session = SapGuiConnection.GetSapGuiSession();
            dynamic sapObject = session.FindById(
            Convert.ToString(DataGridView1.CurrentRow!.Cells[6].Value));
            sapObject.Visualize(true);
        }

        private void Button6_Click(object? s, EventArgs e) { }

        private void Button8_Click(object? s, EventArgs e)
        {
            dynamic guiSession = SapGuiConnection.GetSapGuiSession();

            DataGridView1.DataSource ??= StaticVariables.dt_SapElementCollection;

            var tbl = (DataTable)DataGridView3.DataSource!;
            tbl.Columns[1].AutoIncrement = true;

            var dr = tbl.NewRow();
            dr["TRANS"] = guiSession.Info.Transaction.ToString();
            dr["SYSVERSTRANS_ID"] = 92;
            dr["FIELDNAME"] = DataGridView1.SelectedRows[0].Cells[0].Value!.ToString();
            tbl.Rows.Add(dr);

            DataGridView3.DataSource = tbl;
        }

        // ------------------------  DB HELPERS  --------------------------
        private static string GetDatabaseConnection()
        {
            // <-- hier den richtigen Typ einsetzen
 

            // optional, wenn Sie den Ordnerpfad brauchen
       

            XDocument cfg = XDocument.Load(
                @"N:\AOK_Gesamt\Automatisierungen\Management\03_interne Unterlagen\SoureCode\Visual Basic\SAP_API\SAP_GUI_Scripting_API\bin\Debug\Config.xml");

            return cfg.Descendants("Connection")
                      .Select(x => x.Value)
                      .FirstOrDefault();
        }

        private static DataSet ExecuteSQL(string sql)
        {
            var ds = new DataSet();
            using var con = new OleDbConnection(GetDatabaseConnection());
            con.Open();
            using var adp = new OleDbDataAdapter(sql, con);
            adp.Fill(ds, "OLEDB Temp Table");
            return ds;
        }

        private static DataSet CheckDatabase(string systemName, string transaction)
        {
            string sql =
                "SELECT T_SysVersTrans.TRANS, T_Field.* " +
                "FROM (T_SysVers " +
                "LEFT JOIN T_SysVersTrans ON T_SysVers.ID = T_SysVersTrans.SYSVERS_ID) " +
                "LEFT JOIN T_Field ON T_SysVersTrans.ID = T_Field.SYSVERSTRANS_ID " +
                $"WHERE T_SysVersTrans.TRANS = '{transaction}' " +
                $"AND   T_SysVers.SYS       = '{systemName}' " +
                "AND   T_SysVers.AB = (SELECT MAX(AB) FROM T_SysVers);";

            return ExecuteSQL(sql);
        }

        // ------------------------  DESIGNER‑CODE  ------------------------
        private void InitializeComponent()
        {
            DataGridView1 = new DataGridView();
            DataGridView2 = new DataGridView();
            DataGridView3 = new DataGridView();
            Button1 = new Button { Text = "Scan" };
            Button2 = new Button { Text = "Load Fields" };
            Button3 = new Button();
            Button4 = new Button();
            Button5 = new Button { Text = "Visualize" };
            Button6 = new Button();
            Button8 = new Button { Text = "Add Field" };

            Controls.AddRange(new Control[]
            {
                DataGridView1, DataGridView2, DataGridView3,
                Button1, Button2, Button3, Button4, Button5, Button6, Button8
            });

            Text = "SAP Object Viewer";
            Width = 1200;
            Height = 700;
        }

        // ------------------------  FELDER --------------------------------
        private DataGridView DataGridView1;
        private DataGridView DataGridView2;
        private DataGridView DataGridView3;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;
        private Button Button6;
        private Button Button8;
    }
}
