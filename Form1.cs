// Ignore Spelling: frm

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCal : Form
    {
        Calinterface calculatord;
        public frmCal()
        {
            InitializeComponent();
            calculatord = new CalClass();
        }


        bool isValid()
        {
            bool valid = true;
            if (txtNum1.Value == 0 || txtNum2.Value == 0)
            {
                MessageBox.Show("Please enter number for both slot");
                valid = false;
                return valid;
            }
            return valid;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int sum = calculatord.Sum((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show($"Calculation result is : {sum }");
            }
         
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int minus = calculatord.Minus((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show($"Calculaation result is : {minus}");
            }
            
        }

        private void btnMulty_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int multy = calculatord.Myltiple((int)txtNum1.Value, (int)txtNum2.Value);
                MessageBox.Show($"Calculation result is : {multy}");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                float divide = calculatord.Divide((float)txtNum1.Value,(float) txtNum2.Value);
                MessageBox.Show($"Calculation result is : {divide}");
            }
        }
    }
}
