using System;
using System.Activities;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Threading;
using SAPFEWSELib;


namespace SAP_API
{
  // The Designer attribute is converted to C# style.
 
  public class Main : CodeActivity
  {
    //################################## Neu

    #region 01 SAP Identification

    [Category("01 SAP Identification ")]
    [Description("Find Sap Element with standard SAP ID - (e.g /app/con/ses/...)")]
    public InArgument<string> FindById { get; set; }

    [Category("01 SAP Identification ")]
    [Description("Find Sap Element with the technical Name of the Sap Gui Field")]
    public InArgument<string> FindByName { get; set; }

    [Category("01 SAP Identification ")]
    [Description("Find Sap Element with its Text Property")]
    public InArgument<string> FindByText { get; set; }

    [Category("01 SAP Identification ")]
    [Description("Set Sap Element with an already extracted Object")]
    public InArgument<object> SetElementByObject { get; set; }

    [Category("01 SAP Identification ")]
    [Description("Default = 0 , First PopUp = 1 , Second = 2 ...")]
    public InArgument<int> SetPopUpWindow { get; set; }

    [Category("01 SAP Identification ")]
    [Description("Set the specific SapGui FieldType (e.g. ")]
    public InArgument<string> SapGuiFieldType { get; set; }

    #endregion

    #region 02 optional SAP Parent Identication

    [Category("02 optional SAP Parent Identication")]
    [Description("Find Sap Element with standard SAP ID - (e.g /app/con/ses/...)")]
    public InArgument<string> FindById_Parent { get; set; }

    [Category("02 optional SAP Parent Identication")]
    [Description("Find Sap Element with the technical Name of the Sap Gui Field")]
    public InArgument<string> FindByName_Parent { get; set; }

    [Category("02 optional SAP Parent Identication")]
    [Description("Find Sap Element with its Text Property")]
    public InArgument<string> FindByText_Parent { get; set; }

    [Category("02 optional SAP Parent Identication")]
    [Description("Set Sap Element with an already extracted Object")]
    public InArgument<object> SetElementByObject_Parent { get; set; }

    [Category("02 optional SAP Parent Identication")]
    [Description("Set the specific SapGui FieldType (e.g. ")]
    public InArgument<string> SapGuiFieldType_Parent { get; set; }

    #endregion

    #region 03 Input

    [Category("03 Input")]
    [Description("Value")]
    public InArgument<string> Value { get; set; }

    [Category("03 Input")]
    public InArgument<string> SapGuiTypeMember { get; set; }

    [Category("03 Input")]
    [Description("Clear the entire Field")]
    public bool EmptyField { get; set; }

    [Category("03 Input")]
    [Description("Press Enter after Input")]
    public bool PressEnter { get; set; }

    #endregion

    #region 04 Output

    [Category("04 Output")]
    [Description("False = ok , true = Exception was thrown")]
    public OutArgument<bool> SapError { get; set; }

    [Category("04 Output")]
    [Description("Sap ErrorNumber if Error thrown")]
    public OutArgument<int> SapErrorNumber { get; set; }

    [Category("04 Output")]
    [Description("Specific Property, Method or Event from the entire SapGuiFieldType")]
    public OutArgument<string> SapErrorMessage { get; set; }

    [Category("04 Output")]
    [Description("Catched Value from Sap Statusbar")]
    public OutArgument<string> SapStatusbar { get; set; }

    [Category("04 Output")]
    [Description("Output Property")]
    public OutArgument<object> SapProperties { get; set; }

    [Category("04 Output")]
    [Description("Clear the entire Field")]
    public OutArgument<object> SapGuiObject { get; set; }

    #endregion

    #region 05 Misc

    [Category("05 Misc")]
    [Description("set GuiSession - for working with more then one SAP Session")]
    public InArgument<object> SapGuiSession { get; set; }

    [Category("05 Misc")]
    public bool ContinueOnError { get; set; }

    #endregion

    #region NonBrowsable Properties

    [Browsable(false)]
    public InArgument<string> FieldIndex { get; set; }

    [Browsable(false)]
    public InArgument<string> SapMemberParam1_String { get; set; }

