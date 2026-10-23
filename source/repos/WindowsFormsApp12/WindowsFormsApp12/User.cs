using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp12.DataContext.Models;
using WindowsFormsApp12.DataContext;

namespace WindowsFormsApp12
{
    public partial class User : Form
    {
        string name;
        string price;
        string weight;
        string data_release;

        public User(Role role)
        {
            InitializeComponent();
            User Twoform = new User(role);
            if (role == Role.Admin)
            {

            }
            if (role == Role.User)
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
            this.gameTableAdapter.Fill(this.database1DataSet1.Game);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            price = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            weight = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            data_release = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datacontext.addGame(name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datacontext.EditGame(name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datacontext.DeleteGame(Name);
        } 
    }
}
