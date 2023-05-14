using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dss_project
{
    public partial class Equally : Form
    {
        public Equally()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox4.Text);
            double num3 = double.Parse(textBox7.Text);
            double average1 = (num1 + num2 + num3) / 3;

            label1.Text = average1.ToString();
            double num4 = double.Parse(textBox2.Text);
            double num5 = double.Parse(textBox5.Text);
            double num6 = double.Parse(textBox8.Text);
            double average2 = (num4 + num5 + num6) / 3;
            label2.Text = average2.ToString();

            double num7 = double.Parse(textBox3.Text);
            double num8 = double.Parse(textBox6.Text);
            double num9 = double.Parse(textBox9.Text);
            double average3 = (num7 + num8 + num9) / 3;
            label3.Text = average3.ToString();

            double maxNumber = Math.Max(average1, Math.Max(average2, average3));

            MessageBox.Show("best solution is " + maxNumber.ToString());

        }
    }
}
