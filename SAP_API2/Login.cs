namespace SAP_API
{
  using SAPFEWSELib;
  using System;
  using System.Activities;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Security;

  using System.Threading;

  public class Login : CodeActivity
  {
    [Category("01 Sap System"), Description("Sap Login via System-Description")]
    public InArgument<string> SapSystemname { get; set; }

    [Category("01 Sap System"), Description("Optional SAP Login via Connectionstring")]
    public InArgument<string> SapConnectionString { get; set; }

    [Category("01 Sap System"), Description("Path to saplogon.exe")]
    public InArgument<string> SapLogonFilepath { get; set; }

    [Category("02 Login"), RequiredArgument]
    public InArgument<string> Username { get; set; }

    [Category("02 Login"), RequiredArgument]
    public InArgument<SecureString> Password { get; set; }

    [Category("03 Output: Application / Connection / Session")]
    public OutArgument<object> SapApplication { get; set; }

    [Category("03 Output: Application / Connection / Session")]
    public OutArgument<object> SapConnection { get; set; }

    [Category("03 Output: Application / Connection / Session")]
    public OutArgument<object> SapSession { get; set; }

    [Category("04 Output: Error"), RequiredArgument]
    public OutArgument<bool> SapError { get; set; }

    [Category("04 Output: Error")]
    public OutArgument<int> SapErrNumber { get; set; }

    [Category("04 Output: Error")]
    public OutArgument<string> SapErrMessage { get; set; }

    [Category("05 Optional")]
    public InArgument<bool> SapMultilogin { get; set; }

    [Category("05 Optional")]
    public InArgument<bool> CloseFirstPopUp { get; set; }


    protected override void Execute(CodeActivityContext context)
    {
      Console.WriteLine("sgksg");

      GuiApplication application = null;
      GuiConnection connection = null;
      GuiSession session = null;

      string sapSystem = SapSystemname.Get(context);
      string sapUser = Username.Get(context);
      SecureString sapSecurePassword = Password.Get(context);
      bool multilogin = SapMultilogin.Get(context);
      string sapPassword = new System.Net.NetworkCredential(string.Empty, sapSecurePassword).Password;
      bool closePopUp = CloseFirstPopUp.Get(context);
      string path = SapLogonFilepath.Get(context) ?? "C:\\Program Files (x86)\\SAP\\FrontEnd\\SapGui\\saplogon.exe";

      try
      {
        Process[] processes = Process.GetProcessesByName("saplogon");
        if (processes.Length == 0)
        {
          if (!StartSapLogon(path))
            throw new Exception("Sap Logon could not be started");
        }
        else
        {
          if (!CloseAllActiveSessions())
            throw new Exception("Could not close all active SAP sessions");
        }

        var objWrapper = Activator.CreateInstance(Type.GetTypeFromProgID("SapROTWr.SapROTWrapper"));
        var objRotSAPGUI = objWrapper.GetType().InvokeMember("GetROTEntry", System.Reflection.BindingFlags.InvokeMethod, null, objWrapper, new object[] { "SAPGUI" });
        application = (GuiApplication)objRotSAPGUI.GetType().InvokeMember("GetScriptingEngine", System.Reflection.BindingFlags.InvokeMethod, null, objRotSAPGUI, null);

        connection = application.OpenConnection(sapSystem, true);
        session = (GuiSession)connection.Children.Item(0);
        ((GuiTextField)session.FindById("wnd[0]/usr/txtRSYST-BNAME") as GuiTextField).Text = sapUser;
        ((GuiPasswordField)session.FindById("wnd[0]/usr/pwdRSYST-BCODE") as GuiPasswordField).Text = sapPassword;
        ((GuiTextField)session.FindById("wnd[0]/usr/txtRSYST-LANGU") as GuiTextField).Text = "DE";
        ((GuiFrameWindow)session.FindById("wnd[0]")).SendVKey(0);
      }
      catch (Exception ex)
      {
        SapError.Set(context, true);
        SapErrNumber.Set(context, ex.HResult);
        SapErrMessage.Set(context, ex.Message);
        return;
      }

      if (multilogin)
      {
        try
        {
          ((GuiRadioButton)session.FindById("wnd[1]/usr/radMULTI_LOGON_OPT2")).Select();
          ((GuiRadioButton)session.FindById("wnd[1]/usr/radMULTI_LOGON_OPT2")).SetFocus();
          ((GuiButton)session.FindById("wnd[1]/tbar[0]/btn[0]")).Press();
        }
        catch { }
      }

      if (closePopUp)
      {
        try
        {
          ((GuiFrameWindow)session.FindById("wnd[1]")).SendVKey(0);
          ((GuiFrameWindow)session.FindById("wnd[0]")).SendVKey(0);
        }
        catch { }
      }

      try
      {
        ((GuiFrameWindow)session.FindById("wnd[0]")).Maximize();
        if (session.Info.User != sapUser)
          throw new Exception($"User: {sapUser} couldn't login to System: {sapSystem}");

        SapApplication.Set(context, application);
        SapConnection.Set(context, connection);
        SapSession.Set(context, session);
      }
      catch (Exception ex)
      {
        SapError.Set(context, true);
        SapErrNumber.Set(context, ex.HResult);
        SapErrMessage.Set(context, ex.Message);
      }
    }

    private bool StartSapLogon(string processPath)
    {
      try
      {
        Process objProcess = new Process();
        objProcess.StartInfo.FileName = processPath;
        objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
        objProcess.Start();

        Thread.Sleep(4000);
        return true;
      }
      catch
      {
        return false;
      }
    }

    private bool CloseAllActiveSessions()
    {
      try
      {
        var objWrapper = Activator.CreateInstance(Type.GetTypeFromProgID("SapROTWr.SapROTWrapper"));
        var objRotSAPGUI = objWrapper.GetType().InvokeMember("GetROTEntry", System.Reflection.BindingFlags.InvokeMethod, null, objWrapper, new object[] { "SAPGUI" });
        var application = (GuiApplication)objRotSAPGUI.GetType().InvokeMember("GetScriptingEngine", System.Reflection.BindingFlags.InvokeMethod, null, objRotSAPGUI, null);

        foreach (GuiConnection conn in application.Children)
        {
          foreach (GuiSession sess in conn.Children)
          {
            ((GuiFrameWindow)sess.FindById("wnd[0]")).Close();
            try { ((GuiButton)sess.FindById("wnd[1]/usr/btnSPOP-OPTION1")).Press(); } catch { }
            try { ((GuiButton)sess.FindById("wnd[2]/usr/btnSPOP-OPTION1")).Press(); } catch { }
            try { ((GuiButton)sess.FindById("wnd[3]/usr/btnSPOP-OPTION1")).Press(); } catch { }
          }
        }
        return true;
      }
      catch { return false; }
    }
  }

}