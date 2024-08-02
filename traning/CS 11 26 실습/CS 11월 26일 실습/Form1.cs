using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace CS_11월_26일_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string str = "127.0.0.1";
            IPHostEntry host = Dns.GetHostEntry(str);

            listBox1.Items.Add("호스트 이름 : " + host.HostName);
            listBox1.Items.Add("IP주소 리스트\n");
            for (int i = 0; i < host.AddressList.Length; i++)
            {
                IPAddress ip = host.AddressList[i];
                listBox1.Items.Add(ip.ToString());
            }

            listBox1.Items.Add("별명 리스트\n");
            for (int i = 0; i < host.Aliases.Length; i++)
            {
                string ip = host.Aliases[i];
                listBox1.Items.Add(ip.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            IPHostEntry host = Dns.GetHostEntry(str);

            listBox2.Items.Add("호스트 이름 : " + host.HostName);
            listBox2.Items.Add("IP주소 리스트\n");
            for (int i = 0; i < host.AddressList.Length; i++)
            {
                IPAddress ip = host.AddressList[i];
                listBox2.Items.Add(ip.ToString());
            }

            listBox2.Items.Add("별명 리스트\n");
            for (int i = 0; i < host.Aliases.Length; i++)
            {
                string ip = host.Aliases[i];
                listBox2.Items.Add(ip.ToString());
            }
        }
    }
}
