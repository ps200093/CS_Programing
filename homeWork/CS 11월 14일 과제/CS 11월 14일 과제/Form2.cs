using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_11월_14일_과제
{
    public partial class Form2 : Form
    {
        private Form1 dlg;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.dlg = f1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dlg.x = int.Parse(textBox1.Text);
            dlg.y = int.Parse(textBox2.Text);
            dlg.drawString = textBox3.Text;
            dlg.Invalidate();
            Close();
        }
    }
}
