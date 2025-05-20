using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiSession
  {
    public interface ISapSessionTarget
    {
      [DispId(32804)]
      bool Record { get; set; }

      [DispId(32814)]
      string RecordFile { get; set; }

      [DispId(32803)]
      bool Busy { get; set; }

      [DispId(32819)]
      bool IsActive { get; set; }

      [DispId(32823)]
      bool SaveAsUnicode { get; set; }

      [DispId(33527)]
      bool ShowDropdownKeys { get; set; }

      [DispId(32820)]
      string PassportTransactionId { get; set; }

      [DispId(32821)]
      string PassportPreSystemId { get; set; }

      [DispId(32822)]
      string PassportSystemId { get; set; }

      [DispId(32824)]
      GuiCollection ErrorList { get; set; }

      [DispId(32829)]
      bool AccEnhancedTabChain { get; set; }

      [DispId(32813)]
      int TestToolMode { get; set; }

      [DispId(32830)]
      bool AccSymbolReplacement { get; set; }

      [DispId(32841)]
      int ListBoxTop { get; }

      [DispId(32842)]
      int ListBoxLeft { get; }

      [DispId(32843)]
      int ListBoxWidth { get; }

      [DispId(32844)]
      int ListBoxHeight { get; }

      [DispId(32845)]
      int ListBoxCurrEntryTop { get; }

      [DispId(32846)]
      int ListBoxCurrEntryLeft { get; }

      [DispId(32847)]
      int ListBoxCurrEntryWidth { get; }

      [DispId(32848)]
      int ListBoxCurrEntryHeight { get; }

      [DispId(32849)]
      int ListBoxCurrEntry { get; }

      [DispId(32832)]
      int ProgressPercent { get; }

      [DispId(32840)]
      bool IsListBoxActive { get; }

      [DispId(32833)]
      string ProgressText { get; }

      [DispId(32834)]
      bool SuppressBackendPopups { get; set; }

      [DispId(32800)]
      GuiFrameWindow ActiveWindow { get; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

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

      [DispId(32802)]
      GuiSessionInfo Info { get; }

      [DispId(32806)]
      void SendCommandAsync(string Command);

      [DispId(32807)]
      void SendMenu(string Item);

      [DispId(32816)]
      void RunScriptControl(string Text, int nLanguage);

      [DispId(32812)]
      void CreateSession();

      [DispId(32827)]
      void UnlockSessionUI();

      [DispId(32825)]
      void ClearErrorList();

      [DispId(32826)]
      void LockSessionUI();

      [DispId(32809)]
      void StartTransaction(string Transaction);

      [DispId(32828)]
      void EnableJawsEvents();

      [DispId(32805)]
      void SendCommand(string Command);

      [DispId(32810)]
      void EndTransaction();

      [DispId(33526)]
      string AsStdNumberFormat(string Number);

      [DispId(32818)]
      GuiCollection FindByPosition(int x, int y, object Raise = null);

      [DispId(33525)]
      string GetIconResourceName(string Text);

      [DispId(32817)]
      string GetVKeyDescription(int VKey);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);
    }
  }
}
