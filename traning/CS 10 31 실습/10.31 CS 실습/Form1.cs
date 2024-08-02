using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace _10._31_CS_실습
{
    public partial class Form1 : Form
    {
        ArrayList al = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem(textBox1.Text, comboBox1.SelectedIndex);
            li.SubItems.Add(textBox2.Text);
            li.SubItems.Add(textBox3.Text);
            li.SubItems.Add(comboBox1.Text);

            listView1.Items.Add(li);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            al.Clear();

            foreach(ListViewItem tmp in listView1.Items)
                al.Add(tmp);

            FileStream fs = new FileStream("test2.bin", FileMode.Create);   //껍데기(껍데기를 만들면서, 경로지정)
            BinaryFormatter bf = new BinaryFormatter();                     //내용물
            bf.Serialize(fs, al);                                           //직열화 == 내용물을 만들어주는거, 저장 (2진으로)
            fs.Close();                                                     //안해도되는거 같지만 형식상 켜놓고 끄는거
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);    //껍데기(경로) 가져오기
            BinaryFormatter bf1 = new BinaryFormatter();                                //내용물 가져올 준비
            al = (ArrayList)bf1.Deserialize(fs);                                        //al에 내용물 집어넣기 (2진파일을 변화)
            
            foreach(ListViewItem tmp in al)
            {
                listView1.Items.Add(tmp);                                           
            }
        }
    }
}
