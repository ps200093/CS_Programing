using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS실습_윈도우폼_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            numericUpDown1.Value = hScrollBar1.Value;
            numericUpDown2.Value = hScrollBar2.Value;
            numericUpDown3.Value = hScrollBar3.Value;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            hScrollBar1.Value = (int)numericUpDown1.Value;
            hScrollBar2.Value = (int)numericUpDown2.Value;
            hScrollBar3.Value = (int)numericUpDown3.Value;
        }
    }
}
