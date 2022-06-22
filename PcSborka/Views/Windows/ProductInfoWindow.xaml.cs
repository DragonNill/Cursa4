using PcSborka.Entity;
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
    /// Логика взаимодействия для ProductInfoWindow.xaml
    /// </summary>
    public partial class ProductInfoWindow : Window
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

        #region Constructs
        public ProductInfoWindow(CPU cpu, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            CPUID = cpu;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(MotherBoard motherBoard, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            MotherBoardID = motherBoard;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(Case @case, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            CaseID = @case;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(GPU gPU, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            GPUID = gPU;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(Cooler cooler, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            CoolerID = cooler;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(RAM rAM, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            RAMID = rAM;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(PowerSupply powerSupply, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            PowerSupplyID = powerSupply;
            CurrentItem = currentItem;
        }
        #endregion

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CheckItem(CurrentItem);
        }

        private void CheckItem(int currentItem)
        {
            switch (currentItem)
            {
                case 1:
                    Title_textBox.Text = CPUID.Name;
                    Cost_textBox.Text = $"Цена: {CPUID.Cost} руб.";
                    Charastericts_textBox.Text = CPUID.Сharacteristics;
                    Socket_textBox.Text = $"Сокет: {CPUID.Socket}";
                    Socket_textBox.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Title_textBox.Text = MotherBoardID.Name;
                    Cost_textBox.Text = $"Цена: {MotherBoardID.Cost} руб.";
                    Charastericts_textBox.Text = MotherBoardID.Сharacteristics;
                    Socket_textBox.Text = $"Сокет: {MotherBoardID.Socket}";
                    Socket_textBox.Visibility = Visibility.Visible;
                    TypeMemory_textBox.Visibility = Visibility.Visible;
                    TypeMemory_textBox.Text = $"Тип памяти:{MotherBoardID.TypeMotherBoardMemory}";
                    Form_Factor_textBox.Visibility = Visibility.Visible;
                    Form_Factor_textBox.Text = $"Форм-фактор {MotherBoardID.Form_Factor}";
                    break;
                case 3:
                    Title_textBox.Text = CaseID.Name;
                    Cost_textBox.Text = $"Цена: {CaseID.Cost} руб.";
                    break;
                case 4:
                    Title_textBox.Text = GPUID.Name;
                    Cost_textBox.Text = $"Цена: {GPUID.Cost} руб.";
                    break;
                case 5:
                    Title_textBox.Text = CoolerID.Name;
                    Cost_textBox.Text = $"Цена: {CoolerID.Cost} руб.";
                    break;
                case 6:
                    Title_textBox.Text = RAMID.Name;
                    Cost_textBox.Text = $"Цена: {RAMID.Cost} руб.";
                    break;
                case 7:
                    Title_textBox.Text = PowerSupplyID.Name;
                    Cost_textBox.Text = $"Цена: {PowerSupplyID.Cost} руб.";
                    break;
                case 8:
                    //Title_textBox.Text = ;
                    //Cost_textBox.Text =;
                    break;
                case 9:
                    //Title_textBox.Text =;
                    //Cost_textBox.Text =;
                    break;
                case 10:
                    //Title_textBox.Text =;
                    //Cost_textBox.Text =;
                    break;
            }
        }
    }
}
