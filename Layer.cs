using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;

namespace WebFlowerJuly1
{
    public class Layer
    {
        int NumberOfPetals;
        double OffsetFromNoon;
        //Point Ctr = new Point(200, 200);
        double LenOfPetal;
        double BulgLocAsPercent;
        double BulgSize;
        Brush br1 = new SolidBrush(Color.FromArgb(80, 10, 0, 240));
        Point Ctr;

        public Layer(Point ctr,
            int numberOfPetals, double offsetFromNoon, double lenOfPetal, double bulgLocAsPercent, double bulgSize)
        {
            NumberOfPetals = numberOfPetals;
            OffsetFromNoon = offsetFromNoon;
            LenOfPetal = lenOfPetal;
            BulgLocAsPercent = bulgLocAsPercent;
            BulgSize = bulgSize;
            Ctr = ctr;
        }
        public void DrawLayer(GraphicsPath path1, GraphicsPath path2, GraphicsPath path3)
        {
            double eachDeg = 360.0 / (double)NumberOfPetals;
            double cummulativeDegs;
            double rad;

            for (int i = 0; i < NumberOfPetals; i++)
            {
                cummulativeDegs = OffsetFromNoon + (double)(i * eachDeg);
                rad = ConvertToRad(cummulativeDegs);

                Petal nextPetal = new Petal(Ctr, rad, LenOfPetal, BulgLocAsPercent, BulgSize);
                nextPetal.DrawPetal(path1, path2, path3);

            }
        }
        public double ConvertToRad(double deg)
        {
            return deg * 0.01745329252;
        }
    }
}