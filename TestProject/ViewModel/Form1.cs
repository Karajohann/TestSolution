using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLogic;

namespace ViewModel
{
    public partial class Form1 : Form
    {

        public int sum(int a, int b)
        {
            return a + b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Authedicator.Check(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Authentication completed");
            }
            else
            {
                MessageBox.Show("Failed");
            }

            
        }
    }
}
