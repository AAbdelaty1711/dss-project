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
    public partial class Maximax : Form
    {
        public Maximax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Parse the user input
            string[] scenarios = textBox1.Text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int[][] outcomes = new int[scenarios.Length][];

            for (int i = 0; i < scenarios.Length; i++)
            {
                string[] values = scenarios[i].Split(',');
                int[] payoffs = new int[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    int payoff;
                    if (int.TryParse(values[j], out payoff))
                    {
                        payoffs[j] = payoff;
                    }
                    else
                    {
                        MessageBox.Show("Invalid input: " + values[j]);
                        return;
                    }
                }

                outcomes[i] = payoffs;
            }

            // Step 2: Calculate the maximax decision
            int[] bestOutcomes = new int[outcomes.Length];
            for (int i = 0; i < outcomes.Length; i++)
            {
                bestOutcomes[i] = outcomes[i].Max();
            }

            int[] maxPayoffs = new int[outcomes.Length];
            for (int i = 0; i < outcomes.Length; i++)
            {
                maxPayoffs[i] = bestOutcomes[i];
            }

            int maxPayoff = maxPayoffs.Max();
            for (int i = 0; i < maxPayoffs.Length; i++)
            {
                if (maxPayoffs[i] == maxPayoff)
                {
                    MessageBox.Show("Choose decision " + (i + 1));  // i + 1 represents the decision number
                }
            }
        }
    }
}
