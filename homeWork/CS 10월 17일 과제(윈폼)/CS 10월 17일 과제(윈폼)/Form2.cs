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
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();
        int index = -1;
        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                index = f1.textBox1.Text.IndexOf(textBox1.Text);
                if (index == -1)
                    MessageBox.Show("찾을 단어가 없습니다.");
                else
                {
                    int len = textBox1.TextLength;
                    f1.textBox1.Focus();
                    f1.textBox1.Select(index, len);
                }
            }
            else   //인덱스가 -1이 아님
            {
                StringBuilder buffer = new StringBuilder();
                buffer.Append(f1.textBox1.Text);            //본문 복사
                buffer.Remove(index, textBox1.TextLength);  //삭제
                buffer.Insert(index, textBox2.Text);        //삽입

                f1.textBox1.Text = buffer.ToString();       //본문 넣기
                index = f1.textBox1.Text.IndexOf(textBox1.Text, index);     //두번째는 startindex

                if (index == -1)
                    MessageBox.Show("전부 실행");
                else
                {
                    int len = textBox1.TextLength;
                    f1.textBox1.Focus();
                    f1.textBox1.Select(index, len);
                }
                    
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            StringBuilder buffer = new StringBuilder(f1.textBox1.Text);
            bool print = true;

            f1.textBox1.Focus();

            index = f1.textBox1.Text.IndexOf(textBox1.Text);
            if (index == -1) {
                MessageBox.Show("찾는 텍스트 없음");
                print = false;
            }

            while(true)
            {
                //MessageBox.Show($"{index}");
                if(index == -1)
                {
                    break;
                }
                buffer.Remove(index, textBox1.TextLength);
                buffer.Insert(index, textBox2.Text);
                
                index = buffer.ToString().IndexOf(textBox1.Text);    //인덱스에 넣고
            }
            f1.textBox1.Text = buffer.ToString();
            if (print)
                MessageBox.Show("다 바꿈");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                f1.textBox1.Focus();
                if (index == -1)
                {
                    index = f1.textBox1.Text.IndexOf(textBox1.Text);
                    if (index == -1)
                        MessageBox.Show("찾을 내용이 없습니다.");
                    else
                        f1.textBox1.Select(index, textBox1.Text.Length);
                }
                else
                {
                    index = f1.textBox1.Text.IndexOf(textBox1.Text, index + 1);
                    if (index == -1) MessageBox.Show("끝입니다.");
                    else
                        f1.textBox1.Select(index, textBox1.Text.Length);
                }
            }
            else if (radioButton2.Checked)
            {
                f1.textBox1.Focus();
                if(index == -1)
                {
                    index = f1.textBox1.Text.LastIndexOf(textBox1.Text);
                    if (index == -1)
                        MessageBox.Show("찾을 내용이 없습니다.");
                    else
                        f1.textBox1.Select(index, textBox1.Text.Length);
                }
                else
                {
                    index = f1.textBox1.Text.LastIndexOf(textBox1.Text, index - -1);
                    if (index == -1) MessageBox.Show("끝입니다.");
                    else
                        f1.textBox1.Select(index, textBox1.Text.Length);
                }

            }
            else
            {
                f1.textBox1.Focus();
                if (index == -1)
                {
                    index = f1.textBox1.Text.IndexOf(textBox1.Text);
                    if (index == -1)
                        MessageBox.Show("찾을 내용이 없습니다.");
                    else
                        f1.textBox1.Select(index, textBox1.Text.Length);
                }
                else
                {
                    index = f1.textBox1.Text.IndexOf(textBox1.Text, index + 1);
                    if (index == -1) MessageBox.Show("끝입니다.");
                    else
                        f1.textBox1.Select(index, textBox1.Text.Length);
                }
            }
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
