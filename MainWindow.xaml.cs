using Infragistics.Windows.DataPresenter;
using System.Windows;

namespace KB14652_XamDataGrid_ClearFilter;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void ClearFilters_Click(object sender, RoutedEventArgs e)
    {
        // XamDataGrid のフィルターをクリア
        foreach (FieldLayout? fieldLayout in xamDataGrid1.FieldLayouts)
        {
            fieldLayout.RecordFilters.Clear();
        }
    }
}
