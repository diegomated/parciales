using System;
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
using Firts_Fantasy.Classes.armas;

namespace Firts_Fantasy
{
    /// <summary>
    /// Lógica de interacción para Batalla.xaml
    /// </summary>
    public partial class Batalla : Page
    {
        public Batalla()
        {
            InitializeComponent();

            Boss.vida = 200;
            Character.vida = 200;

            string nombre = Caracteres.nombre;

            string ubicacionboss = "/Images/midir.png";

            imgBoss.Source = new BitmapImage(new Uri(ubicacionboss, UriKind.Relative));

            for (int i = 0; i < Caracteres.personajes.Count; i++)
            {
                if (nombre == Caracteres.personajes[i].Name)
                {
                    lblName.Content = Caracteres.personajes[i].Name;
                    lblClase.Content = Caracteres.personajes[i].tipoClase();
                    string ubicacion1 = Caracteres.armas[i].RutaAcc();
                    imgArma.Source = new BitmapImage(new Uri(ubicacion1, UriKind.Relative));
                    string ubicacion2 = Caracteres.personajes[i].Armadura[0];
                    imgArmadura.Source = new BitmapImage(new Uri(ubicacion2, UriKind.Relative));
                    string ubicacion3 = Caracteres.personajes[i].Inventory[0];
                    imgObj1.Source = new BitmapImage(new Uri(ubicacion3, UriKind.Relative));
                    string ubicacion4 = Caracteres.personajes[i].Inventory[1];
                    imgObj2.Source = new BitmapImage(new Uri(ubicacion4, UriKind.Relative));
                    string ubicacion5 = Caracteres.personajes[i].Inventory[2];
                    imgObj3.Source = new BitmapImage(new Uri(ubicacion5, UriKind.Relative));
                    break;
                }
            }

        }

        private int listaI()
        {
            string nombre = lblName.Content.ToString();

            int numero = 0;

            for (int i = 0; i < Caracteres.personajes.Count; i++)
            {
                if (nombre == Caracteres.personajes[i].Name)
                {
                    numero = i;
                }
            }
            return numero;
        }



        private void btnAtacar_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int dañoTotal = random.Next(0, 8) + Caracteres.armas[listaI()].Daño();
            int siono = 0;

            MessageBox.Show("El boss recibio " + dañoTotal.ToString() + " de daño");
            Boss.vida = Boss.vida - dañoTotal;

            if (recVidBoss.Width - dañoTotal <= 0)
            {
                MessageBox.Show("Ganaste, has derrotado al boss");
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.mainFrame.NavigationService.Navigate(new CargarCrearPer());
                siono = 1;
            }
            else
            {
                int vidaWidth = (179 * dañoTotal) / 200;
                recVidBoss.Width = recVidBoss.Width - vidaWidth;
            }
            if (Boss.vida <= 50)
            {
                recVidBoss.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }else if (Boss.vida <= 90)
            {
                recVidBoss.Fill = new SolidColorBrush(Color.FromRgb(255, 188, 0));
            }else if (Boss.vida <= 130)
            {
                recVidBoss.Fill = new SolidColorBrush(Color.FromRgb(235, 255, 0));
            }else if (Boss.vida <= 170)
            {
                recVidBoss.Fill = new SolidColorBrush(Color.FromRgb(128, 255, 0));
            }
            
            if (siono == 0)
            {
                int sino = random.Next(0, 2);
                MessageBox.Show("El boss te ataca");
                if (sino == 0)
                {
                    MessageBox.Show("Evadiste el ataque del Boss");
                }
                else
                {
                    int dañoTotalBoss = random.Next(0, 13) + 40;
                    int vidaWidthP = (254 * dañoTotalBoss) / 200;
                    Character.vida = Character.vida - dañoTotalBoss;
                    MessageBox.Show("Has recibio " + dañoTotalBoss.ToString() + " de daño");

                    if (recVidPly.Width - vidaWidthP <= 0)
                    {
                        MessageBox.Show("Perdiste, El boss te derroto");
                        siono = 1;
                        MainWindow w = (MainWindow)Window.GetWindow(this);
                        w.mainFrame.NavigationService.Navigate(new CargarCrearPer());
                    }
                    else
                    {
                        recVidPly.Width = recVidPly.Width - vidaWidthP;
                    }

                    if (Character.vida <= 50)
                    {
                        recVidPly.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    }
                    else if (Character.vida <= 90)
                    {
                        recVidPly.Fill = new SolidColorBrush(Color.FromRgb(255, 188, 0));
                    }
                    else if (Character.vida <= 130)
                    {
                        recVidPly.Fill = new SolidColorBrush(Color.FromRgb(235, 255, 0));
                    }
                    else if (Character.vida <= 170)
                    {
                        recVidPly.Fill = new SolidColorBrush(Color.FromRgb(128, 255, 0));
                    }
                }
            }
        }
    }
}
