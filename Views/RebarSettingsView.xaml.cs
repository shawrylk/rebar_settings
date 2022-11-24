using System.Windows ;
using rebar_settings.ViewModels ;

namespace rebar_settings.Views ;

public partial class RebarSettingsWindowView : Window
{
  public RebarSettingsWindowView()
  {
    InitializeComponent() ;
    DataContext = new RebarSettingsViewModel() ;
  }
}