    [Browsable(false)]
    public InArgument<object> SapMemberParam1_Object { get; set; }

    [Browsable(false)]
    public InArgument<int> SapMemberParam1_Int32 { get; set; }

    [Browsable(false)]
    public InArgument<bool> SapMemberParam1_Boolean { get; set; }

    [Browsable(false)]
    public InArgument<string> SapMemberParam2_String { get; set; }

    [Browsable(false)]
    public InArgument<object> SapMemberParam2_Object { get; set; }

    [Browsable(false)]
    public InArgument<int> SapMemberParam2_Int32 { get; set; }

    [Browsable(false)]
    public InArgument<bool> SapMemberParam2_Boolean { get; set; }

    [Browsable(false)]
    public InArgument<string> SapMemberParam3_String { get; set; }

    [Browsable(false)]
    public InArgument<object> SapMemberParam3_Object { get; set; }

    [Browsable(false)]
    public InArgument<int> SapMemberParam3_Int32 { get; set; }

    [Browsable(false)]
    public InArgument<bool> SapMemberParam3_Boolean { get; set; }

    [Browsable(false)]
    public InArgument<string> SapMemberParam4_String { get; set; }

    [Browsable(false)]
    public InArgument<object> SapMemberParam4_Object { get; set; }

    [Browsable(false)]
    public InArgument<int> SapMemberParam4_Int32 { get; set; }

    [Browsable(false)]
    public InArgument<bool> SapMemberParam4_Boolean { get; set; }

    [Browsable(false)]
    public InArgument<string> SapMemberParam5_String { get; set; }

    [Browsable(false)]
    public InArgument<object> SapMemberParam5_Object { get; set; }

    [Browsable(false)]
    public InArgument<int> SapMemberParam5_Int32 { get; set; }

    [Browsable(false)]
    public InArgument<bool> SapMemberParam5_Boolean { get; set; }

    [Browsable(false)]
    public InArgument<string> SapMemberParam6_String { get; set; }

    [Browsable(false)]
    public InArgument<object> SapMemberParam6_Object { get; set; }

    [Browsable(false)]
    public InArgument<int> SapMemberParam6_Int32 { get; set; }

    [Browsable(false)]
    public InArgument<bool> SapMemberParam6_Boolean { get; set; }

    [Browsable(false)]
    public string ComboBoxValue_SapGuiTypes { get; set; }

    [Browsable(false)]
    public string ComboBoxValue_SapGuiTypeParent { get; set; }

    [Browsable(false)]
    public string ComboBoxValue_Member { get; set; }

    [Browsable(false)]
    public string ComboBoxValue_Member2 { get; set; }

    [Browsable(false)]
    public string TxtForParam1 { get; set; }

    [Browsable(false)]
    public string TxtForParam2 { get; set; }

    [Browsable(false)]
    public string TxtForParam3 { get; set; }

    [Browsable(false)]
    public string TxtForParam4 { get; set; }

    [Browsable(false)]
    public string TxtForParam5 { get; set; }

    [Browsable(false)]
    public string TxtForParam6 { get; set; }

    [Browsable(false)]
    public string TxtDatatype1 { get; set; }

    [Browsable(false)]
    public string TxtDatatype2 { get; set; }

    [Browsable(false)]
    public string TxtDatatype3 { get; set; }

    [Browsable(false)]
    public string TxtDatatype4 { get; set; }

    [Browsable(false)]
    public string TxtDatatype5 { get; set; }

    [Browsable(false)]
    public string TxtDatatype6 { get; set; }

    [Browsable(false)]
    public string TxtReturntype { get; set; }

    [Browsable(false)]
    public string TxtUsingReturntype { get; set; }

    #endregion

