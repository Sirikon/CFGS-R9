using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace R9E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            String numberRaw = numberTextBox.Text;
            Int32 number = 0;
            Boolean wrongNumber = false;
            try
            {
                number = Int32.Parse(numberRaw);
            }
            catch
            {
                wrongNumber = true;
            }

            if(!wrongNumber && number < 0)
            {
                wrongNumber = true;
            }

            if (wrongNumber)
            {
                MessageBox.Show("No has introducido un número positivo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Int32 result = 0;
                for (Int32 i = 0; i <= number; i++) {
                    result += i;
                }
                MessageBox.Show("Resultado: " + result.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
