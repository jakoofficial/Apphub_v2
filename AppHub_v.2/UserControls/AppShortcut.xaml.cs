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

namespace AppHub_v._2.UserControls
{
    /// <summary>
    /// Interaction logic for AppShortcut.xaml
    /// </summary>
    public partial class AppShortcut : UserControl
    {
        public AppShortcut()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Test");
        }
    }
}
