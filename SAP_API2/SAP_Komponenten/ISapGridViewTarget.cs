using System;
using System.Data;
using System.Runtime.InteropServices;
using SAP_API.GUI;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiGridView
  {
    public interface ISapGridViewTarget
    {
      int VisibleRowCount { get; }

      [DispId(32043)]
      GuiComponentCollection AccLabelCollection { get; }

      [DispId(32042)]
      string AccTooltip { get; }

      [DispId(32037)]
      string IconName { get; }

      [DispId(32030)]
      bool Modified { get; }

      [DispId(32009)]
      bool Changeable { get; }

      [DispId(32008)]
      string Tooltip { get; }

      [DispId(32047)]
      int ScreenTop { get; }

      [DispId(32046)]
      int ScreenLeft { get; }

      [DispId(32006)]
      int Height { get; }

      [DispId(32044)]
      string AccText { get; }

      [DispId(32005)]
      int Width { get; }

      [DispId(32003)]
      int Left { get; }

      [DispId(32000)]
      string Text { get; set; }

      [DispId(32038)]
      GuiComponent Parent { get; }

      [DispId(32025)]
      string Id { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32001)]
      string Name { get; }

      [DispId(58)]
      string SelectionMode { get; }

      [DispId(32004)]
      int Top { get; }

      [DispId(32050)]
      GuiComponent ParentFrame { get; }

      [DispId(32045)]
      string AccTextOnRequest { get; }

      [DispId(4)]
      string SelectedRows { get; set; }

      [DispId(53)]
      int RowCount { get; }

      [DispId(49)]
      int FrozenColumnCount { get; }

      [DispId(40)]
      int ToolbarButtonCount { get; }

      [DispId(39)]
      string Title { get; }

      [DispId(27)]
      object SelectedCells { get; set; }

      [DispId(26)]
      string FirstVisibleColumn { get; set; }

      [DispId(24)]
      object ColumnOrder { get; set; }

      [DispId(6)]
      int FirstVisibleRow { get; set; }

      [DispId(32061)]
      bool IsSymbolFont { get; }

      [DispId(3)]
      object SelectedColumns { get; set; }

      [DispId(1)]
      int CurrentCellRow { get; set; }

      [DispId(33706)]
      bool DragDropSupported { get; }

      [DispId(33705)]
      GuiCollection OcxEvents { get; }

      [DispId(33703)]
      string AccDescription { get; }

      [DispId(33702)]
      int Handle { get; }

      [DispId(33701)]
      GuiContextMenu CurrentContextMenu { get; }

      [DispId(33700)]
      string SubType { get; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      [DispId(32069)]
      string DefaultTooltip { get; }

      [DispId(2)]
      string CurrentCellColumn { get; set; }

      [DispId(54)]
      int ColumnCount { get; }

      [DispId(62)]
      void DeselectColumn(string Column);

      [DispId(61)]
      void SelectColumn(string Column);

      [DispId(82)]
      void TriggerModified();

      [DispId(60)]
      void SelectAll();

      [DispId(32024)]
      void SetFocus();

      [DispId(36)]
      void PressButtonCurrentCell();

      [DispId(15)]
      void PressToolbarButton(string Id);

      [DispId(16)]
      void PressToolbarContextButton(string Id);

      [DispId(17)]
      void PressTotalRow(int Row, string Column);

      [DispId(19)]
      void SelectToolbarMenuItem(string Id);

      [DispId(20)]
      void PressF4();

      [DispId(22)]
      void PressEnter();

      [DispId(23)]
      void SetColumnWidth(string Column, int Width);

      [DispId(25)]
      void SetCurrentCell(int Row, string Column);

      [DispId(28)]
      void ModifyCell(int Row, string Column, string Value);

      [DispId(29)]
      void MoveRows(int FromRow, int ToRow, int DestRow);

      [DispId(30)]
      void InsertRows(string Rows);

      [DispId(31)]
      void DeleteRows(string Rows);

      [DispId(32)]
      void DuplicateRows(string Rows);

      [DispId(33)]
      void ModifyCheckBox(int Row, string Column, bool Checked);

      [DispId(34)]
      void DoubleClickCurrentCell();

      [DispId(14)]
      void ContextMenu();

      [DispId(13)]
      void SelectionChanged();

      [DispId(12)]
      void PressColumnHeader(string Column);

      [DispId(11)]
      void CurrentCellMoved();

      [DispId(32068)]
      void ShowContextMenu();

      [DispId(37)]
      void PressTotalRowCurrentCell();

      [DispId(34100)]
      void SelectContextMenuItem(string FunctionCode);

      [DispId(34101)]
      void SelectContextMenuItemByText(string Text);

      [DispId(34102)]
      void SelectContextMenuItemByPosition(string PositionDesc);

      [DispId(35)]
      void ClickCurrentCell();

      [DispId(7)]
      void DoubleClick(int Row, string Column);

      [DispId(8)]
      void Click(int Row, string Column);

      [DispId(9)]
      void PressButton(int Row, string Column);

      [DispId(10)]
      void PressF1();

      [DispId(5)]
      void ClearSelection();

      [DispId(32035)]
      GuiComponentCollection FindAllByName(string Name, string Type);

      [DispId(32034)]
      GuiComponent FindByNameEx(string Name, int Type);

      [DispId(32026)]
      GuiComponent FindByName(string Name, string Type);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);

      [DispId(32036)]
      GuiComponentCollection FindAllByNameEx(string Name, int Type);

      [DispId(56)]
      string GetDisplayedColumnTitle(string Column);

      [DispId(38)]
      string GetCellValue(int Row, string Column);

      [DispId(73)]
      string GetCellTooltip(int Row, string Column);

      [DispId(72)]
      string GetCellIcon(int Row, string Column);

      [DispId(71)]
      bool IsCellSymbol(int Row, string Column);

      [DispId(47)]
      string GetToolbarButtonTooltip(int ButtonPos);

      [DispId(69)]
      int GetRowTotalLevel(int Row);

      [DispId(68)]
      bool IsColumnKey(string Column);

      [DispId(67)]
      string GetColumnTotalType(string Column);

      [DispId(66)]
      string GetColumnSortType(string Column);

      [DispId(65)]
      bool IsColumnFiltered(string Column);

      [DispId(64)]
      string GetSymbolInfo(string Symbol);

      [DispId(63)]
      string GetColorInfo(int Color);

      [DispId(50)]
      bool GetCellChangeable(int Row, string Column);

      [DispId(51)]
      string GetCellType(int Row, string Column);

      [DispId(52)]
      bool GetCellCheckBoxChecked(int Row, string Column);

      [DispId(57)]
      string GetColumnTooltip(string Column);

      [DispId(74)]
      int GetToolbarFocusButton();

      [DispId(55)]
      object GetColumnTitles(string Column);

      [DispId(75)]
      string GetCellState(int Row, string Column);

      [DispId(77)]
      int GetColumnPosition(string Column);

      [DispId(41)]
      string GetToolbarButtonId(int ButtonPos);

      [DispId(42)]
      string GetToolbarButtonIcon(int ButtonPos);

      [DispId(43)]
      string GetToolbarButtonType(int ButtonPos);

      [DispId(44)]
      bool GetToolbarButtonEnabled(int ButtonPos);

      [DispId(45)]
      string GetToolbarButtonText(int ButtonPos);

      [DispId(87)]
      int GetCellHeight(int Row, string Column);

      [DispId(86)]
      int GetCellWidth(int Row, string Column);

      [DispId(85)]
      int GetCellTop(int Row, string Column);

      [DispId(84)]
      int GetCellLeft(int Row, string Column);

      [DispId(83)]
      int GetCellMaxLength(int Row, string Column);

      [DispId(46)]
      bool GetToolbarButtonChecked(int ButtonPos);

      [DispId(81)]
      bool IsCellHotspot(int Row, string Column);

      [DispId(80)]
      bool IsCellTotalExpander(int Row, string Column);

      [DispId(79)]
      bool IsTotalRowExpanded(int Row);

      [DispId(78)]
      bool HasCellF4Help(int Row, string Column);

      [DispId(76)]
      string GetColumnDataType(string Column);

      [DispId(70)]
      int GetCellColor(int Row, string Column);

      // Own functions
      DataTable _ReadOutGrid();
      DataTable _GetAllToolbarButtons();
    }

    public static DataTable ReadGuiGridView()
    {
      GuiGridView table = StaticVariables.SapObject as GuiGridView;

      int Rows = table.RowCount - 1;
      int Cols = table.ColumnCount - 1;
      DataTable Dt = new DataTable();
      Dt.Clear();

      // Get the technical title of all columns in the first line
      var Columns = table.ColumnOrder();
      for (int j = 0; j <= Cols; j++)
      {
        Dt.Columns.Add(Columns[j].ToString());
      }

      for (int i = 0; i <= Rows; i++)
      {
        DataRow dr = Dt.NewRow();
        for (int j = 0; j <= Cols; j++)
        {
          dr[Columns[j].ToString()] = table.GetCellValue(i, Columns[j].ToString());
        }
        Dt.Rows.Add(dr);

        // Each 32 lines actualize the grid
        if (i % 32 == 0)
        {
          table.SetCurrentCell(i, Columns[0].ToString());
          table.FirstVisibleRow = i;
        }
      }

      return Dt;
    }

    public static DataTable GetAllToolbarbuttons()
    {
      GuiGridView GridView = StaticVariables.SapObject as GuiGridView;

      DataTable Dt = new DataTable();
      Dt.Clear();
      Dt.Columns.Add("GetToolbarButtonId", typeof(string));
      Dt.Columns.Add("GetToolbarButtonText", typeof(string));
      Dt.Columns.Add("GetToolbarButtonType", typeof(string));
      Dt.Columns.Add("GetToolbarButtonTooltip", typeof(string));
      Dt.Columns.Add("GetToolbarButtonIcon", typeof(string));

      for (int i = 0; i < GridView.ToolbarButtonCount; i++)
      {
        DataRow dr = Dt.NewRow();
        dr["GetToolbarButtonId"] = GridView.GetToolbarButtonId(i);
        dr["GetToolbarButtonText"] = GridView.GetToolbarButtonText(i);
        dr["GetToolbarButtonType"] = GridView.GetToolbarButtonType(i);
        dr["GetToolbarButtonTooltip"] = GridView.GetToolbarButtonTooltip(i);
        dr["GetToolbarButtonIcon"] = GridView.GetToolbarButtonIcon(i);
        Dt.Rows.Add(dr);
      }

      return Dt;
    }
  }
}
