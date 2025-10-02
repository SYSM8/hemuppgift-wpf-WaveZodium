using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate;

/// <summary>
/// Interaction logic for GridWindow.xaml
/// </summary>
public partial class GridWindow : Window {
    public GridWindow() {
        InitializeComponent();
    }

    private void AddButton_Click(object sender, RoutedEventArgs e) {
        Button newButton = new Button {
            Content = $"Row {SelectedRow.Text}, Column {SelectedColumn.Text}",
            Background = Brushes.LightGreen
        };

        // Set grid position
        Grid.SetRow(newButton, int.Parse(SelectedRow.Text));
        Grid.SetColumn(newButton, int.Parse(SelectedColumn.Text));

        // Add to grid (replace 'YourGridName' with the actual grid's name)
        MyGrid.Children.Add(newButton);
    }
}
