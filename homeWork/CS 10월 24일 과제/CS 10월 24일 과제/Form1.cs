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

namespace CS_10월_24일_과제
{
    public partial class Form1 : Form
    {
        public DirectoryInfo dinfo;
        public DirectoryInfo[] dir;
        public int dir_count;
        public string dest_filename;
        public FileInfo s_file;
        public Form1()
        {
            InitializeComponent();
            dir_count = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileInfo finfo = new FileInfo(openFileDialog1.FileName);
            dinfo = finfo.Directory;
            dir = dinfo.GetDirectories();
            dir_count = dir.Length + 1;
            listView1.Items.Clear();

            this.Text = dinfo.FullName.ToString();

            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add("");
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView1.Items.Add(item);

            foreach (DirectoryInfo d in dir)
            {
                ListViewItem li = new ListViewItem(d.Name.ToString(), 0); ;
                li.SubItems.Add(d.Attributes.ToString());
                li.SubItems.Add("");
                li.SubItems.Add(d.CreationTime.ToString());
                listView1.Items.Add(li);
            }

            FileInfo[] files = dinfo.GetFiles();
            foreach (FileInfo f in files)
            {
                ListViewItem li = new ListViewItem(f.Name.ToString(), 1);
                li.SubItems.Add(f.Attributes.ToString());
                li.SubItems.Add(f.Length.ToString());
                li.SubItems.Add(f.CreationTime.ToString());
                listView1.Items.Add(li);
            }

        }

        private void 복사하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo[] files = dinfo.GetFiles();
            s_file = files[listView1.FocusedItem.Index - dir_count];
        }

        private void 지우기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo[] filesp = dinfo.GetFiles();
            s_file = filesp[listView1.FocusedItem.Index - dir_count];
            s_file.Delete();
            listView1.Items.Clear();
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add(""); 
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView1.Items.Add(item); 


            foreach (DirectoryInfo d in dir)
            {
                ListViewItem item1 = new ListViewItem(d.Name.ToString(), 0);
                item1.SubItems.Add(d.Attributes.ToString());
                item1.SubItems.Add("");
                item1.SubItems.Add(d.CreationTime.ToString());
                listView1.Items.Add(item1);
            }
            FileInfo[] files = dinfo.GetFiles();
            foreach (FileInfo f in files)
            {
                ListViewItem item1 = new ListViewItem(f.Name.ToString(), 1);
                item1.SubItems.Add(f.Attributes.ToString());
                item1.SubItems.Add(f.Length.ToString());
                item1.SubItems.Add(f.CreationTime.ToString());
                listView1.Items.Add(item1);

            }
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dest_filename = dinfo.FullName + @"\" + s_file.Name;
            s_file.CopyTo(dest_filename);
            listView1.Items.Clear();
            ListViewItem item = new ListViewItem("..", 0);
            item.SubItems.Add(""); 
            item.SubItems.Add("");
            item.SubItems.Add("");
            listView1.Items.Add(item); 


            foreach (DirectoryInfo d in dir)
            {
                ListViewItem item1 = new ListViewItem(d.Name.ToString(), 0);
                item1.SubItems.Add(d.Attributes.ToString());
                item1.SubItems.Add("");
                item1.SubItems.Add(d.CreationTime.ToString());
                listView1.Items.Add(item1);
            }
            FileInfo[] files = dinfo.GetFiles();
            foreach (FileInfo f in files)
            {
                ListViewItem item1 = new ListViewItem(f.Name.ToString(), 1);
                item1.SubItems.Add(f.Attributes.ToString());
                item1.SubItems.Add(f.Length.ToString());
                item1.SubItems.Add(f.CreationTime.ToString());
                listView1.Items.Add(item1);
            }
        }
    }
}
