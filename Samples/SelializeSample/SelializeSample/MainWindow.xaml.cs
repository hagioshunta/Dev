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

namespace SelializeSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BinaryFormatterButton_Click(object sender, RoutedEventArgs e)
        {
            var w = new Views.BinaryFormatterView()
            {
                DataContext = new ViewModels.BinaryFormatterViewModel(),
                Owner = this,
            };
            w.ShowDialog();
        }

        private void XmlSerializerButton_Click(object sender, RoutedEventArgs e)
        {
            var w = new Views.XmlSerializerView()
            {
                DataContext = new ViewModels.XmlSerializerViewModel(),
                Owner = this,
            };
            w.ShowDialog();
        }

    }
}
