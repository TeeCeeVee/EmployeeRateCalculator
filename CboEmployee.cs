using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboEmployeeApp
{
    public partial class CboEmployee : Form
    {
        public CboEmployee()
        {
            InitializeComponent();
        }


        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            TxtHours.Text = VsbHours.Value.ToString();  
        }

        private void CboEmployee_Load_1(object sender, EventArgs e)
        {
            //Name and Rate are automatically generated on the main form

            CboName.Items.Add("Bob Smit");
            CboName.Items.Add("Linda Bo");
            CboName.Items.Add("Mindy Stern");
            CboName.Items.Add("Linda Dawn"); 

            for (double i = 10.50; i < 20; i+= .50)
            {
                CboRate.Items.Add(i);
            }
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            //need to store the result 
            double grossPay = double.Parse(TxtHours.Text) * double.Parse(CboRate.Text);

            TxtGrossPay.Text = grossPay.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CboName.Text = "";
            TxtHours.Clear();
            CboRate.Text = "";
            TxtGrossPay.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
