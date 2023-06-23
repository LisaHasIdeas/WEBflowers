using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;

namespace WebFlowerJuly1
{
    public class Petal
    {
        Point Ctr;
        double Rad;
        double LenOfPetal;
        double BulgLocAsPercent;
        double BulgSize;

        public Petal(
            Point ctr, double rad, double lenOfPetal, double bulgLocAsPercent, double bulgSize)
        {
            Ctr = ctr;
            Rad = rad;
            LenOfPetal = lenOfPetal;
            BulgLocAsPercent = bulgLocAsPercent;
            BulgSize = bulgSize;
        }

        public void DrawPetal(GraphicsPath path1, GraphicsPath path2, GraphicsPath path3)
        {
            Double petalXX = Math.Sin(Rad) * LenOfPetal;
            Double petalYY = Math.Cos(Rad) * LenOfPetal;
            Point petalTip = new Point((int)(Ctr.X + petalXX), (int)(Ctr.Y - petalYY));

            int tempX = Ctr.X + (int)((BulgLocAsPercent) * (petalTip.X - Ctr.X));
            int tempY = Ctr.Y + (int)((BulgLocAsPercent) * (petalTip.Y - Ctr.Y));
            Point bulgStartPt = new Point(tempX, tempY);

            Double bulgXX1 = Math.Cos(Rad) * BulgSize; Double bulgYY1 = Math.Sin(Rad) * BulgSize;
            Double bulgXX2 = Math.Cos(Rad) * BulgSize; Double bulgYY2 = Math.Sin(Rad) * BulgSize;
            Point bulgTipPt1 = new Point((int)(bulgStartPt.X - bulgXX1), (int)(bulgStartPt.Y - bulgYY1));
            Point bulgTipPt2 = new Point((int)(bulgStartPt.X + bulgXX2), (int)(bulgStartPt.Y + bulgYY2));

            int temp1 = bulgTipPt1.X; int temp2 = bulgTipPt1.Y;
            int temp3 = bulgTipPt2.X; int temp4 = bulgTipPt2.Y;
            Point[] pointsB1 = { Ctr, new Point(temp1, temp2), petalTip };
            Point[] pointsB2 = { Ctr, new Point(temp3, temp4), petalTip };

            //Point[] pointsBOTH = { Ctr, new Point(temp1, temp2), petalTip,
            //    Ctr, new Point(temp3, temp4), petalTip };

            Point[] pointsBOTH = { Ctr, new Point(temp1, temp2), petalTip,
                new Point(temp3, temp4), Ctr };

            path1.AddCurve(pointsB1);
            path2.AddCurve(pointsB2);
            path3.AddClosedCurve(pointsBOTH);

        }

    }
}