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

namespace OOD_Project
{
   
    public partial class MainWindow : Window
    {
        public List<User> users = new List<User>();
        public List<Game> games = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Owner = this;
            logIn.ShowDialog();
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Owner = this;
            createAccount.ShowDialog();
        }
    }
}
