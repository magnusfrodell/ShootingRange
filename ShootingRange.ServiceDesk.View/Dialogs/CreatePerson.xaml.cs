﻿using System;
using System.Windows;
using Gui.ViewModel;

namespace ShootingRange.ServiceDesk.View.Dialogs
{
    /// <summary>
    /// Interaction logic for CreatePerson.xaml
    /// </summary>
    public partial class CreatePerson : Window, IWindow
    {
        public CreatePerson()
        {
            InitializeComponent();
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            IconHelper.RemoveIcon(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
