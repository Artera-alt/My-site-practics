using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Login : Form
    {
        string login;
        string password;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            login = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           DataContext.Datacontext.AuthorizationUser(login, password);
        }
    }
}
