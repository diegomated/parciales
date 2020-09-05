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
    /// Lógica de interacción para login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, RoutedEventArgs e)
        {
            if (txtUser.Text == "diego" || txtUser.Text == "esteban")
            {
                if (txtUser.Text == "diego" && pswContra.Password == "123")
                {
                    MainWindow w = (MainWindow)Window.GetWindow(this);
                    w.mainFrame.NavigationService.Navigate(new admin());
                }
                if (txtUser.Text == "esteban" && pswContra.Password == "321")
                {
                    MainWindow w2 = (MainWindow)Window.GetWindow(this);
                    w2.mainFrame.NavigationService.Navigate(new empleado());
                }   
            }
            else
            {
                MessageBox.Show("Username o Contraseña incorrecta");
            }
            
        }
    }
}
