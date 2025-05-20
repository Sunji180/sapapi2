using System;
using SAP_API.GUI;
using SAPFEWSELib;

namespace SAP_API
{
  public class SapGui_GuiCTextField
  {
    public static void Get_Set_GuiCTextField()
    {
      // Get the current session from the static variables.
      var session = StaticVariables.session;
      GuiCTextField sapGuiCTextField;
      GuiStatusbar sapGuiStatusBar;

      try
      {
        // Scan fields
        ScanFields.Scan();

        // Assume that SapObject holds a GuiCTextField.
        sapGuiCTextField = StaticVariables.SapObject as GuiCTextField;
        if (sapGuiCTextField != null)
        {
          // Set the focus on the GuiCTextField
          sapGuiCTextField.SetFocus();

          // Execute specific GUI type method.
          // If the EmptyField flag is true, clear the field.
          if (StaticVariables.EmptyField)
          {
            sapGuiCTextField.Text = "";
          }

          // If SapValue is not empty, assign it to the field.
          if (!string.IsNullOrEmpty(StaticVariables.SapValue))
          {
            sapGuiCTextField.Text = StaticVariables.SapValue;
          }
        }

        //###################################################################################
        // The following code is commented in the VB source.
        /*
        // Read the status bar from the main window
        sapGuiStatusBar = session.FindById("wnd[0]/sbar") as GuiStatusbar;
        Sap_Output_SAP_Statusbar = "Type: " + sapGuiStatusBar.MessageType + " Text: " + sapGuiStatusBar.Text;

        // The result of the function was successful.
        Sap_Output_SAP_Result_of_Function = true;
        */
      }
      catch (Exception ex)
      {
        // The catch block in the original VB code is used to mark failure.
        // Optionally, you might handle or log the exception here.
        /*
        Sap_Output_SAP_Result_of_Function = false;
        Sap_Output_SAP_ErrNumber = ex.HResult.ToString();
        Sap_Output_SAP_ErrNumberMessage = ex.Message.ToString();
        */
      }
    }
  }
}
