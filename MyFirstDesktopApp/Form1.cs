using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation();
            calculation.Number1 = Convert.ToInt32(textBox1.Text);
            calculation.Number2 = Convert.ToInt32(textBox2.Text);
            textBox3.Text = calculation.Result.ToString();

        }
    }
}
