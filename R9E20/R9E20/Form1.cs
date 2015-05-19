using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R9E20
{
    public partial class Form1 : Form
    {
        private CBotones cbotones = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // To-do
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            if (cbotones != null)
                cbotones.destroy();
            
            cbotones = new CBotones(this, (Int32)columnasInput.Value, (Int32)filasInput.Value);

            this.ClientSize = new Size(cbotones.totalWidth, cbotones.totalHeight);
            this.CenterToScreen();

            this.ResumeLayout(false);
        }
    }
}
