﻿using Run.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace Run.Views
{
    /// <summary>
    /// Interaction logic for ConfigWindow.xaml
    /// </summary>
    public partial class ConfigWindow : Window
    {
        public ConfigViewModel ViewModel { get; private set; } = new ConfigViewModel();

        public ConfigWindow()
        {
            InitializeComponent();

            DataContext = ViewModel;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            IsEnabled = true;
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
