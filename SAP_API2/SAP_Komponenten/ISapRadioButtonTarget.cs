using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiRadioButton
  {
    public interface ISapRadioButtonTarget
    {
      [DispId(32030)]
      bool Modified { get; }

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

      [DispId(32101)]
      bool IsLeftLabel { get; }

      [DispId(32102)]
      bool IsRightLabel { get; }

      [DispId(32040)]
      GuiVComponent LeftLabel { get; }

      [DispId(32041)]
      GuiVComponent RightLabel { get; }

      [DispId(32500)]
      bool Selected { get; set; }

      [DispId(32502)]
      int GroupCount { get; }

      [DispId(32503)]
      int GroupPos { get; }

      [DispId(33704)]
      bool Flushing { get; }

      [DispId(32070)]
      int CharLeft { get; }

      [DispId(32071)]
      int CharTop { get; }

      [DispId(32072)]
      int CharWidth { get; }

      // Note: The VB code declares AccTooltip twice with DispId(32042).
      // We include it only once.
      [DispId(32042)]
      string AccTooltip { get; }

      [DispId(32037)]
      string IconName { get; }

      [DispId(32504)]
      GuiComponentCollection GroupMembers { get; }

      [DispId(32009)]
      bool Changeable { get; }

      [DispId(32001)]
      string Name { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      [DispId(32073)]
      int CharHeight { get; }

      [DispId(32038)]
      GuiComponent Parent { get; }

      [DispId(32000)]
      string Text { get; set; }

      [DispId(32025)]
      string Id { get; }

      [DispId(32004)]
      int Top { get; }

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

      [DispId(32003)]
      int Left { get; }

      [DispId(32501)]
      void Select();

      [DispId(32068)]
      void ShowContextMenu();

      [DispId(32024)]
      void SetFocus();

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);
    }
  }
}
