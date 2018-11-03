﻿using System;
using System.ComponentModel;
using System.Windows;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using RoutedEventArgs = Windows.UI.Xaml.RoutedEventArgs;

namespace WindowsCommunityToolkit.Wpf
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

        private void InkToolbarViewButton_ChildChanged(object sender, EventArgs e)
        {
            if (!(sender is WindowsXamlHost windowsXamlHost)) return;
            if (!(windowsXamlHost.Child is Windows.UI.Xaml.Controls.Button button)) return;

            button.Content =  "InkToolbar Preview";
            button.Click   += InkToolbarViewButton_OnClick;
        }

        private void InkToolbarViewButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void InkCanvasViewButton_OnChildChanged(object sender, EventArgs e)
        {
            if (!(sender is WindowsXamlHost windowsXamlHost)) return;
            if (!(windowsXamlHost.Child is Windows.UI.Xaml.Controls.Button button)) return;

            button.Content =  "InkCanvas Preview";
            button.Click   += InkCanvasViewButton_OnClick;
        }

        private void InkCanvasViewButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MediaPlayerElementViewButton_OnChildChanged(object sender, EventArgs e)
        {
            if (!(sender is WindowsXamlHost windowsXamlHost)) return;
            if (!(windowsXamlHost.Child is Windows.UI.Xaml.Controls.Button button)) return;

            button.Content =  "MediaPlayerElement Preview";
            button.Click   += MediaPlayerElementViewButton_OnClick;
        }

        private void MediaPlayerElementViewButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MapControlViewButton_OnChildChanged(object sender, EventArgs e)
        {
            if (!(sender is WindowsXamlHost windowsXamlHost)) return;
            if (!(windowsXamlHost.Child is Windows.UI.Xaml.Controls.Button button)) return;

            button.Content =  "MapControl Preview";
            button.Click   += MapControlViewButton_OnClick;
        }

        private void MapControlViewButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            InkToolbarViewButton.ChildChanged         -= InkToolbarViewButton_ChildChanged;
            InkCanvasViewButton.ChildChanged          -= InkCanvasViewButton_OnChildChanged;
            MediaPlayerElementViewButton.ChildChanged -= MediaPlayerElementViewButton_OnChildChanged;
            MapControlViewButton.ChildChanged         -= MapControlViewButton_OnChildChanged;
        }
    }
}