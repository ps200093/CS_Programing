using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_10월_17일_과제_윈폼_
{
    public partial class Form1 : Form
    {
        public string copyStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void 찾ㅇ바꾸기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void 모두선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void 자르기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyStr = textBox1.SelectedText.ToString();
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, copyStr.Length);
            MessageBox.Show($"{copyStr}를 잘라냄");
        }

        private void 취소ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyStr = textBox1.SelectedText.ToString();
            MessageBox.Show($"{copyStr}를 복사함");
        }

        private void 붙이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, copyStr);
        }
    }
}
