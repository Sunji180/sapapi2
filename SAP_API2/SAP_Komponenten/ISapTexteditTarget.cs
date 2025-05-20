using System;
using System.Runtime.InteropServices;
using SAP_API.GUI;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyTextEdit
  {
    public interface ISapTexteditTarget
    {
      [DispId(32003)]
      int Left { get; }

      [DispId(32069)]
      string DefaultTooltip { get; }

      [DispId(32061)]
      bool IsSymbolFont { get; }

      [DispId(32050)]
      GuiComponent ParentFrame { get; }

      [DispId(32045)]
      string AccTextOnRequest { get; }

      [DispId(32044)]
      string AccText { get; }

      [DispId(32043)]
      GuiComponentCollection AccLabelCollection { get; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      // Note: AccTooltip is declared twice in VB;
      // we include it only once.
      [DispId(32042)]
      string AccTooltip { get; }

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

      [DispId(32037)]
      string IconName { get; }

      [DispId(32005)]
      int Width { get; }

      [DispId(33700)]
      string SubType { get; }

      [DispId(33702)]
      int Handle { get; }

      [DispId(25)]
      int LastVisibleLine { get; }

      [DispId(23)]
      int SelectionEndColumn { get; }

      [DispId(22)]
      int SelectionEndLine { get; }

      [DispId(21)]
      int SelectionStartColumn { get; }

      [DispId(20)]
      int SelectionStartLine { get; }

      [DispId(19)]
      int CurrentColumn { get; }

      [DispId(33701)]
      GuiContextMenu CurrentContextMenu { get; }

      [DispId(18)]
      int CurrentLine { get; }

      [DispId(16)]
      int SelectionIndexStart { get; }

      [DispId(15)]
      int NumberOfUnprotectedTextParts { get; }

      [DispId(2)]
      int FirstVisibleLine { get; set; }

      [DispId(33706)]
      bool DragDropSupported { get; }

      [DispId(33705)]
      GuiCollection OcxEvents { get; }

      [DispId(33703)]
      string AccDescription { get; }

      [DispId(17)]
      int SelectionIndexEnd { get; }

      // Note: VB declares Top a second time.
      [DispId(32004)]
      int Top { get; }

      [DispId(27)]
      string SelectedText { get; }

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

      [DispId(26)]
      int LineCount { get; }

      // Methods
      [DispId(32068)]
      void ShowContextMenu();

      [DispId(34100)]
      void SelectContextMenuItem(string FunctionCode);

      [DispId(34101)]
      void SelectContextMenuItemByText(string Text);

      [DispId(34102)]
      void SelectContextMenuItemByPosition(string PositionDesc);

      [DispId(4)]
      void SetSelectionIndexes(int Start, int End);

      [DispId(6)]
      void DoubleClick();

      [DispId(7)]
      void SingleFileDropped(string Filename);

      [DispId(8)]
      void MultipleFilesDropped();

      [DispId(9)]
      void PressF1();

      [DispId(11)]
      void ContextMenu();

      [DispId(10)]
      void PressF4();

      [DispId(32024)]
      void SetFocus();

      [DispId(13)]
      void ModifiedStatusChanged(bool Status);

      [DispId(28)]
      string GetLineText(int nLine);

      [DispId(5)]
      bool SetUnprotectedTextPart(int Part, string Text);

      [DispId(29)]
      bool IsCommentLine(int nLine);

      [DispId(30)]
      bool IsProtectedLine(int nLine);

      [DispId(31)]
      bool IsBreakpointLine(int nLine);

      [DispId(32)]
      bool IsSelectedLine(int nLine);

      [DispId(32035)]
      GuiComponentCollection FindAllByName(string Name, string Type);

      [DispId(32034)]
      GuiComponent FindByNameEx(string Name, int Type);

      [DispId(32026)]
      GuiComponent FindByName(string Name, string Type);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);

      [DispId(33)]
      bool IsHighlightedLine(int nLine);

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);

      [DispId(14)]
      string GetUnprotectedTextPart(int Part);

      [DispId(32036)]
      GuiComponentCollection FindAllByNameEx(string Name, int Type);
    }
  }
}
