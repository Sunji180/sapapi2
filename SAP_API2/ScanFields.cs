using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows;
//using System.Windows.Forms;  // For MessageBox
using SAP_API.GUI;
using SAPFEWSELib;

namespace SAP_API
{
  public class ScanFields
  {
    public static void Scan()
    {
      var session = StaticVariables.session;
      int i = 0;
      if (StaticVariables.PopUpWindow == 0)
        i = 0;
      else
        i = StaticVariables.PopUpWindow;

      // Set default area
      object Area = session.FindById($"wnd[{i}]");

      // Determine the parent object
      switch (StaticVariables.SapSearchMethod_Parent)
      {
        case (int) SearchMethods.DefaultValue:
          // Do nothing; use default area.
          break;
        case (int)  SearchMethods.FindById:
          Area = session.FindById(StaticVariables.FindById_Parent);
          break;
        case (int) SearchMethods.FindByName:
          ScanFieldsbyName(Area, StaticVariables.application, StaticVariables.FindByName_Parent, StaticVariables.SapGuiFieldType_Parent);
          Area = session.FindById(StaticVariables.ScanFields_ReturnID);
          break;
        case (int) SearchMethods.FindByObject:
          Area = StaticVariables.FindByObject_Parent;
          break;
        case (int) SearchMethods.FindByText:
          ScanFieldsbyText(Area, StaticVariables.application, StaticVariables.FindByText_Parent, StaticVariables.SapGuiFieldType_Parent);
          Area = session.FindById(StaticVariables.ScanFields_ReturnID);
          break;
        default:
          MessageBox.Show("Searchtype_Parent Error");
          break;
      }

      // Narrow the SAP area to the parent element (if defined) for FindByName and FindByText.
      switch (StaticVariables.SapSearchMethod)
      {
        case (int) SearchMethods.DefaultValue:
          break;
        case (int) SearchMethods.FindById:
          // Use the ID directly.
          StaticVariables.ScanFields_ReturnID = StaticVariables.FindById;
          StaticVariables.SapObject = session.FindById(StaticVariables.ScanFields_ReturnID);
          break;
        case (int) SearchMethods.FindByName:
          ScanFieldsbyName(Area, StaticVariables.application, StaticVariables.FindByName, StaticVariables.SapGuiFieldType);
          StaticVariables.SapObject = session.FindById(StaticVariables.ScanFields_ReturnID);
          break;
        case (int) SearchMethods.FindByObject:
          StaticVariables.SapObject = StaticVariables.FindByObject;
          break;
        case (int) SearchMethods.FindByText:
          ScanFieldsbyText(Area, StaticVariables.application, StaticVariables.FindByText, StaticVariables.SapGuiFieldType);
          StaticVariables.SapObject = session.FindById(StaticVariables.ScanFields_ReturnID);
          break;
        default:
          MessageBox.Show("Searchtype Error");
          break;
      }

      // If a FieldIndex is specified, dynamically rebuild the ID.
      if (!string.IsNullOrWhiteSpace(StaticVariables.FieldIndex))
      {
        // Assume SapObject has a property ID (use dynamic for late binding)
        StaticVariables.ScanFields_ReturnID = ((dynamic)StaticVariables.SapObject).ID;
        var splitFieldIndex = StaticVariables.FieldIndex.Split(';');
        // Find a substring matching the pattern "[number,number]"
        string toReplace = Regex.Match(StaticVariables.ScanFields_ReturnID, @"\[[0-9]+,[0-9]+\]").Groups[0].Value;
        StaticVariables.ScanFields_ReturnID = StaticVariables.ScanFields_ReturnID
            .Replace(toReplace, $"[{splitFieldIndex[0]},{splitFieldIndex[1]}]");
        StaticVariables.SapObject = session.FindById(StaticVariables.ScanFields_ReturnID);
      }
    }

    public static void ScanFieldsbyName(object Area, GuiApplication Application_SAP, string SapFieldName, string SapFieldType)
    {
      try
      {
        // Use dynamic binding to call FindByName on the Area.
        var result = ((dynamic)Area).FindByName(SapFieldName, SapFieldType);
        StaticVariables.ScanFields_ReturnID = result.ID;
      }
      catch (Exception ex)
      {
        StaticVariables.ScanFields_ReturnErrMessage = ex.Message.ToString();
      }
    }

    public static void ScanFieldsbyText(object Area, GuiApplication Application_SAP, string SapFieldName, string SapFieldType)
    {
      object Children = null;
      int i = 0;
      object Obj = null;
      object ObjChildren = null;
      object NextArea = null;

      try
      {
        Children = ((dynamic)Area).Children();
        int count = ((dynamic)Children).Count();
        for (i = 0; i < count; i++)
        {
          Obj = ((dynamic)Children)[i];

          // Check if the object's type and text match the parameters.
          if (((dynamic)Obj).Type == SapFieldType && ((dynamic)Obj).Text == SapFieldName)
          {
            StaticVariables.ScanFields_ReturnID = ((dynamic)Obj).ID;
          }

          // If the object is a container, scan its children recursively.
          if (((dynamic)Obj).ContainerType() == true)
          {
            ObjChildren = ((dynamic)Obj).Children();
            if (((dynamic)ObjChildren).Count() > 0)
            {
              NextArea = Application_SAP.FindById(((dynamic)Obj).ID);
              ScanFieldsbyText(NextArea, Application_SAP, SapFieldName, SapFieldType);
              NextArea = null;
            }
            ObjChildren = null;
          }
          Obj = null;
        }
        Children = null;
      }
      catch (Exception ex)
      {
        StaticVariables.ScanFields_ReturnErrMessage = ex.Message.ToString();
      }
    }

