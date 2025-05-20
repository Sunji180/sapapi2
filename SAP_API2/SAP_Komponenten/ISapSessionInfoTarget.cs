using System.Runtime.InteropServices;

namespace SAP_API
{
  public class MyGuiSessionInfo
  {
    public interface ISapSessionInfoTarget
    {
      [DispId(33507)]
      string SystemName { get; }

      [DispId(33521)]
      bool ScriptingModeRecordingDisabled { get; }

      [DispId(33520)]
      bool ScriptingModeReadOnly { get; }

      [DispId(33528)]
      int UI_GUIDELINE { get; }

      [DispId(33519)]
      bool IsLowSpeedConnection { get; }

      [DispId(33518)]
      string SystemSessionId { get; }

      [DispId(33517)]
      int SessionNumber { get; }

      [DispId(33516)]
      int SystemNumber { get; }

      [DispId(33515)]
      string Group { get; }

      [DispId(33513)]
      string MessageServer { get; }

      [DispId(33504)]
      int RoundTrips { get; }

      [DispId(33503)]
      int Flushes { get; }

      [DispId(33501)]
      int InterpretationTime { get; }

      [DispId(33500)]
      int ResponseTime { get; }

      [DispId(33506)]
      int ScreenNumber { get; }

      [DispId(33505)]
      string Program { get; }

      [DispId(33502)]
      string Transaction { get; }

      [DispId(33512)]
      int Codepage { get; }

      [DispId(33511)]
      string Language { get; }

      [DispId(33510)]
      string User { get; }

      [DispId(33509)]
      string Client { get; }

      [DispId(33508)]
      string ApplicationServer { get; }

      [DispId(33523)]
      int GuiCodepage { get; }

      [DispId(33524)]
      bool I18NMode { get; }
    }
  }
}
