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

namespace Firts_Fantasy
{
    /// <summary>
    /// Lógica de interacción para CargarPersonaje.xaml
    /// </summary>
    public partial class CargarPersonaje : Page
    {
        public CargarPersonaje()
        {
            InitializeComponent();
            updateCmb();
        }

        void updateCmb()
        {
            cmbPersonajes.Items.Clear();
            List<Character> jugadores = Caracteres.personajes;
            foreach (Character jugador in jugadores)
            {
                cmbPersonajes.Items.Add(jugador.Name + "-    -" + jugador.tipoClase());
            }
        }

        string mirarNombre()
        {
            string nombre = "";
            for (int i = 0; i < cmbPersonajes.Text.Length; i++)
            {
                if (cmbPersonajes.Text[i] == '-')
                {
                    break;
                }
                else
                {
                    nombre += cmbPersonajes.Text[i];
                }
            }
            return nombre;
        }

        private void btnLook_Click(object sender, RoutedEventArgs e)
        {
            string nombre = mirarNombre();
            lblNombre.Content = nombre;

            for (int i = 0; i < Caracteres.personajes.Count; i++)
            {
                if (nombre == Caracteres.personajes[i].Name)
                {
                    lblNombre.Content = Caracteres.personajes[i].Name;
                    lblClase.Content = Caracteres.personajes[i].tipoClase();
                    string ubicacion = Caracteres.armas[i].RutaAcc();
                    imgArma.Source = new BitmapImage(new Uri(ubicacion, UriKind.Relative));
                    string ubicacion2 = Caracteres.personajes[i].Armadura[0];
                    imgArmadura.Source = new BitmapImage(new Uri(ubicacion2, UriKind.Relative));
                    string ubicacion3 = Caracteres.personajes[i].Inventory[0];
                    imgObj1.Source = new BitmapImage(new Uri(ubicacion3, UriKind.Relative));
                    string ubicacion4 = Caracteres.personajes[i].Inventory[1];
                    imgObj2.Source = new BitmapImage(new Uri(ubicacion4, UriKind.Relative));
                    string ubicacion5 = Caracteres.personajes[i].Inventory[2];
                    imgObj3.Source = new BitmapImage(new Uri(ubicacion5, UriKind.Relative));
                }
            }
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            Caracteres.nombre=mirarNombre();
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new ModificarPersonaje());
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new Batalla());
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string nombre = mirarNombre();

            for(int i = 0; i < Caracteres.personajes.Count; i++)
            {
                if(nombre == Caracteres.personajes[i].Name)
                {
                    Caracteres.personajes.RemoveAt(i);
                    break;
                }
            }
            updateCmb();
            lblClase.Content="";
            lblNombre.Content = "";
            btnLoad.IsEnabled = false;
            btnLook.IsEnabled = false;
            btnModify.IsEnabled = false;
            btnDelete.IsEnabled = false;
            imgArma.Source = null;
            imgArmadura.Source = null;
            imgObj1.Source = null;
            imgObj2.Source = null;
            imgObj3.Source = null;
        }

        private void cmbPersonajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbPersonajes.Text == "")
            {
                btnLoad.IsEnabled = true;
                btnLook.IsEnabled = true;
                btnModify.IsEnabled = true;
                btnDelete.IsEnabled = true;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new CargarCrearPer());
        }

        private int listaI()
        {
            string nombre = mirarNombre();
            lblNombre.Content = nombre;
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


        private void imgArma_MouseEnter(object sender, MouseEventArgs e)
        {
            DatosRct.Visibility = Visibility.Visible;
            DatosArma.Visibility = Visibility.Visible;
            DatosName.Content = Caracteres.armas[listaI()].Nombre(); 
            DatosDaño.Content = Caracteres.armas[listaI()].Daño();
            DatosName.Visibility = Visibility.Visible;
            DatosDaño.Visibility = Visibility.Visible;
        }

        private void imgArma_MouseLeave(object sender, MouseEventArgs e)
        {
            DatosRct.Visibility = Visibility.Hidden;
            DatosArma.Visibility = Visibility.Hidden;
            DatosName.Visibility = Visibility.Hidden;
            DatosDaño.Visibility = Visibility.Hidden;
        }

        private void imgArmadura_MouseEnter(object sender, MouseEventArgs e)
        {
            Datos2Rct.Visibility = Visibility.Visible;
            Datos2Name.Content = Caracteres.personajes[listaI()].Armadura[1];
            Datos2Name.Visibility = Visibility.Visible;
            DatosArmadura.Visibility = Visibility.Visible;
        }

        private void imgArmadura_MouseLeave(object sender, MouseEventArgs e)
        {
            Datos2Rct.Visibility = Visibility.Hidden;
            Datos2Name.Visibility = Visibility.Hidden;
            DatosArmadura.Visibility = Visibility.Hidden;
        }

        private void imgObj1_MouseEnter(object sender, MouseEventArgs e)
        {
            Datos3Rct.Visibility = Visibility.Visible;
            Datos3Name.Content = Caracteres.personajes[listaI()].Inventory[3];
            Datos3Name.Visibility = Visibility.Visible;
            DatosObj1.Visibility = Visibility.Visible;
        }

        private void imgObj1_MouseLeave(object sender, MouseEventArgs e)
        {
            Datos3Rct.Visibility = Visibility.Hidden;
            Datos3Name.Visibility = Visibility.Hidden;
            DatosObj1.Visibility = Visibility.Hidden;
        }

        private void imgObj2_MouseEnter(object sender, MouseEventArgs e)
        {
            Datos4Rct.Visibility = Visibility.Visible;
            Datos4Name.Content = Caracteres.personajes[listaI()].Inventory[4];
            Datos4Name.Visibility = Visibility.Visible;
            DatosObj2.Visibility = Visibility.Visible;
        }

        private void imgObj2_MouseLeave(object sender, MouseEventArgs e)
        {
            Datos4Rct.Visibility = Visibility.Hidden;
            Datos4Name.Visibility = Visibility.Hidden;
            DatosObj2.Visibility = Visibility.Hidden;
        }

        private void imgObj3_MouseEnter(object sender, MouseEventArgs e)
        {
            Datos5Rct.Visibility = Visibility.Visible;
            Datos5Name.Content = Caracteres.personajes[listaI()].Inventory[5];
            Datos5Name.Visibility = Visibility.Visible;
            DatosObj3.Visibility = Visibility.Visible;
        }

        private void imgObj3_MouseLeave(object sender, MouseEventArgs e)
        {
            Datos5Rct.Visibility = Visibility.Hidden;
            Datos5Name.Visibility = Visibility.Hidden;
            DatosObj3.Visibility = Visibility.Hidden;
        }
    }
}
