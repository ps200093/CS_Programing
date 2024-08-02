using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CS_11._19_실습
{
    [Serializable]
    class DrawData
    {
        public Point startPoint;
        public Point endPoint;
        public int drawMode;

        public DrawData(Point x, Point y, int dMode)
        {
            startPoint = x;
            endPoint = y;
            drawMode = dMode;
        }

        public void drawData(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Rectangle rect;
            switch (drawMode)
            {
                case 1: // 선 그리기
                    g.DrawLine(pen, startPoint, endPoint); // 새로운 선을 그리기
                    break;
                case 2: // 원 그리기
                    rect = new Rectangle(startPoint.X, startPoint.Y,
                    endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                    g.DrawEllipse(pen, rect);
                    break;
                case 3: // 사각형 그리기
                    rect = new Rectangle(startPoint.X, startPoint.Y,
                    endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                    g.DrawRectangle(pen, rect);
                    break;
            }
        }
    }
}
