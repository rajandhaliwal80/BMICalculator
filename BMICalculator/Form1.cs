using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Rajandeep Kaur Dhaliwal
/// Assignment 5- BMI Calculator
/// BMI Calculator
/// </summary>

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Metric_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnits.Text = "m";
            WightUnits.Text = "kgs";
        }

        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnits.Text = "inches";
            WightUnits.Text = "pounds";
        }
        /// <summary>
        /// this is the event handler for the form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
