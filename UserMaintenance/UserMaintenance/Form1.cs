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
            labelFullName.Text = Resource.FullName;
            buttonAdd.Text = Resource.Add;
            buttonDelete.Text = Resource.Delete;
            buttonWriteInFile.Text = Resource.Write;
            buttonAdd.Click += Button1_Click;
            buttonWriteInFile.Click += ButtonWriteInFile_Click;
            buttonDelete.Click += ButtonDelete_Click;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var del = (UserMaintenance.Entities.User)(listBoxFullName.SelectedItem);
            users.Remove(del);
        }

        private void ButtonWriteInFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var us in users)
                {
                    sw.Write(us.FullName);
                    sw.Write(";");
                    sw.Write(us.ID);
                    sw.Write(";");
                    sw.WriteLine();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User newuser = new User();
            newuser.FullName = textBoxFullName.Text;
            users.Add(newuser);
        }
    }
}
