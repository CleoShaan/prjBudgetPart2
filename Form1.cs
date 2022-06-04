using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        VehicleDetails<string> vd;

        public object cbmOption { get; private set; }

        public Form1()
        {
            InitializeComponent();
            vd = new VehicleDetails<string>();


        }



        private void cbmOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleDetails.areaSelected = cbmOption.ToString();

            lblOption.Text = cbmSelect.Text;

        }

        private void btnSelectOpt_Click(object sender, EventArgs e)
        {
            cbmSelect.Items.Add("Renting");
            cbmSelect.Items.Add("Buying a Property");
            cbmSelect.Items.Add("Buy a Vehicle");


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Display all the Information That has been Captured:\n\n" + "Display");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit:");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reset all Information ");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clear");
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            object strModelAndMake = this.Text;
            object strPurchasePrice = this.Text;
            object strTotalDeposit = this.Text;
            object strInterestRate = this.Text;
            object strEstimatedInsurancePremium = this.Text;

            vd.Push(strModelAndMake, strPurchasePrice, strTotalDeposit, strInterestRate, strEstimatedInsurancePremium);
            setTotal(strPurchasePrice, strTotalDeposit, strInterestRate, strEstimatedInsurancePremium);
            MessageBox.Show("Data Captured");


        }

        private void setTotal(object strPurchasePrice, object strTotalDeposit, object strInterestRate, object strEstimatedInsurancePremium)
        {
            MessageBox.Show("The total PurchasePrice amount is R:");
            MessageBox.Show("The total TotalDeposit amount is R:");
            MessageBox.Show("The total InterestRate is:");
            MessageBox.Show("The total EstimatedInsurancePremium is R:");
            
        }

        private class VehicleDetails
        {
            public static string areaSelected { get; internal set; }
        }
    }
}

