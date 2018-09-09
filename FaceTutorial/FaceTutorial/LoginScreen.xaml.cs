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
using System.Windows.Shapes;

namespace FaceTutorial
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        const String Username = "name";
        const String Password = "test";
        public LoginScreen()
        {
            InitializeComponent();
        }

        void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == Username && txtPassword.Password == Password)
            {
                MainWindow console = new MainWindow();
                console.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Credentials are Incorrect!");
            }
        }
    }
}