    protected override void Execute(CodeActivityContext context)
    {
      //############################ Aufräumen (Cleanup)
      StaticVariables.ClearAll_StaticVariables();

      //############################ Übergabe Werte aus Activity - Formular (Transfer values from Activity form)
      StaticVariables.FindById = FindById.Get(context);
      StaticVariables.FindByName = FindByName.Get(context);
      StaticVariables.FindByText = FindByText.Get(context);
      StaticVariables.FindByObject = SetElementByObject.Get(context);
      StaticVariables.SapGuiFieldType = SapGuiFieldType.Get(context);
      StaticVariables.PopUpWindow = SetPopUpWindow.Get(context);
      StaticVariables.FieldIndex = FieldIndex.Get(context);
      StaticVariables.FindById_Parent = FindById_Parent.Get(context);
      StaticVariables.FindByName_Parent = FindByName_Parent.Get(context);
      StaticVariables.FindByText_Parent = FindByText_Parent.Get(context);
      StaticVariables.FindByObject_Parent = SetElementByObject_Parent.Get(context);
      StaticVariables.SapGuiFieldType_Parent = SapGuiFieldType_Parent.Get(context);
      StaticVariables.EmptyField = EmptyField;
      StaticVariables.Value = Value.Get(context);
      StaticVariables.SapGuiTypeMember = SapGuiTypeMember.Get(context);

      //######################################################################################
      //Set GuiSession
      if (SapGuiSession.Get(context) != null)
      {
        StaticVariables.session = (GuiSession)SapGuiSession.Get(context);
        StaticVariables.connection = (GuiConnection)StaticVariables.session.Parent;
        StaticVariables.application = (GuiApplication)StaticVariables.connection.Parent;
      }
      else
      {
        StaticVariables.session = SapGuiConnection.GetSapGuiSession();

        if (StaticVariables.session == null)
        {
          StaticVariables.ClearAll_StaticVariables();
          SapError.Set(context, true);
          SapErrorMessage.Set(context, "No GuiSession");
          SapGuiObject.Set(context, null);
          SapProperties.Set(context, null);
          SapStatusbar.Set(context, null);
          SapErrorNumber.Set(context, 0);
          return;
        }
      }

      try
      {
        //######################################################################################
        //Searchtype Element
        if (StaticVariables.FindByObject != null)
        {
          StaticVariables.SapSearchMethod = (int)SearchMethods.FindByObject;
        }
        else if (!string.IsNullOrWhiteSpace(StaticVariables.FindById))
        {
          StaticVariables.SapSearchMethod = (int)SearchMethods.FindById;
        }
        else if (!string.IsNullOrWhiteSpace(StaticVariables.FindByName))
        {
          StaticVariables.SapSearchMethod = (int)SearchMethods.FindByName;
        }
        else if (!string.IsNullOrWhiteSpace(StaticVariables.FindByText))
        {
          StaticVariables.SapSearchMethod = (int)SearchMethods.FindByText;
        }
        else
        {
          StaticVariables.SapSearchMethod = (int)SearchMethods.DefaultValue;
        }

        //######################################################################################
        //Searchtype for Parent Element
        if (StaticVariables.FindByObject_Parent != null)
        {
          StaticVariables.SapSearchMethod_Parent = (int)SearchMethods.FindByObject;
        }
        else if (!string.IsNullOrWhiteSpace(StaticVariables.FindById_Parent))
        {
          StaticVariables.SapSearchMethod_Parent = (int)SearchMethods.FindById;
        }
        else if (!string.IsNullOrWhiteSpace(StaticVariables.FindByName_Parent))
        {
          StaticVariables.SapSearchMethod_Parent = (int)SearchMethods.FindByName;
        }
        else if (!string.IsNullOrWhiteSpace(StaticVariables.FindByText_Parent))
        {
          StaticVariables.SapSearchMethod_Parent = (int)SearchMethods.FindByText;
        }
        else
        {
          StaticVariables.SapSearchMethod_Parent = (int)SearchMethods.DefaultValue;
        }

        //GuiTypeInfo for getting all Methods and Properties from SapGuiType with Reflection
        SapGuiComponentType SapGuiType = (SapGuiComponentType)Enum.Parse(typeof(SapGuiComponentType), StaticVariables.SapGuiFieldType);
        MemberParams.GetGuiTypeInfo(SapGuiType);

        //Start Element identification
        var Session = StaticVariables.session;
        ScanFields.Scan();
        var SapObject = StaticVariables.SapObject;

        //Ausführen der Aktion (Execute the action)
        object Tuple1, Tuple2, Tuple3, Tuple4, Tuple5, Tuple6;
        string SapMemberParam1 = null;
        string SapMemberParam2 = null;
        string SapMemberParam3 = null;
        string SapMemberParam4 = null;
        string SapMemberParam5 = null;
        string SapMemberParam6 = null;
        object Param1 = null, Param2 = null, Param3 = null, Param4 = null, Param5 = null, Param6 = null;
        object[] ParamArgs = null;

        //''''Hotfix SAP GUI Freeze by Closing Session
        bool ClosedSession = false;

        if (!string.IsNullOrWhiteSpace(StaticVariables.SapGuiTypeMember))
        {
          //callbyname
          string Enumvalue = StaticVariables.SapGuiTypeMember.Replace("\"", "").Trim();

          DataTable dt = StaticVariables.SapGuiTypeInfoDt;
          DataRow[] rows = dt.Select("Enum = '" + Enumvalue + "'");
          object Methodname = rows[0]["Method"];
          string Returntype = rows[0]["Returntype"].ToString();

          //''''Hotfix SAP GUI Freeze by Closing Session
          try
          {
            switch (SapGuiType)
            {
              case SapGuiComponentType.GuiMainWindow:
                if (Methodname.ToString().ToLower() == "close")
                {
                  ClosedSession = true;
                }
                break;
            }
          }
          catch { }

          try
          {
            // The following assignments repeat for SapMemberParam3.
            // (This mirrors the original code even though it appears to be a bug.)
            SapMemberParam1 = rows[0]["DataType1"].ToString();
            SapMemberParam2 = rows[0]["DataType2"].ToString();
            SapMemberParam3 = rows[0]["DataType3"].ToString();
            SapMemberParam3 = rows[0]["DataType4"].ToString();
            SapMemberParam3 = rows[0]["DataType5"].ToString();
            SapMemberParam3 = rows[0]["DataType6"].ToString();
          }
          catch (Exception ex_Param)
          {
            // Swallow exceptions as in the original code.
          }

          //SapMemberParams abfrage
          if (SapMemberParam6 != null)
          {
            switch (SapMemberParam6)
            {
              case "System.String":
                Param6 = SapMemberParam6_String.Get(context);
                break;
              case "System.Int32":
                Param6 = SapMemberParam6_Int32.Get(context);
                break;
              case "System.Boolean":
                Param6 = SapMemberParam6_Boolean.Get(context);
                break;
              case "System.Object":
                Param6 = SapMemberParam6_Object.Get(context);
                break;
            }

            switch (SapMemberParam5)
            {
              case "System.String":
                Param5 = SapMemberParam5_String.Get(context);
                break;
              case "System.Int32":
                Param5 = SapMemberParam5_Int32.Get(context);
                break;
              case "System.Boolean":
                Param5 = SapMemberParam5_Boolean.Get(context);
                break;
              case "System.Object":
                Param5 = SapMemberParam5_Object.Get(context);
                break;
            }

            switch (SapMemberParam4)
            {
              case "System.String":
                Param4 = SapMemberParam4_String.Get(context);
                break;
              case "System.Int32":
                Param4 = SapMemberParam4_Int32.Get(context);
                break;
              case "System.Boolean":
                Param4 = SapMemberParam4_Boolean.Get(context);
                break;
              case "System.Object":
                Param4 = SapMemberParam4_Object.Get(context);
                break;
            }

            switch (SapMemberParam3)
            {
              case "System.String":
                Param3 = SapMemberParam3_String.Get(context);
                break;
              case "System.Int32":
                Param3 = SapMemberParam3_Int32.Get(context);
                break;
              case "System.Boolean":
                Param3 = SapMemberParam3_Boolean.Get(context);
                break;
              case "System.Object":
                Param3 = SapMemberParam3_Object.Get(context);
                break;
            }

            //Select Param 2
            switch (SapMemberParam2)
            {
              case "System.String":
                Param2 = SapMemberParam2_String.Get(context);
                break;
              case "System.Int32":
                Param2 = SapMemberParam2_Int32.Get(context);
                break;
              case "System.Boolean":
                Param2 = SapMemberParam2_Boolean.Get(context);
                break;
              case "System.Object":
                Param2 = SapMemberParam2_Object.Get(context);
                break;
            }

            //Select Param 1
            switch (SapMemberParam1)
            {
              case "System.String":
                Param1 = SapMemberParam1_String.Get(context);
                break;
              case "System.Int32":
                Param1 = SapMemberParam1_Int32.Get(context);
                break;
              case "System.Boolean":
                Param1 = SapMemberParam1_Boolean.Get(context);
                break;
              case "System.Object":
                Param1 = SapMemberParam1_Object.Get(context);
                break;
            }

            Tuple6 = Create6(Param1, Param2, Param3, Param4, Param5, Param6);
            ParamArgs = new object[] {
                            ((dynamic)Tuple6).Item1,
                            ((dynamic)Tuple6).Item2,
                            ((dynamic)Tuple6).Item3,
                            ((dynamic)Tuple6).Item4,
                            ((dynamic)Tuple6).Item5,
                            ((dynamic)Tuple6).Item6
                        };
          }
          else if (SapMemberParam5 != null)
          {
            switch (SapMemberParam5)
            {
              case "System.String":
                Param5 = SapMemberParam5_String.Get(context);
                break;
              case "System.Int32":
                Param5 = SapMemberParam5_Int32.Get(context);
                break;
              case "System.Boolean":
                Param5 = SapMemberParam5_Boolean.Get(context);
                break;
              case "System.Object":
                Param5 = SapMemberParam5_Object.Get(context);
                break;
            }

            switch (SapMemberParam4)
            {
              case "System.String":
                Param4 = SapMemberParam4_String.Get(context);
                break;
              case "System.Int32":
                Param4 = SapMemberParam4_Int32.Get(context);
                break;
              case "System.Boolean":
                Param4 = SapMemberParam4_Boolean.Get(context);
                break;
              case "System.Object":
                Param4 = SapMemberParam4_Object.Get(context);
                break;
            }

            switch (SapMemberParam3)
            {
              case "System.String":
                Param3 = SapMemberParam3_String.Get(context);
                break;
              case "System.Int32":
                Param3 = SapMemberParam3_Int32.Get(context);
                break;
              case "System.Boolean":
                Param3 = SapMemberParam3_Boolean.Get(context);
                break;
              case "System.Object":
                Param3 = SapMemberParam3_Object.Get(context);
                break;
            }

            //Select Param 2
            switch (SapMemberParam2)
            {
              case "System.String":
                Param2 = SapMemberParam2_String.Get(context);
                break;
              case "System.Int32":
                Param2 = SapMemberParam2_Int32.Get(context);
                break;
              case "System.Boolean":
                Param2 = SapMemberParam2_Boolean.Get(context);
                break;
              case "System.Object":
                Param2 = SapMemberParam2_Object.Get(context);
                break;
            }

            //Select Param 1
            switch (SapMemberParam1)
            {
              case "System.String":
                Param1 = SapMemberParam1_String.Get(context);
                break;
              case "System.Int32":
                Param1 = SapMemberParam1_Int32.Get(context);
                break;
              case "System.Boolean":
                Param1 = SapMemberParam1_Boolean.Get(context);
                break;
              case "System.Object":
                Param1 = SapMemberParam1_Object.Get(context);
                break;
            }

            Tuple5 = Create5(Param1, Param2, Param3, Param4, Param5);
            ParamArgs = new object[] {
                            ((dynamic)Tuple5).Item1,
                            ((dynamic)Tuple5).Item2,
                            ((dynamic)Tuple5).Item3,
                            ((dynamic)Tuple5).Item4,
                            ((dynamic)Tuple5).Item5
                        };
          }
          else if (SapMemberParam4 != null)
          {
            switch (SapMemberParam4)
            {
              case "System.String":
                Param4 = SapMemberParam4_String.Get(context);
                break;
              case "System.Int32":
                Param4 = SapMemberParam4_Int32.Get(context);
                break;
              case "System.Boolean":
                Param4 = SapMemberParam4_Boolean.Get(context);
                break;
              case "System.Object":
                Param4 = SapMemberParam4_Object.Get(context);
                break;
            }

            switch (SapMemberParam3)
            {
              case "System.String":
                Param3 = SapMemberParam3_String.Get(context);
                break;
              case "System.Int32":
                Param3 = SapMemberParam3_Int32.Get(context);
                break;
              case "System.Boolean":
                Param3 = SapMemberParam3_Boolean.Get(context);
                break;
              case "System.Object":
                Param3 = SapMemberParam3_Object.Get(context);
                break;
            }

            //Select Param 2
            switch (SapMemberParam2)
            {
              case "System.String":
                Param2 = SapMemberParam2_String.Get(context);
                break;
              case "System.Int32":
                Param2 = SapMemberParam2_Int32.Get(context);
                break;
              case "System.Boolean":
                Param2 = SapMemberParam2_Boolean.Get(context);
                break;
              case "System.Object":
                Param2 = SapMemberParam2_Object.Get(context);
                break;
            }

            //Select Param 1
            switch (SapMemberParam1)
            {
              case "System.String":
                Param1 = SapMemberParam1_String.Get(context);
                break;
              case "System.Int32":
                Param1 = SapMemberParam1_Int32.Get(context);
                break;
              case "System.Boolean":
                Param1 = SapMemberParam1_Boolean.Get(context);
                break;
              case "System.Object":
                Param1 = SapMemberParam1_Object.Get(context);
                break;
            }

            Tuple4 = Create4(Param1, Param2, Param3, Param4);
            ParamArgs = new object[] {
                            ((dynamic)Tuple4).Item1,
                            ((dynamic)Tuple4).Item2,
                            ((dynamic)Tuple4).Item3,
                            ((dynamic)Tuple4).Item4
                        };
          }
          else if (SapMemberParam3 != null)
          {
            switch (SapMemberParam3)
            {
              case "System.String":
                Param3 = SapMemberParam3_String.Get(context);
                break;
              case "System.Int32":
                Param3 = SapMemberParam3_Int32.Get(context);
                break;
              case "System.Boolean":
                Param3 = SapMemberParam3_Boolean.Get(context);
                break;
              case "System.Object":
                Param3 = SapMemberParam3_Object.Get(context);
                break;
            }

            //Select Param 2
            switch (SapMemberParam2)
            {
              case "System.String":
                Param2 = SapMemberParam2_String.Get(context);
                break;
              case "System.Int32":
                Param2 = SapMemberParam2_Int32.Get(context);
                break;
              case "System.Boolean":
                Param2 = SapMemberParam2_Boolean.Get(context);
                break;
              case "System.Object":
                Param2 = SapMemberParam2_Object.Get(context);
                break;
            }

            //Select Param 1
            switch (SapMemberParam1)
            {
              case "System.String":
                Param1 = SapMemberParam1_String.Get(context);
                break;
              case "System.Int32":
                Param1 = SapMemberParam1_Int32.Get(context);
                break;
              case "System.Boolean":
                Param1 = SapMemberParam1_Boolean.Get(context);
                break;
              case "System.Object":
                Param1 = SapMemberParam1_Object.Get(context);
                break;
            }

            Tuple3 = Create3(Param1, Param2, Param3);
            ParamArgs = new object[] {
                            ((dynamic)Tuple3).Item1,
                            ((dynamic)Tuple3).Item2,
                            ((dynamic)Tuple3).Item3
                        };
          }
          else if (SapMemberParam2 != null)
          {
            //Select Param 2
            switch (SapMemberParam2)
            {
              case "System.String":
                Param2 = SapMemberParam2_String.Get(context);
                break;
              case "System.Int32":
                Param2 = SapMemberParam2_Int32.Get(context);
                break;
              case "System.Boolean":
                Param2 = SapMemberParam2_Boolean.Get(context);
                break;
              case "System.Object":
                Param2 = SapMemberParam2_Object.Get(context);
                break;
            }

            //Select Param 1
            switch (SapMemberParam1)
            {
              case "System.String":
                Param1 = SapMemberParam1_String.Get(context);
                break;
              case "System.Int32":
                Param1 = SapMemberParam1_Int32.Get(context);
                break;
              case "System.Boolean":
                Param1 = SapMemberParam1_Boolean.Get(context);
                break;
              case "System.Object":
                Param1 = SapMemberParam1_Object.Get(context);
                break;
            }

            Tuple2 = Create2(Param1, Param2);
            ParamArgs = new object[] {
                            ((dynamic)Tuple2).Item1,
                            ((dynamic)Tuple2).Item2
                        };
          }
          else if (SapMemberParam1 != null)
          {
            //Select Param 1
            switch (SapMemberParam1)
            {
              case "System.String":
                Param1 = SapMemberParam1_String.Get(context);
                break;
              case "System.Int32":
                Param1 = SapMemberParam1_Int32.Get(context);
                break;
              case "System.Boolean":
                Param1 = SapMemberParam1_Boolean.Get(context);
                break;
              case "System.Object":
                Param1 = SapMemberParam1_Object.Get(context);
                break;
            }

            Tuple1 = Create1(Param1);
            ParamArgs = new object[] { ((dynamic)Tuple1).Item1 };
          }

          if (Returntype.Contains("Void"))
          {
            if (Methodname.ToString() == "_SelectNodesByText")
            {
              SAP_API.MyGuiTree.SelectNodesByText(
                  SapMemberParam1_String.Get(context),
                  SapMemberParam2_String.Get(context),
                  SapMemberParam3_String.Get(context),
                  SapMemberParam4_String.Get(context),
                  SapMemberParam5_String.Get(context),
                  SapMemberParam6_String.Get(context));
            }
            else if (Methodname.ToString() == "_SetAbsoluteRow")
            {
              SAP_API.MyGuiTableControl.SetAbsoluteRow(
                  SapObject,
                  SapMemberParam1_Int32.Get(context),
                  SapMemberParam2_Boolean.Get(context));
            }
            else
            {
              // CallByName replacement using reflection
              try
              {
                SapObject.GetType().InvokeMember(
                    Methodname.ToString(),
                    BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                    null, SapObject, ParamArgs);
              }
              catch { }
            }
          }
          else
          {
            if (Methodname.ToString() == "_ReadOutGrid")
            {
              var Prop = SAP_API.MyGuiGridView.ReadGuiGridView();
              SapProperties.Set(context, Prop);
            }
            else if (Methodname.ToString() == "_GetAllToolbarButtons")
            {
              var Prop = SAP_API.MyGuiGridView.GetAllToolbarbuttons();
              SapProperties.Set(context, Prop);
            }
            else if (Methodname.ToString() == "_GetAllElementsFromGuiMainWindow")
            {
              var Prop = SAP_API.MyGuiMainWindow.Get_GuiMainWindow_SapElements();
              SapProperties.Set(context, Prop);
            }
            else
            {
              if (ParamArgs == null)
              {
                var Prop = SapObject.GetType().InvokeMember(
                    Methodname.ToString(),
                    BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                    null, SapObject, null);
                SapProperties.Set(context, Prop);
              }
              else
              {
                var Prop = SapObject.GetType().InvokeMember(
                    Methodname.ToString(),
                    BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Instance,
                    null, SapObject, ParamArgs);
                SapProperties.Set(context, Prop);
              }
            }
          }
        }
        else
        {
          switch (SapGuiType)
          {
            case SapGuiComponentType.GuiCTextField:
              if (EmptyField)
              {
                ((GuiCTextField)SapObject).Text = null;
              }
               ((GuiCTextField)SapObject).Text = StaticVariables.Value;
              break;
            case SapGuiComponentType.GuiTextField:
              if (EmptyField)
              {
                ((GuiTextField)SapObject).Text = null;
              }
              ((GuiTextField)SapObject).Text = StaticVariables.Value;
              break;
            case SapGuiComponentType.GuiButton:
              //Hotfix Sap GuiFreeze
              try
              {
                dynamic GuiOkField = Session.FindById("wnd[0]/tbar[0]/okcd");
                if (GuiOkField.Text.ToLower() == "/nex" || GuiOkField.Text.ToLower() == "ex")
                {
                  ClosedSession = true;
                }
              }
              catch { }
              finally
              {
                ((GuiButton)SapObject).Press();
              }
              break;
            case SapGuiComponentType.GuiTab:
              ((GuiTab)SapObject).Select();
              break;
            case SapGuiComponentType.GuiComboBox:
              if (EmptyField)
              {
                ((GuiComboBox)SapObject).Key = null;
              }
              ((GuiComboBox)SapObject).Key = StaticVariables.Value;
              break;
            case SapGuiComponentType.GuiCheckBox:
              bool Checked = ((GuiCheckBox)SapObject).Selected;
              if (EmptyField)
              {
                ((GuiCheckBox)SapObject).Selected = false;
              }
              if (Checked)
              {
                ((GuiCheckBox)SapObject).Selected = false;
              }
              else
              {
                ((GuiCheckBox)SapObject).Selected = true;
              }
              break;
            case SapGuiComponentType.GuiOkCodeField:
              if (EmptyField)
              {
                ((GuiOkCodeField)SapObject).Text = null;
              }
              ((GuiOkCodeField)SapObject).Text = StaticVariables.Value;
              break;
            case SapGuiComponentType.GuiPasswordField:
              if (EmptyField)
              {
                ((GuiPasswordField)SapObject).Text = null;
              }
              ((GuiPasswordField)SapObject).Text = StaticVariables.Value;
              break;
            case SapGuiComponentType.GuiRadioButton:
              ((GuiRadioButton)SapObject).Select();
              break;
            case SapGuiComponentType.GuiMenu:
              ((GuiMenu)SapObject).Select();
              break;
            default:
              break;
          }
        }

        if (PressEnter)
        {
          Session.ActiveWindow.SendVKey(0);
          Thread.Sleep(1000);

          //###### Hotfix für SAP GUI Freeze
          switch (SapGuiType)
          {
            case SapGuiComponentType.GuiOkCodeField:
              try
              {
                if (StaticVariables.Value.ToLower() == "/nex" || StaticVariables.Value.ToLower() == "ex")
                {
                  ClosedSession = true;
                }
              }
              catch { }
              try
              {
                if (ParamArgs != null && ParamArgs[0].ToString().ToLower() == "/nex" || ParamArgs[0].ToString().ToLower() == "ex")
                {
                  ClosedSession = true;
                }
              }
              catch { }
              break;
          }
        }

        //###### Hotfix für SAP GUI Freeze -
        if (ClosedSession)
        {
          SapError.Set(context, false);
        }
        else
        {
          SapError.Set(context, false);
          SapStatusbar.Set(context,
              "Type: " + ((GuiStatusbar)StaticVariables.session.FindById("wnd[0]/sbar")).MessageType +
              " Text: " + ((GuiStatusbar)StaticVariables.session.FindById("wnd[0]/sbar")).Text);
          SapGuiObject.Set(context, SapObject);
        }
      }
      catch (Exception ex_Findbytechnicalname_main)
      {
        SapError.Set(context, true);
        SapErrorNumber.Set(context, ex_Findbytechnicalname_main.HResult);
        SapErrorMessage.Set(context, ex_Findbytechnicalname_main.Message);
        SapGuiObject.Set(context, null);
        SapProperties.Set(context, null);
        SapStatusbar.Set(context, null);

        if (!ContinueOnError)
        {
          throw new Exception(ex_Findbytechnicalname_main.Message);
        }
      }
      finally
      {
        StaticVariables.ClearAll_StaticVariables();
      }
    }

    public Tuple<T1> Create1<T1>(T1 item1)
    {
      return new Tuple<T1>(item1);
    }

    public Tuple<T1, T2> Create2<T1, T2>(T1 item1, T2 item2)
    {
      return new Tuple<T1, T2>(item1, item2);
    }

    public Tuple<T1, T2, T3> Create3<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
    {
      return new Tuple<T1, T2, T3>(item1, item2, item3);
    }

    public Tuple<T1, T2, T3, T4> Create4<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
    {
      return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
    }

    public Tuple<T1, T2, T3, T4, T5> Create5<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
    {
      return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
    }

    public Tuple<T1, T2, T3, T4, T5, T6> Create6<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
    {
      return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
    }
  }
}
