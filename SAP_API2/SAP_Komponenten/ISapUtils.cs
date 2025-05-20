using System.Runtime.InteropServices;

namespace SAP_API
{
  public class MyGuiUtils
  {
    public interface ISapUtils
    {
      [DispId(34208)]
      int MESSAGE_TYPE_ERROR { get; }

      [DispId(34231)]
      int MESSAGE_RESULT_OK { get; }

      [DispId(34230)]
      int MESSAGE_RESULT_CANCEL { get; }

      [DispId(34222)]
      int MESSAGE_OPTION_OKCANCEL { get; }

      [DispId(34221)]
      int MESSAGE_OPTION_YESNO { get; }

      [DispId(34220)]
      int MESSAGE_OPTION_OK { get; }

      [DispId(34209)]
      int MESSAGE_TYPE_PLAIN { get; }

      [DispId(34232)]
      int MESSAGE_RESULT_YES { get; }

      [DispId(34233)]
      int MESSAGE_RESULT_NO { get; }

      [DispId(34206)]
      int MESSAGE_TYPE_QUESTION { get; }

      [DispId(34205)]
      int MESSAGE_TYPE_INFORMATION { get; }

      [DispId(34207)]
      int MESSAGE_TYPE_WARNING { get; }

      [DispId(34204)]
      void WriteLine(int File, string Text);

      [DispId(34203)]
      void Write(int File, string Text);

      [DispId(34202)]
      void CloseFile(int File);

      [DispId(34201)]
      int OpenFile(string Name);

      [DispId(34200)]
      int ShowMessageBox(string Title, string Text, int MsgIcon, int MsgType);
    }
  }
}
