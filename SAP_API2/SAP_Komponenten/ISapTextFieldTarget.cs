using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiTextField
  {
    public interface ISapTextFieldTarget
    {
      [DispId(32044)]
      string AccText { get; }

      [DispId(32050)]
      GuiComponent ParentFrame { get; }

      [DispId(32061)]
      bool IsSymbolFont { get; }

      [DispId(32069)]
      string DefaultTooltip { get; }

      [DispId(32040)]
      GuiVComponent LeftLabel { get; }

      [DispId(32041)]
      GuiVComponent RightLabel { get; }

      [DispId(32012)]
      int MaxLength { get; }

      [DispId(32013)]
      bool Numerical { get; }

      [DispId(32014)]
      bool Required { get; }

      [DispId(32022)]
      int CaretPosition { get; set; }

      [DispId(32100)]
      bool Highlighted { get; }

      [DispId(32045)]
      string AccTextOnRequest { get; }

      [DispId(32051)]
      bool IsHotspot { get; }

      [DispId(32102)]
      bool IsRightLabel { get; }

      [DispId(32054)]
      bool HistoryIsActive { get; }

      [DispId(32055)]
      GuiCollection HistoryList { get; }

      [DispId(32056)]
      int HistoryCurIndex { get; }

      [DispId(32057)]
      string HistoryCurEntry { get; }

      [DispId(32067)]
      bool IsOField { get; }

      [DispId(32070)]
      int CharLeft { get; }

      [DispId(32071)]
      int CharTop { get; }

      [DispId(32072)]
      int CharWidth { get; }

      [DispId(32073)]
      int CharHeight { get; }

      [DispId(32101)]
      bool IsLeftLabel { get; }

      [DispId(32074)]
      string DisplayedText { get; }

      [DispId(32052)]
      bool IsListElement { get; }

      // Note: "AccTooltip" appears twice in VB; we include it only once.
      [DispId(32042)]
      string AccTooltip { get; }

      [DispId(32001)]
      string Name { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      [DispId(32025)]
      string Id { get; }

      [DispId(32043)]
      GuiComponentCollection AccLabelCollection { get; }

      [DispId(32000)]
      string Text { get; set; }

      [DispId(32003)]
      int Left { get; }

      [DispId(32038)]
      GuiComponent Parent { get; }

      [DispId(32005)]
      int Width { get; }

      [DispId(32006)]
      int Height { get; }

      [DispId(32046)]
      int ScreenLeft { get; }

      [DispId(32047)]
      int ScreenTop { get; }

      [DispId(32008)]
      string Tooltip { get; }

      [DispId(32009)]
      bool Changeable { get; }

      [DispId(32030)]
      bool Modified { get; }

      [DispId(32037)]
      string IconName { get; }

      [DispId(32004)]
      int Top { get; }

      [DispId(32104)]
      string GetListPropertyNonRec(string property);

      [DispId(32103)]
      string GetListProperty(string property);

      [DispId(31194)]
      GuiCollection DumpState(string innerObject);

      [DispId(32039)]
      bool Visualize(bool on, object innerObject = null);
    }
  }
}
