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
        public string appName { get; set; }
        public string appPath { get; set; }
        public string imgPath { get; set; }

        public AppShortcut()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void openApp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
