using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈도우_테스트
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            MessageBox.Show("버튼", "제목");
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radio1(object sender, EventArgs e)
        {
            textBox1.Text = "radioOne";
        }

        private void radio(object sender, EventArgs e)
        {
            textBox1.Text = "radioTwo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HScrollBar1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void scroll(object sender, ScrollEventArgs e)
        {
        //    this.BackColor = Color.FromArgb(hScrollBar1.Value, 0, 0);
        }

        private void scroll2(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb((int)numericUpDown1.Value, 0, 0);

        }

        private void scroll0(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, 0, 0);
            this.BackColor = Color.FromArgb((int)numericUpDown1.Value, 0, 0);

            //hScrollBar1.Value = (int)numericUpDown1.Value;
            //numericUpDown1.Value = hScrollBar1.Value;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedItem.ToString();
            MessageBox.Show(str + "을 선택", "제목");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.Text = "";

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.Items.Count.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //textBox2.Text = listBox1.Items.item
            MessageBox.Show("오류뜸", "하");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(1, textBox2.Text);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox1.Text = "표시";
            else
                textBox1.Text = "표시안함";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox3.Text);
            textBox3.Text = "";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(checkedListBox1.CheckedItems[0]);    //저거 배열이였네, 이렇게 쓰면 불안정
            foreach (string str in checkedListBox1.CheckedItems)
                listBox2.Items.Add(str);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            foreach (string str in checkedListBox1.Items)
                listBox1.Items.Add(str);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedIndex != -1)
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    textBox4.Text = "테스트1";
                    break;
                case 1:
                    textBox4.Text = "테스트2";
                    break;
                case 2:
                    textBox4.Text = "테스트3";
                    break;
                case 3:
                    listBox1.Sorted = true;
                    break;
                case 4:
                    listBox1.Sorted = false;    //해제 안됌
                    MessageBox.Show("실행 안됌", "ㅎㅎ");
                    break;
            }
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem(textBox5.Text, int.Parse(comboBox2.SelectedIndex.ToString()));
            li.SubItems.Add(textBox6.Text);
            li.SubItems.Add(textBox7.Text);
            listView1.Items.Add(li);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                //int w = listView1.FocusedItem.Index;
                listView1.FocusedItem.Remove();
            }

            //if (listView1.SelectedItems != null)
            //    foreach (ListViewItem tmp in listView1.SelectedItems)
            //        listView1.Items.Remove(tmp);

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                int w = listView1.FocusedItem.Index;
                listView1.Items.RemoveAt(w);

                ListViewItem li = new ListViewItem(textBox5.Text, int.Parse(comboBox2.Text));
                li.SubItems.Add(textBox6.Text);
                li.SubItems.Add(textBox7.Text);

                listView1.Items.Insert(w, li);

            }
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            TreeNode tr = new TreeNode(textBox8.Text, 0, int.Parse(comboBox3.SelectedIndex.ToString()));
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Nodes.Add(tr);
            else
                treeView1.Nodes.Add(tr);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Remove();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private int count = 0;
        private void Button18_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (count == 60) count = 0;
            else count++;
            label2.Text = "타이머 : " + count.ToString();
            trackBar1.Value = count;
            progressBar1.Value = count;
        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Top;
        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Bottom;
        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Left;
        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Alignment = TabAlignment.Right;
        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.Normal;
        }

        private void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.Buttons;
        }

        private void RadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker1.Value.ToString();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label3.Text = monthCalendar1.SelectionRange.Start.ToString();
        }

        private void Label3_Click(object sender, EventArgs e)
        { 
        }

        private void GroupBox9_Enter(object sender, EventArgs e)
        {
        }

        private void GroupBox10_Enter(object sender, EventArgs e)
        {

        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            toolStripStatusLabel2.Text = string.Format($"{dt.Year}년 {dt.Month}월 {dt.Day}일");
            toolStripStatusLabel3.Text = string.Format($"{dt.Hour}시 {dt.Minute}분 {dt.Second}초");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format($"X : {e.X} Y : {e.Y}");
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(e.ClickedItem.Text, "?");
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            DialogForm df = new DialogForm();
            df.ShowDialog();

            textBox9.Text = df.textBox1.Text;
            comboBox4.Text = df.comboBox1.SelectedItem.ToString();
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
        }

        private void ToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox10.ForeColor = colorDialog1.Color;
        }

        private void ToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string str = openFileDialog1.FileName + "파일을 선택";
            textBox1.Text = str;
        }

        private void ToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox10.Font = fontDialog1.Font;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            wb.ShowDialog();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "모든파일(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
