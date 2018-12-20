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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace square_relocate_button_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_left_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(square, Canvas.GetLeft(square) - 10);
        }

        private void Button_right_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(square, Canvas.GetLeft(square) + 10);
        }
    }
}
