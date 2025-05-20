using System;
using SAP_API.GUI;
using SAPFEWSELib;

namespace SAP_API
{
  public static class SapGuiConnection
  {
    public static GuiApplication GetApplication()
    {
      try
      {
        // Erzeugen des COM-Objekts SapROTWrapper
        dynamic objWrapper = Activator.CreateInstance(Type.GetTypeFromProgID("SapROTWr.SapROTWrapper"));
        // Abrufen des Eintrags "SAPGUI" aus dem ROT
        dynamic objRotSAPGUI = objWrapper.GetROTEntry("SAPGUI");

        // Aufrufen der Methode GetScriptingEngine und expliziter Cast in GuiApplication
        StaticVariables.application = (GuiApplication)objRotSAPGUI.GetScriptingEngine();
        return StaticVariables.application;
      }
      catch
      {
        return null;
      }
    }

    public static GuiConnection GetConnection(object application)
    {
      try
      {
        // Casting des übergebenen Objekts in dynamic, um auf Children zugreifen zu können
        dynamic app = application;
        StaticVariables.connection = (GuiConnection)app.Children.Item(0);
        return StaticVariables.connection;
      }
      catch
      {
        return null;
      }
    }

    public static GuiSession GetSession(object connection)
    {
      try
      {
        dynamic con = connection;
        StaticVariables.session = (GuiSession)con.Children.Item(0);
        return StaticVariables.session;
      }
      catch
      {
        return null;
      }
    }

    public static GuiSession GetSapGuiSession()
    {
      try
      {
        StaticVariables.application = GetApplication();
        StaticVariables.connection = GetConnection(StaticVariables.application);
        StaticVariables.session = GetSession(StaticVariables.connection);
        return StaticVariables.session;
      }
      catch
      {
        return null;
      }
    }
  }
}