    public static void ScanAll(object Area, GuiApplication Application_SAP)
    {
      object Children = null;
      int i = 0;
      object Obj = null;
      object ObjChildren = null;
      object NextArea = null;

      try
      {
        Children = ((dynamic)Area).Children();
        int count = ((dynamic)Children).Count();
        for (i = 0; i < count; i++)
        {
          Obj = ((dynamic)Children)[i];

          // Create a new DataRow and fill in details from the object.
          DataRow dr = StaticVariables.dt_SapElementCollection.NewRow();
          dr["SapFieldName"] = ((dynamic)Obj).Name;
          dr["SapFieldText"] = ((dynamic)Obj).Text;
          dr["SapFieldType"] = ((dynamic)Obj).Type;
          dr["SapFieldToolTip"] = ((dynamic)Obj).ToolTip;
          dr["SapFieldDefaultToolTip"] = ((dynamic)Obj).DefaultToolTip;
          dr["SapObject"] = Obj;
          dr["ID"] = ((dynamic)Obj).ID;

          StaticVariables.dt_SapElementCollection.Rows.Add(dr);

          if (((dynamic)Obj).ContainerType() == true)
          {
            ObjChildren = ((dynamic)Obj).Children();
            if (((dynamic)ObjChildren).Count() > 0)
            {
              NextArea = Application_SAP.FindById(((dynamic)Obj).ID);
              ScanAll(NextArea, Application_SAP);
              NextArea = null;
            }
            ObjChildren = null;
          }
          Obj = null;
        }
        Children = null;
      }
      catch (Exception ex)
      {
        // Exception is silently caught.
      }
    }

    public static void LoopAndSearchTree(string path, GuiTree guiTree, string searchString)
    {
      // Declare variables
      string key = guiTree.GetNodeKeyByPath(path); // NodeKey
      string text = guiTree.GetNodeTextByPath(path); // NodeText (displayed text)
      int subStringResult = 0;
      int i;
      int lengt;
      int Last;

      // Split the search string using semicolon as delimiter.
      string[] substringArray = searchString.Split(';');

      // Loop through the substrings; if every substring is found in text, mark as found.
      for (int t = 0; t < substringArray.Length; t++)
      {
        // In VB, InStr returns a position (1-based). In C#, IndexOf returns -1 if not found.
        if (text.IndexOf(substringArray[t], StringComparison.OrdinalIgnoreCase) >= 0)
        {
          subStringResult = 1; // Found
        }
        else
        {
          subStringResult = 0; // Not found; exit loop.
          break;
        }
      }

      // If all substrings are found...
      if (subStringResult > 0)
      {
        try
        {
          guiTree.SelectNode(key);
          // guiTree.SelectContextMenuItem("XXEXEC"); // commented out as in VB
          guiTree.ExpandNode(key);
          // guiTree.DoubleClickNode(key); // commented out as in VB
          guiTree.SelectedNode = key;
        }
        catch { }
        StaticVariables.ReturnPath = path;
        return;
      }

      // If key is empty and path length <= 1, do nothing.
      if (string.IsNullOrEmpty(key) && path.Length <= 1)
      {
        // Do nothing.
      }
      else if (string.IsNullOrEmpty(key) && path.Length > 1)
      {
        i = 1;
        // prev is unused in the conversion.
        path = GetNextParent(path);
        LoopAndSearchTree(path, guiTree, searchString);
      }
      else
      {
        try
        {
          guiTree.ExpandNode(key);
        }
        catch { }

        if (guiTree.GetNodeChildrenCount(key) > 0)
        {
          i = 1;
          path = path + "/" + i;
          i = i + 1;
        }
        else
        {
          lengt = path.Length;
          // Get the last character of path and convert to integer.
          string lastStr = path.Substring(path.Length - 1);
          if (!int.TryParse(lastStr, out Last))
          {
            Last = 0;
          }
          Last = Last + 1;
          path = path.Substring(0, lengt - 1) + Last.ToString();
          i = 1;
        }
        LoopAndSearchTree(path, guiTree, searchString);
      }
    }

    public static string GetNextParent(string pat)
    {
      if (pat.IndexOf("/") >= 0)
      {
        string[] pathArray = pat.Split('/');
        int pathArrayCount = pathArray.Length;
        string tmpPath = "";
        int lastElement = 1;
        for (int j = 0; j < pathArrayCount - 1; j++)
        {
          if (j == pathArrayCount - 2)
          {
            if (!int.TryParse(pathArray[j], out lastElement))
            {
              lastElement = 1;
            }
            lastElement = lastElement + 1;
            if (string.IsNullOrEmpty(tmpPath))
            {
              tmpPath = lastElement.ToString();
            }
            else
            {
              tmpPath = tmpPath + "/" + lastElement.ToString();
            }
          }
          else
          {
            if (string.IsNullOrEmpty(tmpPath))
            {
              tmpPath = pathArray[j];
            }
            else
            {
              tmpPath = tmpPath + "/" + pathArray[j];
            }
          }
        }
        return tmpPath;
      }
      else
      {
        return pat;
      }
    }
  }
}
