using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzelicznikNewtonow
{
    public partial class Przelicznik : Form
    {
        public Przelicznik()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void onBtnClick(object sender, EventArgs e)
        {
            string varInput = textBox1.Text;
            //if(varInput == ""){
            //    MessageBox.Show("Blad, brak danych", "Blad", MessageBoxButtons.OK);
            //    return;
            //}

            double varTemp = 0.0;

            try
            {
                varTemp = double.Parse(varInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Blad", MessageBoxButtons.OK);
            }

            double kG = varTemp * 0.01019716213;
            double kN = varTemp * 0.0010;

            textBox2.Text = kG.ToString();
            textBox3.Text = kN.ToString();
        }
    }
}
