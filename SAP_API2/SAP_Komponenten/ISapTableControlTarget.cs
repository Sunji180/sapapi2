using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiTableControl
  {
    public interface ISapTableControlTarget
    {
      [DispId(32047)]
      int ScreenTop { get; }

      [DispId(32009)]
      bool Changeable { get; }

      [DispId(32030)]
      bool Modified { get; }

      [DispId(32037)]
      string IconName { get; }

      [DispId(32042)]
      string AccTooltip { get; }

      [DispId(32043)]
      GuiComponentCollection AccLabelCollection { get; }

      [DispId(32044)]
      string AccText { get; }

      [DispId(32045)]
      string AccTextOnRequest { get; }

      [DispId(32050)]
      GuiComponent ParentFrame { get; }

      [DispId(32061)]
      bool IsSymbolFont { get; }

      [DispId(32069)]
      string DefaultTooltip { get; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      [DispId(32008)]
      string Tooltip { get; }

      [DispId(33401)]
      GuiTableSelectionType ColSelectMode { get; }

      [DispId(33403)]
      GuiTableSelectionType RowSelectMode { get; }

      [DispId(33404)]
      GuiCollection Rows { get; }

      [DispId(32601)]
      GuiScrollbar VerticalScrollbar { get; }

      [DispId(32600)]
      GuiScrollbar HorizontalScrollbar { get; }

      [DispId(33409)]
      string TableFieldName { get; }

      [DispId(33410)]
      int CurrentCol { get; }

      [DispId(33411)]
      int CurrentRow { get; }

      [DispId(33412)]
      int RowCount { get; }

      [DispId(33413)]
      int VisibleRowCount { get; }

      [DispId(32070)]
      int CharLeft { get; }

      [DispId(32071)]
      int CharTop { get; }

      [DispId(33402)]
      GuiCollection Columns { get; }

      [DispId(32072)]
      int CharWidth { get; }

      [DispId(32073)]
      int CharHeight { get; }

      [DispId(32006)]
      int Height { get; }

      [DispId(32005)]
      int Width { get; }

      [DispId(32004)]
      int Top { get; }

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

      [DispId(32046)]
      int ScreenLeft { get; }

      [DispId(32068)]
      void ShowContextMenu();

      [DispId(33405)]
      void ReorderTable(string Permutation);

      [DispId(33406)]
      void ConfigureLayout();

      [DispId(33408)]
      void SelectAllColumns();

      [DispId(33414)]
      void DeselectAllColumns();

      [DispId(32024)]
      void SetFocus();

      // This method is declared without a DispId in VB as a regular sub.
      void _SetAbsoluteRow(int Index, bool Selected);

      [DispId(32036)]
      GuiComponentCollection FindAllByNameEx(string Name, int Type);

      [DispId(32035)]
      GuiComponentCollection FindAllByName(string Name, string Type);

      [DispId(32034)]
      GuiComponent FindByNameEx(string Name, int Type);

      [DispId(32026)]
      GuiComponent FindByName(string Name, string Type);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);

      [DispId(33415)]
      GuiVComponent GetCell(int Row, int Column);

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);

      [DispId(33407)]
      GuiTableRow GetAbsoluteRow(int Index);
    }

    public static void SetAbsoluteRow(object SapObject, int Index, bool Selected)
    {
      // Cast the object to a GuiTableControl.
      GuiTableControl guiTableControlObject = (GuiTableControl)SapObject;
      // GetAbsoluteRow returns a GuiTableRow, on which we set the Selected property.
      if (Selected)
      {
        guiTableControlObject.GetAbsoluteRow(Index).Selected = true;
      }
      else
      {
        guiTableControlObject.GetAbsoluteRow(Index).Selected = false;
      }
    }
  }
}
