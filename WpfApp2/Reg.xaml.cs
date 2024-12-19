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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
            //Btn_Vhod.Visibility = Visibility.Hidden;
        }

        private void Btn_Vhod_Click(object sender, RoutedEventArgs e)
        {

            string managerLogin = "manager";
            string managerPassword = "manager";

            string enteredLogin = textbox1.Text;
            string enteredPassword = textbox2.Password;

            if (enteredLogin == managerLogin && enteredPassword == managerPassword)
            {
                Manager.MainFrame.Navigate(new Vbor());
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void Btn_Tour_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MatPage());
        }
    }
}
