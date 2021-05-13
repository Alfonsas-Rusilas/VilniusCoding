using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson19_WpfAppTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Debug.WriteLine("Pirmas debuginimas");
        }

        private void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Button clicked!");

            TestLabel.Content = "Changed Text!";
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"Button clicked! {e.GetPosition(this).X}, {e.GetPosition(this).Y}");
        }
    }
}
