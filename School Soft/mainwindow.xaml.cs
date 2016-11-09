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

namespace School_Soft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbxUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbxUser.Text == String.Empty && tbxPassword.Text == String.Empty)
            {
                btnLogin.IsEnabled = true;
            }
            else btnLogin.IsEnabled = false;


        }

        private void tbxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
           // if (tbxPassword.Text == String.Empty)
         //   {
         //       btnLogin.IsEnabled = false;
         //   }

         //   else
          //  {
             //   btnLogin.IsEnabled = true;
          //  }
        }
    }
}
