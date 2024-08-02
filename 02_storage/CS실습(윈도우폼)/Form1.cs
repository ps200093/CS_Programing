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

namespace CS실습_윈도우폼_
{
    public partial class Form1 : Form
    {
        ArrayList al = new ArrayList();
        //ADD_CARD ac = new ADD_CARD();
        public Form1()
        {
            InitializeComponent();
    
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            ADD_CARD ac = new ADD_CARD();
            ac.name = textBox_name.Text;
            ac.phone = textBox_phone.Text;
            ac.address = textBox_address.Text;

            al.Add(ac);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            bool istrue = false;
            ADD_CARD ac = new ADD_CARD();
            foreach (ADD_CARD tmpAC in al)
            {
                if (textBox_name.Text == tmpAC.name)
                {
                    textBox_name.Text = tmpAC.name;
                    textBox_phone.Text = tmpAC.phone;
                    textBox_address.Text = tmpAC.address;
                    istrue = true;
                }
            }
            if (!istrue)
            {
                textBox_name.Text = "찾는거 없음";
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ADD_CARD ac = new ADD_CARD();
            ac = (ADD_CARD)al[0];
            textBox_name.Text = ac.name;
            textBox_address.Text = ac.address;
            textBox_phone.Text = ac.phone;
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_address.Clear();
            textBox_phone.Clear();
        }
    }
}
