using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace ConverterCurrency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    class Currency
    {
        public decimal AUD { get; set; }
        public decimal ConvertToAUD(decimal currencyRUB) => currencyRUB / AUD;

        public decimal AZN { get; set; }
        public decimal ConvertToAZN(decimal currencyRUB) => currencyRUB / AZN;

        public decimal GBP { get; set; }
        public decimal ConvertToGBP(decimal currencyRUB) => currencyRUB / GBP;

        public decimal USD { get; set; }
        public decimal ConvertToUSD(decimal currencyRUB) => currencyRUB / USD;

        public decimal EUR { get; set; }
        public decimal ConvertToEUR(decimal currencyRUB) => currencyRUB / EUR;

        public decimal CNY { get; set; }
        public decimal ConvertToCNY(decimal currencyRUB) => currencyRUB / (CNY / 10);

        public decimal HKD { get; set; }
        public decimal ConvertToHKD(decimal currencyRUB) => currencyRUB / (HKD / 10);

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            decimal currencyRub = 1;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU"); // <== нужная вам культура

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            try
            {
                XDocument xml = XDocument.Load("http://www.cbr.ru/scripts/XML_daily.asp");

                Currency currency = new Currency();

                int index = cmbCurrency.SelectedIndex;

                switch (index)
                {
                    case 0:
                        currency.AUD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "036").Elements("Value").FirstOrDefault().Value);

                        txtbResult.Text = "1 - Австралийский доллар = " + currency.USD + Decimal.Round(currency.ConvertToAUD(currencyRub), 2)
                        + " руб\n";

                        break;

                    case 1:
                        currency.AZN = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "944").Elements("Value").FirstOrDefault().Value);
                        txtbResult.Text = "1 - Азербайджанский манат = " + currency.AZN + Decimal.Round(currency.ConvertToAZN(currencyRub), 2)
                        + " руб\n";
                        break;
                    case 2:
                        currency.GBP = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "826").Elements("Value").FirstOrDefault().Value);

                        txtbResult.Text = "1 - Фунт стерлингов Соединенного королевства = " + currency.GBP + Decimal.Round(currency.ConvertToGBP(currencyRub), 2)
                        + " руб\n";

                        break;
                    case 3:
                        currency.USD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "840").Elements("Value").FirstOrDefault().Value);

                        txtbResult.Text = "1 - Доллар США = " + currency.USD + Decimal.Round(currency.ConvertToUSD(currencyRub), 2)
                        + " руб\n"; break;
                    case 4:
                        currency.EUR = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "978").Elements("Value").FirstOrDefault().Value);

                        txtbResult.Text = "1 - Евро = " + currency.EUR + Decimal.Round(currency.ConvertToEUR(currencyRub), 2)
                        + " руб\n";

                        break;
                    case 5:
                        currency.CNY = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "156").Elements("Value").FirstOrDefault().Value);

                        txtbResult.Text = "10 Китайских юаней = " + currency.CNY + Decimal.Round(currency.ConvertToCNY(currencyRub), 2)
                        + " руб\n";

                        break;
                    case 6:
                        currency.HKD = Convert.ToDecimal(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "344").Elements("Value").FirstOrDefault().Value);

                        txtbResult.Text = "10 Гонконгских долларов = " + currency.HKD + Decimal.Round(currency.ConvertToHKD(currencyRub), 2)
                        + " руб\n";

                        break;

                    default:
                        MessageBox.Show("Валюта не выбрана!");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
