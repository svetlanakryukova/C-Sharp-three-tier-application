using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinForm_MyBike
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username, pass;
           

            username = this.textBox_userName.Text;
            pass = this.textBox_Password.Text;
            
            if (username=="admin" && pass=="12345")
            {
                Form1 myBikesForm = new Form1();

                myBikesForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid Username and Password");
            }
            
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
