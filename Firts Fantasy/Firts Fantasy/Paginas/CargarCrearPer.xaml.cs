﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Firts_Fantasy.Classes;

namespace Firts_Fantasy
{
    /// <summary>
    /// Lógica de interacción para CargarCrearPer.xaml
    /// </summary>
    public partial class CargarCrearPer : Page
    {
        public CargarCrearPer()
        {
            InitializeComponent();

            if (Caracteres.personajes.Count == 0)
            {
                Load.IsEnabled = false;
            }
            else
            {
                Load.IsEnabled = true;
            }
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new CargarPersonaje());
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new CrearPersonaje());
        }
    }
}
