﻿using System;
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
        /// <summary>
        /// This event changes the units to metric units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Metric_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnits.Text = "m";
            WightUnits.Text = "kgs";
        }
        /// <summary>
        /// this event changes the units to imperial units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void BMIResults_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This event displays the BMI result and the scale after calculations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Click(object sender, EventArgs e)
        {
            if(Imperial.Checked == true)
            {
                double height = double.Parse(HeightText.Text);
                double Weight = double.Parse(WeightText.Text);
                double BMI;
                BMI = (Weight * 703) / (height * height);
                BMIResults.Text = BMI.ToString();
                if(BMI<=18.5)
                {
                    result.Text = "Underweight";
                }
                else if (BMI>18.5 && BMI<=24.9)
                {
                    result.Text = "Normal";
                }
                else if(BMI>25 && BMI<=29.9)
                {
                    result.Text = "Overweight";
                }
                else if(BMI>=30)
                {
                    result.Text = "Obese";
                }
            }
            if (Metric.Checked == true)
            {
                double height = double.Parse(HeightText.Text);
                double Weight = double.Parse(WeightText.Text);
                double BMI;
                BMI = (Weight) / (height * height);
                BMIResults.Text = BMI.ToString();
                if (BMI <= 18.5)
                {
                    result.Text = "Underweight";
                }
                else if (BMI > 18.5 && BMI <= 24.9)
                {
                    result.Text = "Normal";
                }
                else if (BMI > 25 && BMI <= 29.9)
                {
                    result.Text = "Overweight";
                }
                else if (BMI >= 30)
                {
                    result.Text = "Obese";
                }
            }
        }

        private void HeightText_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this events modifies height textbox to accept only numbers and backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputHeight = e.KeyChar;
            if(!char.IsDigit(inputHeight)&& inputHeight!=8 && inputHeight != 46)
            {
                e.Handled = true;
            }
        }

        private void WeightText_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This event modifies the weight textbox to only accept numbers and backspace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputWeight = e.KeyChar;
            if (!char.IsDigit(inputWeight) && inputWeight != 8 && inputWeight != 46)
            {
                e.Handled = true;
            }
        }
    }
}
