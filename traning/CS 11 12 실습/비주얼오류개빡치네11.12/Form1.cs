using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.OleDb;

namespace 비주얼오류개빡치네11._12
{
    public partial class Form1 : Form
    {
        DataTable myTable;

        public Form1()
        {
            InitializeComponent();
            myTable = new DataTable("address");

            DataColumn column;
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Name";
            column.AllowDBNull = false;
            myTable.Columns.Add(column);

            //나이, 전화번호, 성별 칼럼 만들기
            //나이
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "AGE";
            column.AllowDBNull = false;
            myTable.Columns.Add(column);

            //전화번호
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "CELLPHONE";
            column.AllowDBNull = false;
            myTable.Columns.Add(column);

            //성별
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "SEX";
            column.AllowDBNull = false;
            myTable.Columns.Add(column);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row;
            row = myTable.NewRow();

            row["NAME"] = textBox1.Text;
            row["AGE"] = textBox2.Text;
            row["CELLPHONE"] = textBox3.Text;
            row["SEX"] = textBox4.Text;
            myTable.Rows.Add(row);

            dataGridView1.DataSource = myTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView view1 = new DataView(myTable);
            view1.RowFilter = textBox5.Text;
 
            dataGridView2.DataSource = view1;
        }
    }
}
