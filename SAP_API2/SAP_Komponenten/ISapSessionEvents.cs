using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiSessionEvents
  {
    public interface ISapSessionEvents
    {
      [DispId(1280)]
      void Change(GuiSession session, GuiComponent component, object commandArray);

      [DispId(514)]
      void StartRequest(GuiSession session);

      [DispId(515)]
      void EndRequest(GuiSession session);

      [DispId(1283)]
      void Destroy(GuiSession session);

      [DispId(516)]
      void Error(GuiSession session, int errorId, string desc1, string desc2, string desc3, string desc4);

      [DispId(1281)]
      void Hit(GuiSession session, GuiComponent component, string innerObject);

      [DispId(1282)]
      void ContextMenu(GuiSession session, GuiVComponent component);

      [DispId(1284)]
      void AutomationFCode(GuiSession session, string functionCode);

      [DispId(1285)]
      void Activated(GuiSession session);

      [DispId(1286)]
      void FocusChanged(GuiSession session, GuiVComponent newFocusedControl);

      [DispId(1287)]
      void HistoryOpened(GuiSession session, GuiVComponent newFocusedControl);

      [DispId(1288)]
      void ProgressIndicator(int percentage, string text);

      [DispId(1289)]
      void AbapScriptingEvent(string param);
    }
  }
}
