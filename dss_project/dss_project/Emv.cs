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
    public partial class Emv : Form
    {
        public Emv()
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

            // Step 2: Calculate the EMV decision
            double[] expectedPayoffs = new double[outcomes.Length];
            for (int i = 0; i < outcomes.Length; i++)
            {
                double probability = 1.0 / outcomes.Length; // equal probability assumption
                double expectedPayoff = 0;
                for (int j = 0; j < outcomes[i].Length; j++)
                {
                    expectedPayoff += outcomes[i][j] * probability;
                }
                expectedPayoffs[i] = expectedPayoff;
            }

            int maxExpectedPayoffIndex = Array.IndexOf(expectedPayoffs, expectedPayoffs.Max());
            MessageBox.Show("Choose decision " + (maxExpectedPayoffIndex + 1)); // maxExpectedPayoffIndex + 1 represents the decision number
    }
    }
}
