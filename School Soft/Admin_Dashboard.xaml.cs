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

namespace School_Soft
{

   
   
    /// <summary>
    /// Interaction logic for Admin_Dashboard.xaml
    /// </summary>
    public partial class Admin_Dashboard : Window
    {
     
        public Admin_Dashboard()
        {
            InitializeComponent();
            MainWindow Login_sc = new MainWindow();
            Login_sc.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCourse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFees_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var Login_SC = new MainWindow();
            Login_SC.Closed += (s, args) => this.Close();
            Login_SC.Show();
        }
    }
}
