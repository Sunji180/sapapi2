using System;
using System.Activities;
using System.Security;
using System.Runtime.InteropServices;

namespace SAP_API
{
  public static class HelperClass
  {
    public static int ConvertToInteger(ref string value)
    {
      if (string.IsNullOrEmpty(value))
      {
        value = "0";
      }
      return Convert.ToInt32(value);
    }

    public static string ToUnsecureString(SecureString source)
    {
      IntPtr returnValue = IntPtr.Zero;
      try
      {
        returnValue = Marshal.SecureStringToGlobalAllocUnicode(source);
        return Marshal.PtrToStringUni(returnValue);
      }
      finally
      {
        Marshal.ZeroFreeGlobalAllocUnicode(returnValue);
      }
    }

    public static Tuple<T1> Create1<T1>(T1 item1)
    {
      return new Tuple<T1>(item1);
    }

    public static Tuple<T1, T2> Create2<T1, T2>(T1 item1, T2 item2)
    {
      return new Tuple<T1, T2>(item1, item2);
    }

    public static Tuple<T1, T2, T3> Create3<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
    {
      return new Tuple<T1, T2, T3>(item1, item2, item3);
    }

    public static Tuple<T1, T2, T3, T4> Create4<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
    {
      return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
    }

    public static Tuple<T1, T2, T3, T4, T5> Create5<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
    {
      return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
    }

    public static Tuple<T1, T2, T3, T4, T5, T6> Create6<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
    {
      return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
    }
  }
}
