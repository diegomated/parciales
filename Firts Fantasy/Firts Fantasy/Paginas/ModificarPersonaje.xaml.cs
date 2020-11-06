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
    /// Lógica de interacción para ModificarPersonaje.xaml
    /// </summary>
    public partial class ModificarPersonaje : Page
    {
        public ModificarPersonaje()
        {
            InitializeComponent();

            string nombre = Caracteres.nombre;

            for (int i = 0; i < Caracteres.personajes.Count; i++)
            {
                if (nombre == Caracteres.personajes[i].Name)
                {
                    lblName.Content = Caracteres.personajes[i].Name;
                    lblClase.Content = Caracteres.personajes[i].tipoClase();
                    break;
                }
            }
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            string nombre = lblName.Content.ToString();

            string casoObj(ComboBox textbox)
            {
                string option = textbox.Text;
                switch (option)
                {
                    case "Estus":
                        return "/Images/Estus.png";
                    case "Estus Ceniza":
                        return "/Images/Estus-Ceniza.png";
                    case "Resina Carbon":
                        return "/Images/Resina-Carbon.png";
                    case "Resina Dorada":
                        return "/Images/Resina-Dorada.png";
                    default:
                        return "";
                }
            }

            List<string> inventario = new List<string>();
            inventario.Add(casoObj(cmbObj1));
            inventario.Add(casoObj(cmbObj2));
            inventario.Add(casoObj(cmbObj3));
            inventario.Add(cmbObj1.Text);
            inventario.Add(cmbObj2.Text);
            inventario.Add(cmbObj3.Text);

            for (int i = 0; i < Caracteres.personajes.Count; i++)
            {
                if (nombre == Caracteres.personajes[i].Name)
                {
                    Caracteres.personajes[i].Name = nombre;
                    Caracteres.personajes[i].Inventory = inventario;

                    List<string> armaduras = new List<string>();

                    string armadura(ComboBox texto)
                    {
                        switch (texto.Text)
                        {
                            case "Arm Muertos":
                                return "/Images/Amr-muertos.png";
                            case "Arm Bailarina":
                                return "/Images/Arm-bailarina.png";
                            case "Arm Faraam":
                                return "/Images/Arm-faraam.png";
                            default:
                                return "";
                        }
                    }
                    armaduras.Add(armadura(cmbArmadur));
                    armaduras.Add(cmbArmadur.Text);

                    Caracteres.personajes[i].Armadura = armaduras;


                    string arma = cmbArma.Text;

                    switch (arma)
                    {
                        case "Gran Guadana":
                            GranGuadana guadana = new GranGuadana();
                            Caracteres.armas[i]=(guadana);
                            break;
                        case "Gran Hacha":
                            GranHacha hacha = new GranHacha();
                            Caracteres.armas[i]=(hacha);
                            break;
                        case "Zweihander":
                            Zweihander zweihander = new Zweihander();
                            Caracteres.armas[i]=(zweihander);
                            break;
                        default:
                            break;
                    }

                    break;
                }
            }
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new CargarPersonaje());
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new CargarCrearPer());
        }
    }
}
