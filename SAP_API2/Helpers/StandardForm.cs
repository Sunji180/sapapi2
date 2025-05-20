using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SAP_API.Helpers
{
    public partial class StandardForm : Form
    {
        /// <summary>
        /// Öffentlich zugreifbare DataGridView,
        /// damit MainDesign sie nach dem Öffnen manipulieren kann.
        /// </summary>
        public DataGridView DataGridView1 { get; private set; }

        private StandardForm(object content)
        {
            InitializeComponent();

            /* --- Inhalt binden --- */
            BindContent(content);
        }

        public static StandardForm GetForm(object content) => new StandardForm(content);

        /* ----------------------------------------------------
         *   UI‑Grundgerüst
         * -------------------------------------------------- */
        private void InitializeComponent()
        {
            //  ► Die DataGridView gleich öffentlich zuweisen
            DataGridView1 = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false
            };

            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView1);
            Text = "Standard Output";
        }

        /* -------------------------------------------------- */
        private void BindContent(object content)
        {
            switch (content)
            {
                case DataTable dt:
                    DataGridView1.DataSource = dt;
                    break;

                case System.Collections.IEnumerable list:
                    DataGridView1.DataSource = list;
                    break;

                default:
                    DataGridView1.DataSource = new[] { new { Value = content?.ToString() } };
                    break;
            }
        }
    }
}
