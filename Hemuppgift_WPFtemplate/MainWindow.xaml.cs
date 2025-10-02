using System.Windows;

namespace Hemuppgift_WPFtemplate;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    //HEJ
    //Hej hej :)
    public MainWindow() {
        InitializeComponent();
    }

    private void btnGrid_Click(object sender, RoutedEventArgs e) {
        GridWindow gridWindow = new GridWindow();
        gridWindow.Show();
    }

    private void btnStackPanel_Click(object sender, RoutedEventArgs e) {
        StackPanelWindow stackPanelWindow = new StackPanelWindow();
        stackPanelWindow.Show();
    }

    private void btnWrapPanel_Click(object sender, RoutedEventArgs e) {
        WrapPanelWindow wrapPanelWindow = new WrapPanelWindow();
        wrapPanelWindow.Show();
    }

    private void btnDockPanel_Click(object sender, RoutedEventArgs e) {
        DockPanelWindow dockPanelWindow = new DockPanelWindow();
        dockPanelWindow.Show();
    }
}