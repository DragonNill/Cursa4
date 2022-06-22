using PcSborka.Views.UserControls;
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
using static PcSborka.Classes.SessionData;

namespace PcSborka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChooseWindow.xaml
    /// </summary>
    public partial class ChooseWindow : Window
    {
        int CPUID, MotherBoardID, CaseID, GPUID, CoolerID, RAMID, PowerSupplyID;

        private void ChooseMotherBoard_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(2);
            nextWindow.Show();
            Close();
        }

        private void ChooseCPU_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(1);
            nextWindow.Show();
            Close();            
        }

        public ChooseWindow()
        {
            InitializeComponent();

        }

        public ChooseWindow(int i)
        {
            InitializeComponent();
            CPU_listView.Items.Add(new CurrentItemControl(ComputerReady.CPUID,1));

        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Window backWindow = new OrderCreate();
            backWindow.Show();
            Close();
        }
    }
}
