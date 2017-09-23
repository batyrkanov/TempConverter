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

namespace TCui
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, RoutedEventArgs e)
        {
            // celsius to fahrenheit and kelvin
            if(txtb_fahrenheit.Text == "" && txtb_kelvin.Text == "")
            {
                var celsiumBox = double.Parse(txtb_celsium.Text);

                var client = new TCService.TCserviceClient("BasicHttpBinding_ITCservice");
                txtb_fahrenheit.Text = client.CelsiumToFahrenheit(celsiumBox).ToString();
                txtb_kelvin.Text = client.CelsiumToKelvin(celsiumBox).ToString();
                client.Close();
            }
            // fahrenheit to celsius and kelvin
            if (txtb_celsium.Text == "" && txtb_kelvin.Text == "")
            {
                var fahrenheitBox = double.Parse(txtb_fahrenheit.Text);

                var client = new TCService.TCserviceClient("BasicHttpBinding_ITCservice");
                txtb_celsium.Text = client.FahrenheitToCelsium(fahrenheitBox).ToString();
                txtb_kelvin.Text = client.FahrenheitToKelvin(fahrenheitBox).ToString();
                client.Close();
            }
            // kelvin to celsius and fahrenheit
            if (txtb_fahrenheit.Text == "" && txtb_celsium.Text == "")
            {
                var kelvinBox = double.Parse(txtb_kelvin.Text);

                var client = new TCService.TCserviceClient("BasicHttpBinding_ITCservice");
                txtb_fahrenheit.Text = client.KelvinToFahrenheit(kelvinBox).ToString();
                txtb_celsium.Text = client.KelvinToCelsium(kelvinBox).ToString();
                client.Close();
                
            }
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txtb_celsium.Text = String.Empty;
            txtb_fahrenheit.Text = String.Empty;
            txtb_kelvin.Text = String.Empty;
        }
    }
}
