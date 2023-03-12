using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            const double BASE_RATE = 200;
            const double HOUR_RATE = 150;
            const double MILE_RATE = 2;
            double inputHours;
            double inputMiles;
            double calculatedEstimate;

            Double.TryParse(txtInHours.Text, out inputHours);
            Double.TryParse(txtInMiles.Text, out inputMiles);

            calculatedEstimate = BASE_RATE + (inputHours * HOUR_RATE) + (inputMiles * MILE_RATE);

            txtOutput.Text = calculatedEstimate.ToString();
        }
    }
}
