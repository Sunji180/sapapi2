using System;
using System.Runtime.InteropServices;

namespace SAP_API
{
  public class MyGuiScrollbar
  {
    public interface ISapScrollbarTarget
    {
      [DispId(33900)]
      int Range { get; set; }

      [DispId(33902)]
      int Position { get; set; }

      [DispId(33903)]
      int PageSize { get; }

      [DispId(33904)]
      int Maximum { get; }

      [DispId(33905)]
      int Minimum { get; }
    }
  }
}
