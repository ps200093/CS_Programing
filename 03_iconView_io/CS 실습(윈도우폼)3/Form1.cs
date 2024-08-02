using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_실습_윈도우폼_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

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
            ListViewItem li = new ListViewItem(textBox1.Text, int.Parse(textBox3.Text));
            li.SubItems.Add(textBox2.Text);
            listView1.Items.Add(li);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems != null)
            {
                //foreach (ListViewItem i in listView1.SelectedItems)
                //    listView1.Items.Remove(i);
                listView1.FocusedItem.Remove();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //int w = listView1.SelectedIndices[-1];
            //foreach(ListViewItem i in listView1.SelectedItems)
            //    listView1.Items.Remove(i);

            //ListViewItem li = new ListViewItem(textBox1.Text, int.Parse(textBox3.Text));
            //li.SubItems.Add(textBox2.Text);
            //listView1.Items.Insert(w, li);

            //int w = listView1.FocusedItem.Index;
            //listView1.FocusedItem.Remove();
            //ListViewItem li = new ListViewItem(textBox1.Text, int.Parse(textBox3.Text));
            //li.SubItems.Add(textBox2.Text);
            //listView1.Items.Insert(w, li);
            
            int i = listView1.SelectedIndices[-1];
            foreach (ListViewItem a in listView1.SelectedItems)
                listView1.Items.Remove(a);
            ListViewItem item = new ListViewItem(textBox1.Text, int.Parse(textBox3.Text));
            item.SubItems.Add(textBox2.Text);
            listView1.Items.Insert(i, item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
