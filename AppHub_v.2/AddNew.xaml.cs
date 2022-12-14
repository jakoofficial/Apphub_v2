﻿using System;
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

namespace AppHub_v._2
{
    /// <summary>
    /// Interaction logic for AddNew.xaml
    /// </summary>
    public partial class AddNew : Window
    {
        MainWindow mw;
        public AddNew()
        {
            InitializeComponent();
            mw = (MainWindow)Window.GetWindow(App.Current.MainWindow);
        }
        private void TopbarDrag_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnTopBarMenuClose_Click(object sender, RoutedEventArgs e)
        {
            mw.newWinOverlay.Visibility = Visibility.Collapsed;
            mw.newWinOverlay.IsHitTestVisible = false;
            this.Close();
        }

        private void btnTopBarAddNewMenuMini_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
