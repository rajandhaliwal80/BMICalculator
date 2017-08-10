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
/// Rajandeep Kaur Dhaliwal - 300926123
/// Splash Form
/// </summary>
namespace BMICalculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is the event handler for the "tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BMICalculator calculatorForm = new BMICalculator();
            calculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;//turn timer off
        }
    }
}
