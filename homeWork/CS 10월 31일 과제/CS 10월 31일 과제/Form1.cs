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

//if arraylist 내부를 고치고 싶다면
namespace CS_10월_31일_과제
{
    public partial class Form1 : Form
    {
        ArrayList al;
        public Form1()
        {
            InitializeComponent();
            al = new ArrayList();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem(textBox1.Text, comboBox1.SelectedIndex);
            li.SubItems.Add(textBox2.Text);
            li.SubItems.Add(textBox3.Text);

            listView1.Items.Add(li);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                foreach (ListViewItem i in listView1.SelectedItems)
                    listView1.Items.Remove(i);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            al.Clear();

            foreach (ListViewItem tmp in listView1.Items)
                al.Add(tmp);

            FileStream fs = new FileStream(textBox4.Text, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, al);
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            al.Clear();

            openFileDialog1.ShowDialog();
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            al = (ArrayList)bf.Deserialize(fs);
             
            foreach(ListViewItem tmp in al)
            {
                listView1.Items.Add(tmp);
            }
        }
    }
}
