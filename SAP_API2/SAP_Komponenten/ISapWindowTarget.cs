using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiFrameWindow
  {
    public interface ISapWindowTarget
    {
      [DispId(32025)]
      string Id { get; }

      [DispId(32000)]
      string Text { get; set; }

      [DispId(32003)]
      int Left { get; }

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

      [DispId(32009)]
      bool Changeable { get; }

      [DispId(32030)]
      bool Modified { get; }

      [DispId(32037)]
      string IconName { get; }

      [DispId(32038)]
      GuiComponent Parent { get; }

      [DispId(32042)]
      string AccTooltip { get; }

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

      [DispId(32416)]
      int WorkingPaneWidth { get; }

      [DispId(32417)]
      int WorkingPaneHeight { get; }

      [DispId(32400)]
      bool Iconic { get; }

      [DispId(32420)]
      int Handle { get; }

      [DispId(32421)]
      GuiVComponent SystemFocus { get; }

      [DispId(32422)]
      GuiVComponent GuiFocus { get; }

      [DispId(32043)]
      GuiComponentCollection AccLabelCollection { get; }

      [DispId(32413)]
      bool ElementVisualizationMode { get; set; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32001)]
      string Name { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      // Methods
      [DispId(32024)]
      void SetFocus();

      [DispId(32808)]
      void SendVKey(int VKey);

      [DispId(32407)]
      void MoveWindow(int Left, int Top, int Width, int Height);

      [DispId(32408)]
      void Iconify();

      [DispId(32409)]
      void Restore();

      [DispId(32410)]
      void Maximize();

      [DispId(32429)]
      void TabForward();

      [DispId(32430)]
      void TabBackward();

      [DispId(32431)]
      void JumpForward();

      [DispId(32432)]
      void JumpBackward();

      [DispId(32414)]
      void Close();

      [DispId(32443)]
      int CompBitmap(string Filename1, string Filename2);

      [DispId(32026)]
      GuiComponent FindByName(string Name, string Type);

      [DispId(32034)]
      GuiComponent FindByNameEx(string Name, int Type);

      [DispId(32035)]
      GuiComponentCollection FindAllByName(string Name, string Type);

      [DispId(32036)]
      GuiComponentCollection FindAllByNameEx(string Name, int Type);

      [DispId(32412)]
      bool IsVKeyAllowed(int VKey);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);

      [DispId(32419)]
      int ShowMessageBox(string Title, string Text, int MsgIcon, int MsgType);

      [DispId(32415)]
      string HardCopy(string Filename, object ImageType = null, object xPos = null, object yPos = null, object nWidth = null, object nHeight = null);

      [DispId(32441)]
      object HardCopyToMemory(object ImageType = null);

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);
    }
  }
}
