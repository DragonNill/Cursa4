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

namespace PcSborka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для OrderCreate.xaml
    /// </summary>
    public partial class OrderCreate : Window
    {
        public OrderCreate()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Window backWindow = new MainWindow();
            backWindow.Show();
            Close();
        }

        private void ChooseComputer_button_Click(object sender, RoutedEventArgs e)
        {
            Window chooseComputerWindow = new ChooseWindow();
            chooseComputerWindow.Show();
            Close();
        }
    }
}
