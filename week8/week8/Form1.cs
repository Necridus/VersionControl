using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week8.Abstractions;
using week8.Entities;

namespace week8
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();
        private IToyFactory _factory;
        private Toy _nextToy;
        public IToyFactory Factory
        {
            get { return _factory; }
            set 
            {
                _factory = value;
                DisplayNext();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            toy.Left = -toy.Width;
            _toys.Add(toy);
            mainPanel.Controls.Add(toy);
        }

        public void DisplayNext()
        {
            if (_nextToy != null)
            {
                Controls.Remove(_nextToy);
            }
            _nextToy = Factory.CreateNew();
            _nextToy.Top = nextLB.Top + nextLB.Height + 20;
        }
        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            int maxposition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left>maxposition)
                {
                    maxposition = toy.Left;
                }
            }
            if (maxposition>=1000)
            {
                var firsttoy = _toys[0];
                mainPanel.Controls.Remove(firsttoy);
                _toys.Remove(firsttoy);
            }
        }

        private void carFactoryBT_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void ballFactoryBT_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }
    }
}
