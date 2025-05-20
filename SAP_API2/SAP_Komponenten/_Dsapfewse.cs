using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiApplication
  {
    public interface _Dsapfewse
    {
      // No DispId attribute was specified in VB for Id.
      string Id { get; }

      [DispId(32900)]
      GuiComponentCollection Connections { get; }

      [DispId(32901)]
      bool ToolbarVisible { get; set; }

      [DispId(32902)]
      bool StatusbarVisible { get; set; }

      [DispId(32903)]
      bool ButtonbarVisible { get; set; }

      [DispId(32904)]
      bool TitlebarVisible { get; set; }

      [DispId(32907)]
      bool Inplace { get; set; }

      [DispId(32909)]
      int MajorVersion { get; }

      [DispId(32910)]
      int MinorVersion { get; }

      [DispId(32919)]
      int Patchlevel { get; }

      [DispId(32920)]
      int Revision { get; }

      [DispId(32912)]
      bool NewVisualDesign { get; }

      [DispId(32917)]
      GuiUtils Utils { get; }

      [DispId(32916)]
      bool HistoryEnabled { get; set; }

      [DispId(32924)]
      string ConnectionErrorText { get; }

      [DispId(32925)]
      bool AllowSystemMessages { get; set; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      [DispId(32038)]
      GuiComponent Parent { get; }

      [DispId(32927)]
      GuiCollection WDSessions { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32001)]
      string Name { get; }

      [DispId(32049)]
      object ActiveSession { get; }

      // Methods
      void Quit();

      [DispId(32908)]
      void Ignore([ComAliasName("stdole.OLE_HANDLE")] int WindowHandle);

      void ECATTReplay();

      [DispId(32923)]
      void RevokeROT();

      [DispId(32921)]
      bool RegisterROT();

      object GetScriptingEngine();

      [DispId(32075)]
      object SetCookie([ComAliasName("stdole.OLE_HANDLE")] int WindowHandle);

      [DispId(32914)]
      bool DropHistory();

      [DispId(32913)]
      bool AddHistoryEntry(string Fieldname, string Value);

      [DispId(32911)]
      object CreateGuiCollection();

      [DispId(32918)]
      GuiConnection OpenConnectionByConnectionString(string ConnectString, object Sync = null, object Raise = null);

      int OpenWDConnection(string Description);

      [DispId(32905)]
      GuiConnection OpenConnection(string Description, object Sync = null, object Raise = null);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);
    }
  }
}
