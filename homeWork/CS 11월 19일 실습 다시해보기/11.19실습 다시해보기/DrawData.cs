using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _11._19실습_다시해보기
{
    [Serializable]
    class DrawData
    {
        public Point startPoint;
        public Point endPoint;
        public int drawMode;
        public bool Curve;
        public int identifyCurve;

        public DrawData(Point x, Point y, Pen p, int dMode)
        {
            startPoint = x;
            endPoint = y;
            drawMode = dMode;
        }

        public DrawData(Point x, Point y, Pen p, bool Cu, int dMode, int identify)
        {
            startPoint = x;
            endPoint = y;
            drawMode = dMode;
            Curve = Cu;
            identifyCurve = identify;
        }

        public void drawData(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Rectangle rect;
            switch (drawMode)
            {
                case 1:
                    g.DrawLine(pen, startPoint, endPoint);
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
                case 4:
                    g.DrawLine(pen, startPoint, endPoint);
                    break;
            }
        }
    }
}
