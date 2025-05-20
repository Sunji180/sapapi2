using SAPFEWSELib;
using System.Data;

namespace SAP_API
{
  public static class StaticVariables
  {
    // SapConnections
    public static GuiApplication application;
    public static GuiConnection connection;
    public static GuiSession session;

    // Inarguments
    public static string FindById;
    public static string FindByName;
    public static string FindByText;
    public static object FindByObject;
    public static string SapGuiFieldType;
    public static string FindById_Parent;
    public static string FindByName_Parent;
    public static string FindByText_Parent;
    public static object FindByObject_Parent;
    public static string SapGuiFieldType_Parent;

    public static string Value;
    public static int PopUpWindow;
    public static string SapGuiTypeMember;
    public static bool EmptyField;

    public static object SapMemberParam1;
    public static object SapMemberParam2;
    public static object SapMemberParam3;

    // OutArguments
    public static bool SapExecutionStatus;
    public static int SapErrorNumber;
    public static string SapErrorMessage;
    public static string SapSatusbar;
    public static object SapProperties;
    public static object SapGuiObject;

    // Input Parameter Workflow
    public static object SapFieldName;
    public static string SapFieldType;
    public static object SapFieldName_Parent;
    public static string SapFieldType_Parent;
    public static string SapValue;
    public static string SapMethod;
    public static object SapMethodValue;
    public static string SapActiveWindow;
    public static string FieldIndex;

    public static int SapSearchMethod;
    public static int SapSearchMethod_Parent;

    public static DataTable SapGuiTypeInfoDt;

    // Scan Fields
    public static string ReturnPath;
    public static string ScanFields_ReturnID;
    public static string ScanFields_ReturnErrMessage;
    public static string SearchTyp;
    public static object SapObject;

    // Additional field collection
    public static DataTable dt_SapElementCollection;

    public static void Clear_SapConnection()
    {
      application = null;
      connection = null;
      session = null;
    }

    public static void Clear_InOutInputParameter()
    {
      FindById = null;
      FindByName = null;
      FindByText = null;
      FindByObject = null;
      SapGuiFieldType = null;
      PopUpWindow = 0;
      FieldIndex = null;
      FindById_Parent = null;
      FindByName_Parent = null;
      FindByText_Parent = null;
      FindByObject_Parent = null;
      SapGuiFieldType_Parent = null;
      EmptyField = false;
      Value = null;
      SapGuiTypeMember = null;
    }

    public static void Clear_ScanFieldsParameter()
    {
      ReturnPath = null;
      ScanFields_ReturnID = null;
      ScanFields_ReturnErrMessage = null;
      SearchTyp = null;
      SapObject = null;
    }

    public static void ClearAll_StaticVariables()
    {
      Clear_SapConnection();
      Clear_InOutInputParameter();
      Clear_ScanFieldsParameter();
    }
  }
}
