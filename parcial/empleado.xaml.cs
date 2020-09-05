using System;
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

namespace parcial
{
    /// <summary>
    /// Lógica de interacción para empleado.xaml
    /// </summary>
    public partial class empleado : Page
    {
        public empleado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            string cedula = txtCedula.Text.ToString();
            string cantidadPanA = txtCantidadA.Text;
            string cantidadPanNA = txtCantidadNA.Text;
            string cantidadPanE = txtCantidadE.Text;
            DateTime hoy = DateTime.Now;
            string hora = hoy.ToShortTimeString();

            if(nombre=="" || cedula=="" || cantidadPanA=="" || cantidadPanNA=="" || cantidadPanE == "")
            {
                MessageBox.Show("Debes llenar todas las casillas");
            }
            else
            {
                txtPedido.Text = hora + "\n" + cedula + " - " + nombre + "\n" + cantidadPanA + "-Alineado" + "\n" + cantidadPanNA + "-No Alineado" + "\n" + cantidadPanE + "-Especial";
            }
            
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            txtPedido.Text = "";
        }

        private void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            string contenido = lblcontenidoT.Content.ToString();
            txtPedidos.Text = contenido + txtPedido.Text;
            lblcontenidoT.Content = txtPedidos.Text + "\n-----------------\n";
            txtPedido.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtCantidadA.Text = "";
            txtCantidadNA.Text = "";
            txtCantidadE.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new login());
        }
    }
}
