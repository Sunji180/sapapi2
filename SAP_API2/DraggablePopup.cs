using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace SAP_API
{
  public class DraggablePopup : Popup
  {
    private Point _initialMousePosition;
    private bool _isDragging;

    protected override void OnInitialized(EventArgs e)
    {
      base.OnInitialized(e);
      // Try to get the Child as a FrameworkElement
      FrameworkElement contents = Child as FrameworkElement;
      // Optionally uncomment the Debug.Assert below if you want to enforce a non-null content
      // System.Diagnostics.Debug.Assert(contents != null, "DraggablePopup must have a content that derives from FrameworkElement.");

      if (contents != null)
      {
        contents.MouseLeftButtonDown += Child_MouseLeftButtonDown;
        contents.MouseLeftButtonUp += Child_MouseLeftButtonUp;
        contents.MouseMove += Child_MouseMove;
      }
    }

    private void Child_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      FrameworkElement element = sender as FrameworkElement;
      if (element != null)
      {
        _initialMousePosition = e.GetPosition(null);
        element.CaptureMouse();
        _isDragging = true;
        e.Handled = true;
      }
    }

    private void Child_MouseMove(object sender, MouseEventArgs e)
    {
      if (_isDragging)
      {
        Point currentPoint = e.GetPosition(null);
        HorizontalOffset = HorizontalOffset + (currentPoint.X - _initialMousePosition.X);
        VerticalOffset = VerticalOffset + (currentPoint.Y - _initialMousePosition.Y);
      }
    }

    private void Child_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
    {
      if (_isDragging)
      {
        FrameworkElement element = sender as FrameworkElement;
        if (element != null)
        {
          element.ReleaseMouseCapture();
        }
        _isDragging = false;
        e.Handled = true;
      }
    }
  }
}
