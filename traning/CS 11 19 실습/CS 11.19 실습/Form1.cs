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

namespace CS_11._19_실습
{
    public partial class Form1 : Form
    {
        ArrayList saveData;

        private int drawMode;
        private Point startPoint;
        private Point nowPoint;
        private Pen myPen;

        public Form1()
        {
            InitializeComponent();
            drawMode = 1;
            myPen = new Pen(Color.Black);

            saveData = new ArrayList();
        }

        private void 종료ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, saveData);
            fs.Close();
        }

        private void 읽기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();
            saveData.Clear();
            saveData = (ArrayList)bf.Deserialize(fs);
            fs.Close();
            Invalidate();
        }

        private void 선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = 1;
            Invalidate();
            Update();
        }

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = 3;
            Invalidate();
            Update();
        }

        private void 원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = 2;
            Invalidate();
            Update();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Cursor = Cursors.Cross;
            nowPoint = new Point(e.X, e.Y);
            startPoint = nowPoint; 
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            nowPoint = new Point(e.X, e.Y);
            Graphics g = CreateGraphics();
            Invalidate(); 
            Update();
            Rectangle rect;

            switch (drawMode)
            {
                case 1: // 선 그리기
                    g.DrawLine(myPen, startPoint, nowPoint);
                    break;
                case 2: // 원 그리기
                    rect = new Rectangle(startPoint.X, startPoint.Y,
                    nowPoint.X - startPoint.X, nowPoint.Y - startPoint.Y);
                    g.DrawEllipse(myPen, rect);
                    break;
                case 3: // 사각형 그리기
                    rect = new Rectangle(startPoint.X, startPoint.Y,
                    nowPoint.X - startPoint.X, nowPoint.Y - startPoint.Y);
                    g.DrawRectangle(myPen, rect);
                    break;
            }
            g.Dispose();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
            DrawData inputData;
            if (e.Button != MouseButtons.Left) return;
            switch (drawMode)
            {
                case 1: // 선 그리기
                    inputData = new DrawData(startPoint, nowPoint, drawMode);
                    saveData.Add(inputData);
                    break;
                case 2: // 원 그리기
                    inputData = new DrawData(startPoint, nowPoint, drawMode);
                    saveData.Add(inputData);
                    break;
                case 3: // 사각형 그리기
                    inputData = new DrawData(startPoint, nowPoint, drawMode);
                    saveData.Add(inputData);
                    break;
            }
            this.Cursor = Cursors.Arrow;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (DrawData outData in saveData)
            { outData.drawData(e.Graphics); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            ResizeRedraw = true;
        }

        private void 지우기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveData.Clear();
            Invalidate();
            Update();
        }

        private void 취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveData.Count > 0)
            {
                saveData.RemoveAt(saveData.Count - 1);
                Invalidate(); Update();
            }
        }
    }
}
