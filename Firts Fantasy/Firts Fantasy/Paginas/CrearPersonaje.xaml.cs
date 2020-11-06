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
    /// Lógica de interacción para CrearPersonaje.xaml
    /// </summary>
    public partial class CrearPersonaje : Page
    {

        public CrearPersonaje()
        {
            InitializeComponent();
        }

        public void SaveCharacter()
        {

            List<string> inventario = new List<string>();
            List<string> armaduras = new List<string>();

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

            inventario.Add(casoObj(cmdObj1));
            inventario.Add(casoObj(cmdObj2));
            inventario.Add(casoObj(cmdObj3));
            inventario.Add(cmdObj1.Text);
            inventario.Add(cmdObj2.Text);
            inventario.Add(cmdObj3.Text);

            string clase = cmbClase.Text;
            string arma = cmbArma.Text;
            string obj1 = cmdObj1.Text;
            string obj2 = cmdObj2.Text;
            string obj3 = cmdObj3.Text;

            switch (arma)
            {
                case "Gran Guadana":
                    GranGuadana guadana = new GranGuadana();
                    Caracteres.armas.Add(guadana);
                    break;
                case "Gran Hacha":
                    GranHacha hacha = new GranHacha();
                    Caracteres.armas.Add(hacha);
                    break;
                case "Zweihander":
                    Zweihander zweihander = new Zweihander();
                    Caracteres.armas.Add(zweihander);
                    break;
                default:
                    break;
            }

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

            armaduras.Add(armadura(cmdArmadura));
            armaduras.Add(cmdArmadura.Text);

            switch (clase)
            {
                case "Clerigo":
                    Clerigo cleric = new Clerigo();
                    cleric.Name = txtName.Text;
                    cleric.Inventory = inventario;
                    cleric.Armadura = armaduras;
                    Caracteres.personajes.Add(cleric);
                    break;
                case "Guerrero":
                    Guerrero warrior = new Guerrero();
                    warrior.Name = txtName.Text;
                    warrior.Inventory = inventario;
                    warrior.Armadura = armaduras;
                    Caracteres.personajes.Add(warrior);
                    break;
                case "Hechicero":
                    Hechicero wizard = new Hechicero();
                    wizard.Name = txtName.Text;
                    wizard.Inventory = inventario;
                    wizard.Armadura = armaduras;
                    Caracteres.personajes.Add(wizard);
                    break;
                case "Heraldo":
                    Heraldo herald = new Heraldo();
                    herald.Name = txtName.Text;
                    herald.Inventory = inventario;
                    herald.Armadura = armaduras;
                    Caracteres.personajes.Add(herald);
                    break;
                case "Piromantico":
                    Piromantico pyromantic = new Piromantico();
                    pyromantic.Name = txtName.Text;
                    pyromantic.Inventory = inventario;
                    pyromantic.Armadura = armaduras;
                    Caracteres.personajes.Add(pyromantic);
                    break;
                default:
                    break;
            }
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            SaveCharacter();
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
