using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 기말_01
{
    public partial class DialogForm : Form
    {
        int index = -1;
        Form1 f1 = new Form1();
        public DialogForm(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (index == -1)
            {
                string str1 = textBox1.Text;    //찾을 단어
                string str2 = textBox2.Text;    //바꿀 단어
                string str3 = f1.textBox1.Text; //본문

                index = f1.textBox1.Text.IndexOf(str1);
                if (index == -1)
                {
                    MessageBox.Show("찾을 단어가 없습니다.");
                }
                else
                {
                    int len = textBox1.TextLength;
                    f1.textBox1.Focus();
                    f1.textBox1.Select(index, len);
                }
            }
            else
            {
                StringBuilder buffer = new StringBuilder();
                string str1 = textBox1.Text;    //찾을 단어
                string str2 = textBox2.Text;    //바꿀 단어
                string str3 = f1.textBox1.Text; //본문

                int len = str1.Length;
                buffer.Append(str3);
                buffer.Remove(index, len);
                buffer.Insert(index, str2);
                f1.textBox1.Text = buffer.ToString();
                index = f1.textBox1.Text.IndexOf(textBox1.Text, index);
                if (index == -1)
                {
                    MessageBox.Show("문서의 끝까지 바꾸기를 수행했습니다.");
                }
                else
                {
                    int len1 = textBox1.TextLength;
                    f1.textBox1.Focus();
                    f1.textBox1.Select(index, len1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                string str1 = textBox1.Text;    //찾을 단어
                string str2 = textBox2.Text;    //바꿀 단어
                string str3 = f1.textBox1.Text; //본문

                StringBuilder buffer = new StringBuilder();
                buffer.Append(str3);
                buffer.Replace(str1, str2);
                str3 = buffer.ToString();
                f1.textBox1.Text = str3;
            }
            else
            {
                MessageBox.Show("단어를 입력하세요");
            }
        }
    }
}
