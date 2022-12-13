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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppHub_v._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //lineTest.X2 = (stPage.Width - catLabel.Width);
            lineTest.X2 = stPage.Width-25;
        }

        private void TopbarDrag_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnTopBarMenuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnTopBarMenuMini_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        bool isRotated = false;
        private void test_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (!isRotated) RotateBtn(btn, -90);
            else RotateBtn(btn, 0);
        }

        public void RotateBtn(Button btn, int angle)
        {
            isRotated = !isRotated;
            btn.RenderTransform = new RotateTransform(angle, 12.5, 12.5);
        }
    }
}
