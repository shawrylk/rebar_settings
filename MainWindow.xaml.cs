using System.Windows.Controls ;
using System.Windows.Controls.Primitives ;
using System.Windows.Media ;
using System.Windows.Shapes ;

namespace rebar_settings
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow
  {
    public MainWindow()
    {
      InitializeComponent() ;
    }

    void OnDragDelta( object sender, DragDeltaEventArgs e )
    {
      if ( sender is not Thumb thumb ) return ;
      var thumbX = Canvas.GetLeft( thumb ) + e.HorizontalChange ;
      var thumbY = Canvas.GetTop( thumb ) + e.VerticalChange ;
      var line1 = new Line()
      {
        X1 = 0,
        X2 = thumbX,
        Y1 = 0,
        Y2 = 0,
        Stroke = Brushes.Black
      } ;
      var line2 = new Line()
      {
        X1 = thumbX,
        X2 = thumbX,
        Y1 = 0,
        Y2 = 100,
        Stroke = Brushes.Black
      } ;
      DrawingCanvas.Children.Clear() ;
      DrawingCanvas.Children.Add( thumb ) ;
      DrawingCanvas.Children.Add( line1 ) ;
      DrawingCanvas.Children.Add( line2 ) ;
      Canvas.SetLeft( thumb, thumbX ) ;
      Canvas.SetTop( thumb, thumbY ) ;
      // Canvas.SetLeft( line1, thumbX ) ;
      // Canvas.SetTop( line1, thumbY ) ;
      // Canvas.SetLeft( line2, thumbX ) ;
      // Canvas.SetTop( line2, thumbY ) ;
    }
  }
}