using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Zach Scheffler
   Obj-Oriented Programming / ITD-2343
   30 May, 2023 */

namespace SchefflerLab_Project
{
    public partial class frmScheffler : Form
    {
        public frmScheffler()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnRed.BackColor;
            lblTheDominator.ForeColor = Color.White;

            //background as red, text as white
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnGreen.BackColor;
            lblTheDominator.ForeColor = Color.White;

            //background as green, text as white
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnPink.BackColor;
            lblTheDominator.ForeColor = Color.Black;

            //background as pink, text as black
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnOrange.BackColor;
            lblTheDominator.ForeColor = Color.Black;

            //background as organe, text as black
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnBlue.BackColor;
            lblTheDominator.ForeColor = Color.White;

            //background as blue, text as white
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnCyan.BackColor;
            lblTheDominator.ForeColor = Color.Black;

            //background as cyan, text as black
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnYellow.BackColor;
            lblTheDominator.ForeColor = Color.Black;

            //background as yellow, text as black
        }

        private void btnIndigo_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnIndigo.BackColor;
            lblTheDominator.ForeColor = Color.White;

            //background as indigo, text as white
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            lblTheDominator.BackColor = btnBrown.BackColor;
            lblTheDominator.ForeColor = Color.White;

            //background as brown, text as white
        }

        private void btnDigit1_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit1.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 1, text is black if no color button selected
        }

        private void btnDigit2_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit2.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 2, text is black if no color button selected
        }

        private void btnDigit3_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit3.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 3, text is black if no color button selected
        }

        private void btnDigit4_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit4.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 4, text is black if no color button selected
        }

        private void btnDigit5_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit5.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 5, text is black if no color button selected
        }

        private void btnDigit6_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit6.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 6, text is black if no color button selected
        }

        private void btnDigit7_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit7.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 7, text is black if no color button selected
        }

        private void btnDigit8_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit8.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 8, text is black if no color button selected
        }

        private void btnDigit9_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = btnDigit9.Text;
            lblTheDominator.ForeColor = Color.Black;

            //change text to digit 9, text is black if no color button selected
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTheDominator.Text = "";
            lblTheDominator.BackColor = Color.White;

            //clear out text in label, return to default background color
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            //close the application
        }
    }
}
