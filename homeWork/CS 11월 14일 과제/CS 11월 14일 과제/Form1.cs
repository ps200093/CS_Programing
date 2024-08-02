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
    public partial class Form1 : Form
    {
        public Font drawFont;
        public SolidBrush drawBrush;
        public int x, y;
        public string drawString;
        public Form1()
        {
            InitializeComponent();
            drawFont = new Font("굴림", 30, FontStyle.Regular);
            drawBrush = new SolidBrush(Color.Black);
            x = 50; y = 50;
            drawString = "바꾸기 전 문자열";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawString(drawString, drawFont, drawBrush, x, y);
}

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 폰트대화상자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            drawFont = fontDialog1.Font;
            Invalidate();
        }

        private void 색대화상자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            drawBrush.Color = colorDialog1.Color;
            Invalidate();
        }

        private void 위치문자열대화상자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

   
    }
}
