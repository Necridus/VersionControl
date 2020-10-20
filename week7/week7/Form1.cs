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
using week7.Entities;

namespace week7
{
    public partial class Form1 : Form
    {
        #region Variables
        List<Person> Population = new List<Person>();
        List<BirthProbability> birthProbabilities = new List<BirthProbability>();
        List<DeathProbability> deathProbabilities = new List<DeathProbability>();
        List<int> NumberOfMales = new List<int>();
        List<int> NumberOfFemales = new List<int>();
        Random rnd = new Random(1234);
        string popfile = "";
        int startyear = 2005;
        int endyear;
        #endregion

        public Form1()
        {
            InitializeComponent();
            endyearL.Text = Resource1.Zaroev;
            propL.Text = Resource1.Nepessegfajl;
            fileTB.Text = popfile;
            browseBT.Text = Resource1.Browse;
            startBT.Text = Resource1.Start;
        }
        private void Simulation()
        {
            NumberOfMales.Clear();
            NumberOfFemales.Clear();
            resultsRTB.Clear();
            endyear = int.Parse(endyearNUD.Value.ToString());
            for (int year = startyear; year <= endyear; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    Person person = Population[i];
                    SimStep(year, person);
                }
                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                NumberOfMales.Add(nbrOfMales);
                NumberOfFemales.Add(nbrOfFemales);
            }
        }

        private void DisplayResults(int year, List<int> NumberOfMales, List<int> NumberOfFemales)
        {
            string newline = Environment.NewLine;
            for (int i = 0; i < NumberOfFemales.Count(); i++)
            {
                resultsRTB.AppendText(String.Format("{1}Szimulációs év: {0}{1}\tFérfiak: {2}{1}\tNők: {3}{1}", year + i, newline, NumberOfMales[i], NumberOfFemales[i]));
            }

        }

        public void SimStep(int year, Person person)
        {
            if (!person.IsAlive)
            {
                return;
            }
            int age = year - person.BirthYear;
            double deathprop = (from x in deathProbabilities
                                where x.Gender == person.Gender && x.Age == age
                                select x.Probability).FirstOrDefault();
            if (rnd.NextDouble() < deathprop) person.IsAlive = false;
            if (person.IsAlive && person.Gender == Gender.Female)
            {
                double birthprop = (from x in birthProbabilities
                                    where x.Age == age
                                    select x.Probability).FirstOrDefault();
                if (rnd.NextDouble() < birthprop)
                {
                    Person newborn = new Person();
                    newborn.BirthYear = year;
                    newborn.Gender = (Gender)(rnd.Next(1, 3));
                    newborn.NbrOfChildren = 0;
                    newborn.IsAlive = true;
                    Population.Add(newborn);
                }
            }
        }

        public List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> deathProbabilities = new List<DeathProbability>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    deathProbabilities.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        Probability = double.Parse(line[2])
                    });
                }
            }
            return deathProbabilities;
        }

        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> birthProbabilities = new List<BirthProbability>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    birthProbabilities.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        Probability = double.Parse(line[2])
                    });
                }
            }
            return birthProbabilities;
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();
            if (csvpath != "")
            {
                using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine().Split(';');
                        population.Add(new Person()
                        {
                            BirthYear = int.Parse(line[0]),
                            Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                            NbrOfChildren = int.Parse(line[2])
                        });
                    }
                }
                return population;
            }
            else
            {
                return null;
            }
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            Simulation();
            DisplayResults(startyear, NumberOfMales, NumberOfFemales);
        }

        private void browseBT_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    popfile = ofd.FileName;
                    fileTB.Text = popfile;
                    Population = GetPopulation(popfile);
                    birthProbabilities = GetBirthProbabilities(@"C:\Temp\születés.csv");
                    deathProbabilities = GetDeathProbabilities(@"C:\Temp\halál.csv");
                }
            }
        }
    }
}
