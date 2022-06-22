using PcSborka.Classes;
using PcSborka.Entity;
using PcSborka.Views.UserControls;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static PcSborka.Classes.SessionData;

namespace PcSborka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChooseCurrentItemShow.xaml
    /// </summary>
    public partial class ChooseCurrentItemShow : Window
    {
        CreatePcForThePeopl_dbEntities DbContext;
        public CPU CPUID { get; set; }
        public MotherBoard MotherBoardID { get; set; }
        public Case CaseID { get; set; }
        public GPU GPUID { get; set; }
        public Cooler CoolerID { get; set; }
        public RAM RAMID { get; set; }
        public PowerSupply PowerSupplyID { get; set; }
        public int CurrentItem;

        public ChooseCurrentItemShow(int currentItem)
        {
            InitializeComponent();

            CurrentItem = currentItem;
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            CheckItem(currentItem);
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Window backWindow = new ChooseWindow();
            backWindow.Show();
            Close();
        }

        private void CheckItem(int currentItem)
        {
            switch (currentItem)
            {
                case 1:
                    this.Title = "Выбор процессора";

                    CurrentItem_listView.Items.Clear();

                    List<CPU> cpuList = new List<CPU>();
                    cpuList = DbContext.CPU.ToList();

                    if (!string.IsNullOrWhiteSpace(Find_textBox.Text.ToLower()))
                    {
                        cpuList = cpuList.Where(x => x.Name.ToLower().Contains(Find_textBox.Text.ToLower())).ToList();
                    }


                    foreach (CPU cpu in cpuList)
                    {
                        CurrentItem_listView.Items.Add(new CurrentItemControl(cpu, currentItem));
                    }
                    break;
                case 2:
                    this.Title = "Выбор процессора";

                    CurrentItem_listView.Items.Clear();

                    List<MotherBoard> motherBoards  = new List<MotherBoard>();
                    motherBoards = DbContext.MotherBoard.ToList();

                    if (!string.IsNullOrWhiteSpace(Find_textBox.Text.ToLower()))
                    {
                        motherBoards = motherBoards.Where(x => x.Name.ToLower().Contains(Find_textBox.Text.ToLower())).ToList();
                    }


                    foreach(MotherBoard motherBoard in motherBoards)
                    {
                        CurrentItem_listView.Items.Add(new CurrentItemControl(motherBoard, currentItem));
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
        }

        private void Find_textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckItem(CurrentItem);
        }

        private void CurrentItem_listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            switch (CurrentItem)
            {
                case 1:
                    CPU cpu = ((CurrentItemControl)CurrentItem_listView.SelectedItem).CPUID;
                    new ProductInfoWindow(cpu,CurrentItem).ShowDialog();
                    DbContext = CreatePcForThePeopl_dbEntities.DBContext;
                    CheckItem(CurrentItem);
                    break;
                case 2:
                    MotherBoard motherBoard = ((CurrentItemControl)CurrentItem_listView.SelectedItem).MotherBoardID;
                    new ProductInfoWindow(motherBoard, CurrentItem).ShowDialog();
                    DbContext = CreatePcForThePeopl_dbEntities.DBContext;
                    CheckItem(CurrentItem);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
        }

        private void CurrentItem_listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if(CurrentItem_listView.SelectedIndex !=-1)
            {
                AddToChoose_button.Visibility = Visibility.Visible;
            }
        }

        private void AddToChoose_button_Click(object sender, RoutedEventArgs e)
        {
            switch (CurrentItem)
            {
                case 1:
                    ComputerReady.CPUID = ((CurrentItemControl)CurrentItem_listView.SelectedItem).CPUID;
                    MessageBox.Show(ComputerReady.CPUID.ToString());
                    Window readyWindow = new ChooseWindow(1);
                    readyWindow.Show();
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
        }

    }
}
