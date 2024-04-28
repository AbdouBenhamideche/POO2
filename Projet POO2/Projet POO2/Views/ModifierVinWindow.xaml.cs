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

namespace Projet_POO2.Views
{
    /// <summary>
    /// Logique d'interaction pour ModifierVinWindow.xaml
    /// </summary>
    public partial class ModifierVinWindow : Window
    {
        public ModifierVinWindow()
        {
            InitializeComponent();
            DataContext = new ViewModels.ModifierVinWindowViewModel(this);
        }

        private void OK(object sender, RoutedEventArgs e)
        {

        }
        private void Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
