using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week5.Entities;

namespace week5
{
    public partial class Form1 : Form
    {
        PortfolioEntities context = new PortfolioEntities();
        List<Tick> ticks;
        List<PortfolioItem> Portfolio = new List<PortfolioItem>();
        List<decimal> nyeresegekRendezve = new List<decimal>();
        public Form1()
        {
            InitializeComponent();

            ticks = context.Ticks.ToList();
            dataGridView1.DataSource = ticks;
            CreatePortfolio();
            nyeresegekRendezve = Nyeresegek();
            MessageBox.Show(nyeresegekRendezve[nyeresegekRendezve.Count() / 5].ToString());
        }

        private List<decimal> Nyeresegek()
        {
            List<decimal> Nyeresegek = new List<decimal>();
            int intervalum = 30;
            DateTime kezdoDatum = (from x in ticks select x.TradingDay).Min();
            DateTime zaroDatum = new DateTime(2016, 12, 30);
            TimeSpan z = zaroDatum - kezdoDatum;
            for (int i = 0; i < z.Days - intervalum; i++)
            {
                decimal ny = GetPortfolioValue(kezdoDatum.AddDays(i + intervalum)) - GetPortfolioValue(kezdoDatum.AddDays(i));
                Nyeresegek.Add(ny);
                Console.WriteLine(i + " " + ny);
            }

            var nyeresegekRendezve = (from x in Nyeresegek
                                      orderby x
                                      select x).ToList();
            return nyeresegekRendezve;
        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });
            dataGridView2.DataSource = Portfolio;
        }

        private decimal GetPortfolioValue(DateTime date)
        {
            decimal value = 0;
            foreach (var item in Portfolio)
            {
                var last = (from x in ticks
                            where item.Index == x.Index.Trim() && date <= x.TradingDay
                            select x).First();
                value += (decimal)last.Price * item.Volume;
            }
            return value;
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write("Időszak");
                sw.Write(";");
                sw.Write("Nyereség");
                sw.Write(";");
                sw.WriteLine();
                int i = 1;
                foreach (var nyr in nyeresegekRendezve)
                {
                    sw.Write(i);
                    sw.Write(";");
                    sw.Write(nyr.ToString());
                    sw.Write(";");
                    sw.WriteLine();
                    i++;
                }
            }
        }
    }
}
