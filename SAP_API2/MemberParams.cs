using System;
using System.Data;
using System.Reflection;
using SAP_API; // Adjust namespace as needed

namespace SAP_API{
  public static class MemberParams
  {
    public static void GetGuiTypeInfo(SapGuiComponentType sapGuiType)
    {
      // Reset stored DataTable
      StaticVariables.SapGuiTypeInfoDt = null;

      DataTable table = new DataTable();
      DataTable dtResult = new DataTable();

      // Define columns
      table.Columns.Add("Enum", typeof(string));
      table.Columns.Add("Method", typeof(string));
      table.Columns.Add("Methodname", typeof(string));
      table.Columns.Add("Returntype", typeof(string));
      table.Columns.Add("Param1", typeof(string));
      table.Columns.Add("DataType1", typeof(string));
      table.Columns.Add("IsIn1", typeof(bool));
      table.Columns.Add("IsOut1", typeof(bool));
      table.Columns.Add("IsOptional1", typeof(bool));
      table.Columns.Add("Param2", typeof(string));
      table.Columns.Add("DataType2", typeof(string));
      table.Columns.Add("IsIn2", typeof(bool));
      table.Columns.Add("IsOut2", typeof(bool));
      table.Columns.Add("IsOptional2", typeof(bool));
      table.Columns.Add("Param3", typeof(string));
      table.Columns.Add("DataType3", typeof(string));
      table.Columns.Add("IsIn3", typeof(bool));
      table.Columns.Add("IsOut3", typeof(bool));
      table.Columns.Add("IsOptional3", typeof(bool));
      table.Columns.Add("Param4", typeof(string));
      table.Columns.Add("DataType4", typeof(string));
      table.Columns.Add("IsIn4", typeof(bool));
      table.Columns.Add("IsOut4", typeof(bool));
      table.Columns.Add("IsOptional4", typeof(bool));
      table.Columns.Add("Param5", typeof(string));
      table.Columns.Add("DataType5", typeof(string));
      table.Columns.Add("IsIn5", typeof(bool));
      table.Columns.Add("IsOut5", typeof(bool));
      table.Columns.Add("IsOptional5", typeof(bool));
      table.Columns.Add("Param6", typeof(string));
      table.Columns.Add("DataType6", typeof(string));
      table.Columns.Add("IsIn6", typeof(bool));
      table.Columns.Add("IsOut6", typeof(bool));
      table.Columns.Add("IsOptional6", typeof(bool));

      // Determine the type based on the provided SapGuiType value.
      Type myType = null;
      string methodString;
      string invokeString;

      switch (sapGuiType)
      {
        case SapGuiComponentType.GuiCTextField:
          myType = typeof(SAP_API.MyGuiCTextField.ISapCTextField);
          break;
        case SapGuiComponentType.GuiApplication:
          myType = typeof(SAP_API.MyGuiApplication._Dsapfewse);
          break;
        case SapGuiComponentType.GuiBox:
          myType = typeof(SAP_API.MyGuiBox.ISapBoxTarget);
          break;
        case SapGuiComponentType.GuiButton:
          myType = typeof(SAP_API.MyGuiButton.ISapButtonTarget);
          break;
        case SapGuiComponentType.GuiCalendar:
          myType = typeof(SAP_API.MyGuiCalendar.ISapCalendar);
          break;
        case SapGuiComponentType.GuiCheckBox:
          myType = typeof(SAP_API.MyGuiCheckBox.ISapCheckBoxTarget);
          break;
        case SapGuiComponentType.GuiCollection:
          myType = typeof(SAP_API.MyGuiCollection.ISapGenericCollection);
          break;
        case SapGuiComponentType.GuiComboBox:
          myType = typeof(SAP_API.MyGuiComboBox.ISapComboBoxTarget);
          break;
        case SapGuiComponentType.GuiComboBoxEntry:
          myType = typeof(SAP_API.MyGuiComboBoxEntry.ISapComboBoxEntryTarget);
          break;
        case SapGuiComponentType.GuiComponent:
          myType = typeof(SAP_API.MyGuiComponent.ISapComponentTarget);
          break;
        case SapGuiComponentType.GuiComponentCollection:
          myType = typeof(SAP_API.MyGuiComponentCollection.ISapCollectionTarget);
          break;
        case SapGuiComponentType.GuiConnection:
          myType = typeof(SAP_API.MyGuiConnection.ISapConnectionTarget);
          break;
        case SapGuiComponentType.GuiContainer:
          myType = typeof(SAP_API.MyGuiContainer.ISapContainerTarget);
          break;
        case SapGuiComponentType.GuiContainerShell:
          myType = typeof(SAP_API.MyGuiContainerShell.ISapCustomContainerTarget);
          break;
        case SapGuiComponentType.GuiContextMenu:
          myType = typeof(SAP_API.MyGuiContextMenu.ISapContextMenuTarget);
          break;
        case SapGuiComponentType.GuiCustomControl:
          myType = typeof(SAP_API.MyGuiCustomControl.ISapCustomControlTarget);
          break;
        case SapGuiComponentType.GuiDialogShell:
          myType = typeof(SAP_API.MyGuiDialogShell.ISapDialogShell);
          break;
        case SapGuiComponentType.GuiDockShell:
          myType = typeof(SAP_API.MyGuiContainerShell.ISapCustomContainerTarget);
          break;
        case SapGuiComponentType.GuiFrameWindow:
          myType = typeof(SAP_API.MyGuiFrameWindow.ISapWindowTarget);
          break;
        case SapGuiComponentType.GuiGridView:
          myType = typeof(SAP_API.MyGuiGridView.ISapGridViewTarget);
          break;
        case SapGuiComponentType.GridView:
          myType = typeof(SAP_API.MyGuiGridView.ISapGridViewTarget);
          break;
        case SapGuiComponentType.GuiGOSShell:
          myType = typeof(SAP_API.MyGuiGOSShell.ISapGosContainerTarget);
          break;
        case SapGuiComponentType.GuiLabel:
          myType = typeof(SAP_API.MyGuiLabel.ISapLabelTarget);
          break;
        case SapGuiComponentType.GuiMainWindow:
          myType = typeof(SAP_API.MyGuiMainWindow.ISapMainWindowTarget);
          break;
        case SapGuiComponentType.GuiMenu:
          myType = typeof(SAP_API.MyGuiMenu.IGuiMenuTarget);
          break;
        case SapGuiComponentType.GuiMenubar:
          myType = typeof(SAP_API.MyGuiMenubar.IGuiMenubarTarget);
          break;
        case SapGuiComponentType.GuiMessageWindow:
          myType = typeof(SAP_API.MyGuiMessageWindow.ISapMessageWindowTarget);
          break;
        case SapGuiComponentType.GuiModalWindow:
          myType = typeof(SAP_API.MyGuiModalWindow.ISapModalWindowTarget);
          break;
        case SapGuiComponentType.GuiOkCodeField:
          myType = typeof(SAP_API.MyGuiOkCodeField.ISapOkCodeFieldTarget);
          break;
        case SapGuiComponentType.GuiPasswordField:
          myType = typeof(SAP_API.MyGuiPasswordField.ISapPasswordField);
          break;
        case SapGuiComponentType.GuiRadioButton:
          myType = typeof(SAP_API.MyGuiRadioButton.ISapRadioButtonTarget);
          break;
        case SapGuiComponentType.GuiScrollbar:
          myType = typeof(SAP_API.MyGuiScrollbar.ISapScrollbarTarget);
          break;
        case SapGuiComponentType.GuiScrollContainer:
          myType = typeof(SAP_API.MyGuiScrollContainer.ISapScrollContainerTarget);
          break;
        case SapGuiComponentType.GuiSession:
          myType = typeof(SAP_API.MyGuiSession.ISapSessionTarget);
          break;
        case SapGuiComponentType.GuiSessionInfo:
          myType = typeof(SAP_API.MyGuiSessionInfo.ISapSessionInfoTarget);
          break;
        case SapGuiComponentType.GuiShell:
          myType = typeof(SAP_API.MyGuiShell.ISapShell);
          break;
        case SapGuiComponentType.GuiShell_Subtype_GridView:
          myType = typeof(SAP_API.MyGuiGridView.ISapGridViewTarget);
          break;
        case SapGuiComponentType.GuiShell_Subtype_Tree:
          myType = typeof(SAP_API.MyGuiTree.ISapTreeTarget);
          break;
        case SapGuiComponentType.TextEdit:
          myType = typeof(SAP_API.MyTextEdit.ISapTexteditTarget);
          break;
        case SapGuiComponentType.GuiSimpleContainer:
          myType = typeof(SAP_API.MyGuiSimpleContainer.ISapSimpleContainerTarget);
          break;
        case SapGuiComponentType.GuiSplitterContainer:
          myType = typeof(SAP_API.MyGuiSplitterContainer.ISapSplitterContainerTarget);
          break;
        case SapGuiComponentType.GuiSplit:
          myType = typeof(SAP_API.MyGuiSplit.ISapSplitTarget);
          break;
        case SapGuiComponentType.GuiStatusbar:
          myType = typeof(SAP_API.MyGuiStatusbar.ISapStatusbarTarget);
          break;
        case SapGuiComponentType.GuiStatusPane:
          myType = typeof(SAP_API.MyGuiStatusPane.ISapStatusPaneTarget);
          break;
        case SapGuiComponentType.GuiStatusbarLink:
          myType = typeof(SAP_API.MyGuiStatusbarLink.ISapStatusbarLinkTarget);
          break;
        case SapGuiComponentType.GuiTab:
          myType = typeof(SAP_API.MyGuiTab.ISapTabTarget);
          break;
        case SapGuiComponentType.GuiTableColumn:
          myType = typeof(SAP_API.MyGuiTableColumn.ISapTableColumnTarget);
          break;
        case SapGuiComponentType.GuiTableControl:
          myType = typeof(SAP_API.MyGuiTableControl.ISapTableControlTarget);
          break;
        case SapGuiComponentType.GuiTableRow:
          myType = typeof(SAP_API.MyGuiTableRow.ISapTableRowTarget);
          break;
        case SapGuiComponentType.GuiTabStrip:
          myType = typeof(SAP_API.MyGuiTabStrip.ISapTabbedPane);
          break;
        case SapGuiComponentType.GuiTextField:
          myType = typeof(SAP_API.MyGuiTextField.ISapTextFieldTarget);
          break;
        case SapGuiComponentType.GuiTitlebar:
          myType = typeof(SAP_API.MyGuiTitleBar.ISapTitleBarTarget);
          break;
        case SapGuiComponentType.GuiToolbar:
          myType = typeof(SAP_API.MyGuiToolbar.ISapToolbarTarget);
          break;
        case SapGuiComponentType.GuiToolbarControl:
          myType = typeof(SAP_API.MyGuiToolbarControl.ISapToolbarControlTarget);
          break;
        case SapGuiComponentType.GuiUserArea:
          myType = typeof(SAP_API.MyGuiUserArea.ISapScreenTarget);
          break;
        case SapGuiComponentType.GuiUtils:
          myType = typeof(SAP_API.MyGuiUtils.ISapUtils);
          break;
        case SapGuiComponentType.GuiVComponent:
          myType = typeof(SAP_API.MyGuiVComponent.ISapControlTarget);
          break;
        case SapGuiComponentType.GuiVContainer:
          myType = typeof(SAP_API.MyGuiVContainer.ISapVContainerTarget);
          break;
        case SapGuiComponentType.Tree:
          myType = typeof(SAP_API.MyGuiTree.ISapTreeTarget);
          break;
        case SapGuiComponentType.Toolbar:
          myType = typeof(SAP_API.MyGuiToolbarControl.ISapToolbarControlTarget);
          break;
        case SapGuiComponentType.HTMLViewer:
          myType = typeof(SAP_API.MyGuiHTMLViewer.ISapHTMLViewer);
          break;
      }

      if (myType != null)
      {
        // Get all properties and methods from the type via reflection.
        PropertyInfo[] properties = myType.GetProperties();
        MethodInfo[] methods = myType.GetMethods();

        foreach (MethodInfo method in methods)
        {
          DataRow dr = table.NewRow();
          methodString = method.Name;
          invokeString = method.Name;

          // If the method name starts with "set_" or "get_", remove the prefix and append a suffix.
          if (methodString.Contains("set_"))
          {
            invokeString = methodString.Substring(4);
            methodString = methodString.Substring(4) + "_set";
          }
          else if (methodString.Contains("get_"))
          {
            invokeString = methodString.Substring(4);
            methodString = methodString.Substring(4) + "_get";
          }

          dr["Enum"] = methodString;
          dr["Method"] = invokeString;
          dr["Methodname"] = method.Name;
          dr["Returntype"] = method.ReturnType.ToString();

          ParameterInfo[] pars = method.GetParameters();
          int paramIndex = 1;
          foreach (ParameterInfo p in pars)
          {
            dr["Param" + paramIndex] = p.Name;
            dr["DataType" + paramIndex] = p.ParameterType.ToString();
            dr["IsIn" + paramIndex] = p.IsIn.ToString();
            dr["IsOut" + paramIndex] = p.IsOut.ToString();
            dr["IsOptional" + paramIndex] = p.IsOptional.ToString();
            paramIndex++;
          }

          table.Rows.Add(dr);
        }

        table.DefaultView.Sort = "Enum ASC";
        dtResult = table.DefaultView.ToTable();
        StaticVariables.SapGuiTypeInfoDt = dtResult;
      }
    }
  }
}
