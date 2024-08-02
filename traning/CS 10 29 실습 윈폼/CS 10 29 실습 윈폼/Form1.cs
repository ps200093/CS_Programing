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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CS_10_29_실습_윈폼
{
    public partial class Form1 : Form
    {
        ArrayList al = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //FileStream fs = new FileStream("test.bin", FileMode.Create);

            //ADD_CARD ac = new ADD_CARD();
            //ac.name = textBox1.Text;
            //ac.phone = textBox2.Text;
            //ac.address = textBox3.Text;

            //al.Add(ac);

            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, al);

            //fs.Close();

            ADD_CARD ac = new ADD_CARD();
            ac.name = textBox1.Text;
            ac.phone = textBox2.Text;
            ac.address = textBox3.Text;

            al.Add(ac);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ADD_CARD a in al)
            {
                if(a.name == textBox1.Text)
                {
                    textBox2.Text = a.phone;
                    textBox3.Text = a.address;
                }
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 읽기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            BinaryFormatter bf1 = new BinaryFormatter();
            al = (ArrayList)bf1.Deserialize(fs);
            
            textBox1.Text = ((ADD_CARD)al[0]).name;
            textBox2.Text = ((ADD_CARD)al[0]).phone;
            textBox3.Text = ((ADD_CARD)al[0]).address;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_CARD ac = new ADD_CARD();
            ac.name = textBox1.Text;
            ac.phone = textBox2.Text;
            ac.address = textBox3.Text;

            al.Add(ac);

            FileStream fs = new FileStream("text.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, al);
            fs.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
