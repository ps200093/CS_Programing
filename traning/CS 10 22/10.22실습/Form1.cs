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

namespace _10._22실습
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
            openFileDialog1.ShowDialog();
            FileInfo finfo = new FileInfo(openFileDialog1.FileName);
            dinfo = finfo.Directory;    //연 파일의 디렉토리가 들어감
            
            foreach()
            dinfo.GetDirectories
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //해당 디렉토리에 있는 파일을 오른쪽 리스트 박스에 출력
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //해당 파일명을 메시지로 갖는 메세지 박스 출력
        }
    }
}
