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
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;


namespace _11._19실습_다시해보기
{

    public partial class Form1 : Form
    {
        private int drawMode; // 그리기 모드
        private Point startPoint; // 시작 점
        private Point nowPoint; // 현재 점
        private Pen myPen; // 펜
        private ArrayList saveData; // 그림 객체 정보 저장

        private bool Curve;
        private int identifyCurve;

        public Form1()
        {
            InitializeComponent();
            drawMode = 1; // 선 그리기로 초기화
            myPen = new Pen(Color.Black);
            saveData = new ArrayList();
            Curve = false;
            identifyCurve = 0;
    }

        private void 선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = 1;
        }

        private void 사각형ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = 3;
        }

        private void 원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = 2;
        }

        private void 곡선ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawMode = 4;
        }


        private void 일ㄹ기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            saveData.Clear();
            saveData = (ArrayList)bf.Deserialize(fs);
            fs.Close();
            Invalidate();
        }

        private void 쓰기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, saveData);
            fs.Close();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Cursor = Cursors.Cross; // 커서를 십자가 커서로 변경
            nowPoint = new Point(e.X, e.Y); // 현재 마우스의 위치
            startPoint = nowPoint;

            if(drawMode == 4)
            {
                Curve = true;
                DrawData inputData = new DrawData(startPoint, nowPoint, myPen, Curve, drawMode, identifyCurve);
                saveData.Add(inputData);
                Curve = false;  
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            nowPoint = new Point(e.X, e.Y); // 현재 마우스의 위치
            Graphics g = CreateGraphics();
            Invalidate(); // 무효화
            Update(); //무효화 시킨 영역을 다시 그리기
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
                case 4:
                    Curve = true;
                    g.DrawLine(myPen, startPoint, nowPoint);
                    DrawData inputData = new DrawData(startPoint, nowPoint, myPen, Curve, drawMode, identifyCurve);
                    saveData.Add(inputData);
                    startPoint = nowPoint;
                    Curve = false;
                    break;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            DrawData inputData;
            switch (drawMode)
            {
                case 1: // 선 그리기
                    inputData = new DrawData(startPoint, nowPoint, myPen, drawMode);
                    saveData.Add(inputData);
                    break;
                case 2: // 원 그리기
                    inputData = new DrawData(startPoint, nowPoint, myPen,
                    drawMode);
                    saveData.Add(inputData);
                    break;
                case 3: // 사각형 그리기
                    inputData = new DrawData(startPoint, nowPoint, myPen,
                    drawMode);
                    saveData.Add(inputData);
                    break;
                case 4:
                    identifyCurve++;
                    break;
            }
            this.Cursor = Cursors.Arrow;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (DrawData outData in saveData)
                outData.drawData(e.Graphics);
        }

        private void 취소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveData.Count > 0)
            {
                DrawData tmp = (DrawData)saveData[saveData.Count - 1];

                if(tmp.Curve == true)
                {
                    int compareCurve = tmp.identifyCurve;
                    while (true)
                    {
                        if (compareCurve == tmp.identifyCurve)
                        {
                            saveData.RemoveAt(saveData.Count - 1);
                            if (saveData.Count < 1) break;
                            tmp = (DrawData)saveData[saveData.Count - 1];
                            if (tmp.Curve == false) break;
                        }
                        else break;
                    }
                }
                else
                {
                    if (saveData.Count == 0)
                        return;
                    saveData.RemoveAt(saveData.Count - 1);
                }
                Invalidate();   Update();
            }
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveData.Clear();
            Invalidate();   Update();
        }
    }
}
