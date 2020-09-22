using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            listBoxFullName.DataSource = users;
            listBoxFullName.ValueMember = "ID";
            listBoxFullName.DisplayMember = "FullName";
            labelLastName.Text = Resource.LastName;
            labelFirstName.Text = Resource.FirstName;
            buttonAdd.Text = Resource.Add;
            buttonAdd.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User newuser = new User();
            newuser.LastName = textBoxLastName.Text;
            newuser.FirstName = textBoxFirstName.Text;
            users.Add(newuser);
        }
    }
}
