using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS_10_22_화_실습
{
    public partial class Form1 : Form
    {
        DirectoryInfo dinfo;
        public Form1()
        {
            InitializeComponent();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            openFileDialog1.ShowDialog();
            FileInfo finfo = new FileInfo(openFileDialog1.FileName);
            dinfo = finfo.Directory;

            this.Text = dinfo.ToString();

            foreach (DirectoryInfo d in dinfo.GetDirectories())
                listBox1.Items.Add(d);
            //    foreach (FileInfo f in dinfo.GetFiles())
            //        listBox1.Items.Add(f);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            //foreach (DirectoryInfo d in dinfo.GetDirectories())
            //{
            //    if(d.ToString() == listBox1.SelectedItem.ToString())
            //    {
            //        foreach (DirectoryInfo d2 in d.GetDirectories())
            //            listBox2.Items.Add(d2);
            //        foreach (FileInfo f in d.GetFiles())
            //            listBox2.Items.Add(f);
            //    }
            //}

            //위 아래 같은 코드

            if (dinfo.Exists)
            {
                DirectoryInfo[] dir = dinfo.GetDirectories();
                foreach (DirectoryInfo d in dir)
                {
                    if (d.Name == listBox1.SelectedItem.ToString())
                    {
                        //DirectoryInfo[] d2 = d.GetDirectories();
                        //foreach (DirectoryInfo d3 in d2)
                        //    listBox2.Items.Add(d3);               파일 출력 안하기

                        FileInfo[] files = d.GetFiles();
                        foreach (FileInfo f in files)
                            listBox2.Items.Add(f);

                    }
                }
            }

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(listBox2.SelectedItem != null)
            //    foreach (DirectoryInfo d in dinfo.GetDirectories())
            //        if (d.ToString() == listBox1.SelectedItem.ToString())       //listBox2로 넘어감
            //        {
            //            foreach (FileInfo f in d.GetFiles())
            //                if (f.Name == listBox2.SelectedItem.ToString())
            //                    MessageBox.Show($"{f.Name}");
            //        }

            if (listBox2.SelectedItem != null)
                MessageBox.Show($"{listBox2.SelectedItem.ToString()}"); 
        }
    }
}       