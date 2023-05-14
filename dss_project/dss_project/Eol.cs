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
    public partial class Eol : Form
    {
        public Eol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;


            double A = Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox4.Text);
            double C = Convert.ToDouble(textBox12.Text) * Convert.ToDouble(textBox7.Text);
            double reso = A + B + C;
            label1.Text = Convert.ToString(reso);




            double A2 = Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox2.Text);
            double B2 = Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox5.Text);
            double C2 = Convert.ToDouble(textBox12.Text) * Convert.ToDouble(textBox8.Text);
            double reso2 = A2 + B2 + C2;
            label2.Text = Convert.ToString(reso2);




            double A3 = Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox3.Text);
            double B3 = Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox6.Text);
            double C3 = Convert.ToDouble(textBox12.Text) * Convert.ToDouble(textBox9.Text);
            double reso3 = A3 + B3 + C3;
            label3.Text = Convert.ToString(reso3);





            var rowL = new[] { label1, label2, label3 };
            var rowLV = new List<double>();

            foreach (var label in rowL)
            {
                double rowvalue;
                if (double.TryParse(label.Text, out rowvalue))
                {
                    rowLV.Add(rowvalue);
                }
            }
            double rowLmin = rowLV.Count > 0 ? rowLV.Min() : 0;

            MessageBox.Show($"The Best Solution Is: {rowLmin}");

        }
    }
}
