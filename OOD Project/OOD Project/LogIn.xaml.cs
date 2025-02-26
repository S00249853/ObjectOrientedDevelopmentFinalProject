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

namespace OOD_Project
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public User currentUser;
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
           

            MainWindow main = this.Owner as MainWindow;
             foreach(User user in main.users)
            {
                if (tbxName.Text == user.userName && tbxPassword.Text == user.password)
                {
                    currentUser = user;
                    Account account = new Account();
                    account.Owner = this;
                    account.ShowDialog();
                    Close();
                    this.Owner.Close();
                }
            }
        }
    }
}
