using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using week6.Entities;
using week6.MnbServiceReference;

namespace week6
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();
        string result;
        public Form1()
        {
            InitializeComponent();
            GetCurrencyList();
            RefreshData();
        }

        private void GetCurrencyList()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            var resultC = response.GetCurrenciesResult;
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(resultC);
            foreach (XmlElement element in xml.DocumentElement)
            {
                int hossz = element.InnerText.Length;
                for (int i = 0; i < hossz / 3; i++)
                {
                    var childElement = (XmlElement)element.ChildNodes[i];
                    var akarmi = childElement.InnerText;
                    akarmi.ToString();
                    Currencies.Add(akarmi);
                }
            }
            currencyCB.DataSource = Currencies;
        }

        private void RefreshData()
        {
            Rates.Clear();
            ratesDGW.DataSource = Rates;
            chartRateData.DataSource = Rates;
            CallWebService();
            ProcessXML();
            ShowData();
        }

        private void CallWebService()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = currencyCB.SelectedItem.ToString(),
                startDate = startDateDP.Value.ToString(),
                endDate = endDateDP.Value.ToString()
            };
            var response = mnbService.GetExchangeRates(request);
            result = response.GetExchangeRatesResult;
        }

        private void ProcessXML()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement element in xml.DocumentElement)
            {
                RateData rateData = new RateData();
                Rates.Add(rateData);
                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rateData.Date = DateTime.Parse(element.GetAttribute("date"));
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                {
                    rateData.Value = value / unit;
                }
            }
        }

        private void ShowData()
        {
            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;
            var legend = chartRateData.Legends[0];
            legend.Enabled = false;
            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void startDateDP_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void endDateDP_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void currencyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}

