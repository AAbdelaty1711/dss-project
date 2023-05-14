using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dss_project
{
    public partial class MinimaxRegret : Form
    {
        public MinimaxRegret()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            // Create an array of textboxes
            var textBoxes1 = new[] { textBox1, textBox2, textBox3 };
            var textBoxes2 = new[] { textBox4, textBox5, textBox6 };
            var textBoxes3 = new[] { textBox7, textBox8, textBox9 };

            // The first TextBoxes
            var values1 = new List<double>();
            foreach (var textBox in textBoxes1)
            {
                double value;
                if (double.TryParse(textBox.Text, out value))
                {
                    values1.Add(value);
                }
            }

            double max1 = values1.Count > 0 ? values1.Max() : 0;
            textBox1.Text = Convert.ToString(max1 - Convert.ToInt32(textBox1.Text));
            textBox2.Text = Convert.ToString(max1 - Convert.ToInt32(textBox2.Text));
            textBox3.Text = Convert.ToString(max1 - Convert.ToInt32(textBox3.Text));

            // The secound TextBoxes
            var values2 = new List<double>();
            foreach (var textBox in textBoxes2)
            {
                double value;
                if (double.TryParse(textBox.Text, out value))
                {
                    values2.Add(value);
                }
            }

            double max2 = values2.Count > 0 ? values2.Max() : 0;
            textBox4.Text = Convert.ToString(max2 - Convert.ToInt32(textBox4.Text));
            textBox5.Text = Convert.ToString(max2 - Convert.ToInt32(textBox5.Text));
            textBox6.Text = Convert.ToString(max2 - Convert.ToInt32(textBox6.Text));


            // The third TextBoxes
            var values3 = new List<double>();
            foreach (var textBox in textBoxes3)
            {
                double value;
                if (double.TryParse(textBox.Text, out value))
                {
                    values3.Add(value);
                }
            }

            double max3 = values3.Count > 0 ? values3.Max() : 0;
            textBox7.Text = Convert.ToString(max3 - Convert.ToInt32(textBox7.Text));
            textBox8.Text = Convert.ToString(max3 - Convert.ToInt32(textBox8.Text));
            textBox9.Text = Convert.ToString(max3 - Convert.ToInt32(textBox9.Text));

            // the highest value in regret table in every row

            var rowtextBoxes1 = new[] { textBox1, textBox4, textBox7 };

            var rowvalues1 = new List<double>();

            foreach (var textBox in rowtextBoxes1)
            {
                double rowvalue;
                if (double.TryParse(textBox.Text, out rowvalue))
                {
                    rowvalues1.Add(rowvalue);
                }
            }

            double rowmax1 = rowvalues1.Count > 0 ? rowvalues1.Max() : 0;

            label1.Text = Convert.ToString(rowmax1);

            var rowtextBoxes2 = new[] { textBox2, textBox5, textBox8 };
            var rowvalues2 = new List<double>();

            foreach (var textBox in rowtextBoxes2)
            {
                double rowvalue2;
                if (double.TryParse(textBox.Text, out rowvalue2))
                {
                    rowvalues2.Add(rowvalue2);
                }
            }

            double rowmax2 = rowvalues2.Count > 0 ? rowvalues2.Max() : 0;

            label2.Text = Convert.ToString(rowmax2);

            var rowtextBoxes3 = new[] { textBox3, textBox6, textBox9 };
            var rowvalues3 = new List<double>();

            foreach (var textBox in rowtextBoxes3)
            {
                double rowvalue;
                if (double.TryParse(textBox.Text, out rowvalue))
                {
                    rowvalues3.Add(rowvalue);
                }
            }

            double rowmax3 = rowvalues3.Count > 0 ? rowvalues3.Max() : 0;

            label3.Text = Convert.ToString(rowmax3);

            // the lowest value in highest value in row 

            var rowlabels = new[] { label1, label2, label3 };
            var rowlabelvalues = new List<double>();

            foreach (var label in rowlabels)
            {
                double rowvalue;
                if (double.TryParse(label.Text, out rowvalue))
                {
                    rowlabelvalues.Add(rowvalue);
                }
            }
            double rowlabelmax = rowlabelvalues.Count > 0 ? rowlabelvalues.Min() : 0;

            if (rowlabelmax == Convert.ToInt32(textBox1.Text) || rowlabelmax == Convert.ToInt32(textBox4.Text) || rowlabelmax == Convert.ToInt32(textBox7.Text))
            {
                MessageBox.Show($"The Best number is {rowlabelmax} Form {label5.Text}");

            }
            if (rowlabelmax == Convert.ToInt32(textBox2.Text) || rowlabelmax == Convert.ToInt32(textBox5.Text) || rowlabelmax == Convert.ToInt32(textBox8.Text))
            {
                MessageBox.Show($"The Best number is {rowlabelmax} Form {label6.Text}");

            }
            if (rowlabelmax == Convert.ToInt32(textBox3.Text) || rowlabelmax == Convert.ToInt32(textBox6.Text) || rowlabelmax == Convert.ToInt32(textBox9.Text))
            {
                MessageBox.Show($"The Best number is {rowlabelmax} Form {label7.Text}");

            }
        
        }
    }
}
