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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Vbor.xaml
    /// </summary>
    public partial class Vbor : Page
    {
        public Vbor()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MatPage()); 
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AppPage());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
