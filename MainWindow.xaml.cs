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

namespace WPFDashboard
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

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridTitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }

    internal class ConsumptionViewModel
    {
        public List<Consumption> Consumptions { get; private set; }

        public ConsumptionViewModel(Consumption consumption)
        {
            Consumptions = new List<Consumption>();
            Consumptions.Add(consumption);
        }
    }

    internal class Consumption
    {
        public string Title { get; private set; }
        public int Percentage { get; private set; }

        public Consumption()
        {
            Title = "Current Consumption";
            Percentage = CalculatePercentage();
        }

        private int CalculatePercentage()
        {
            return 47;
        }
    }
}