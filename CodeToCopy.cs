using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFlowerJuly1
{
    public class CodeToCopy
    {

        /*
         * 
         * 
         * <style>
        .slidecontainer {
            width: 100%;
        }

        .slider {
            -webkit-appearance: none;
            width: 100%;
            height: 25px;
            background: #d3d3d3;
            outline: none;
            opacity: 0.7;
            -webkit-transition: .2s;
            transition: opacity .2s;
        }

            .slider:hover {
                opacity: 1;
            }

            .slider::-webkit-slider-thumb {
                -webkit-appearance: none;
                appearance: none;
                width: 25px;
                height: 25px;
                background: #808080;
                cursor: pointer;
            }

            .slider::-moz-range-thumb {
                width: 25px;
                height: 25px;
                background: #4CAF50;
                cursor: pointer;
            }
    </style>
         * *********************Main***************
         * 
         * using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.SqlServer.Server;

namespace FlowerWithClasses
{
    public partial class Form1 : Form
    {
        Graphics g; GraphicsPath path1, path2, path3; Brush br1, br2, br3;

        TrackBar tbarT1, tbarR1, tbarG1, tbarB1; //Transparancy, then RGB
        TrackBar tbarT2, tbarR2, tbarG2, tbarB2;
        TrackBar tbarT3, tbarR3, tbarG3, tbarB3;

        Boolean ignoreForNow = false;

        Random Ran = new Random();

        CheckBox cbShow2ndLayer;

        Label labDets1, labDets2;


        TrackBar tbarNumPetals1, tbarPetLen1, tbarBulgPerc1, tbarBulgWid1;
        TrackBar tbarNumPetals2, tbarPetLen2, tbarBulgPerc2, tbarBulgWid2;

        private void btn_MakeAllRandom_Click(object sender, EventArgs e)
        {

            ignoreForNow = true;
            MakeColorsRandom();
            MakeRestRandom();
            ignoreForNow = false;


        }

        Label c1, c2, c3;
        Point ctr;

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            createTBars();
            //MakeColorsRandom();


        }

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_RandColor_Click(object sender, EventArgs e)
        {
            MakeColorsRandom();
            //MakeRestRandom();
        }

        private void MakeColorsRandom()
        {
            ignoreForNow = true;
            AdjustRandomly(tbarR1);
            AdjustRandomly(tbarG1);
            AdjustRandomly(tbarB1);
            AdjustRandomly(tbarT1);

            AdjustRandomly(tbarR2);
            AdjustRandomly(tbarG2);
            AdjustRandomly(tbarB2);
            AdjustRandomly(tbarT2);

            AdjustRandomly(tbarR3);
            AdjustRandomly(tbarG3);
            AdjustRandomly(tbarB3);
            AdjustRandomly(tbarT3);
            ignoreForNow = false;
            UpdateColors();


            if (txtTurbo.Text.ToUpper() == "LISA")
                MakeAFlower();


            //MakeAFlower(); /////////////Maybe remove
        }


        private void MakeRestRandom()
        {


            ignoreForNow = true;
            AdjustRandomly(tbarNumPetals1);
            AdjustRandomly(tbarPetLen1);
            AdjustRandomly(tbarBulgPerc1);
            AdjustRandomly(tbarBulgWid1);

            AdjustRandomly(tbarNumPetals2);
            AdjustRandomly(tbarPetLen2);
            AdjustRandomly(tbarBulgPerc2);
            AdjustRandomly(tbarBulgWid2);
            ignoreForNow = false;

            //UpdateColors();

            if (txtTurbo.Text.ToUpper() == "LISA")
                MakeAFlower();

        }
        private void AdjustRandomly(TrackBar x)
        {

            x.Value = Ran.Next(x.Minimum, x.Maximum);
            //UpdateColors();

        }

        private void createTBars()
        {
            int vertSpace = 36;
            int startSpot = 10;
            int fromLeft = 85;
            tbarR1 = new TrackBar(); tbarR1 = formatTBar(fromLeft, startSpot + vertSpace * 0, 0, 255, 10, Color.Red);
            tbarG1 = new TrackBar(); tbarG1 = formatTBar(fromLeft, startSpot + vertSpace * 1, 0, 255, 10, Color.Green);
            tbarB1 = new TrackBar(); tbarB1 = formatTBar(fromLeft, startSpot + vertSpace * 2, 0, 255, 240, Color.Blue);
            tbarT1 = new TrackBar(); tbarT1 = formatTBar(fromLeft, startSpot + vertSpace * 3, 0, 255, 100, Color.LightGray);

            startSpot = startSpot + (int)(4.5 * vertSpace);
            tbarR2 = new TrackBar(); tbarR2 = formatTBar(fromLeft, startSpot + vertSpace * 0, 0, 255, 100, Color.Red);
            tbarG2 = new TrackBar(); tbarG2 = formatTBar(fromLeft, startSpot + vertSpace * 1, 0, 255, 30, Color.Green);
            tbarB2 = new TrackBar(); tbarB2 = formatTBar(fromLeft, startSpot + vertSpace * 2, 0, 255, 30, Color.Blue);
            tbarT2 = new TrackBar(); tbarT2 = formatTBar(fromLeft, startSpot + vertSpace * 3, 0, 255, 70, Color.LightGray);

            startSpot = startSpot + (int)(4.5 * vertSpace);
            tbarR3 = new TrackBar(); tbarR3 = formatTBar(fromLeft, startSpot + vertSpace * 0, 0, 255, 240, Color.Red);
            tbarG3 = new TrackBar(); tbarG3 = formatTBar(fromLeft, startSpot + vertSpace * 1, 0, 255, 40, Color.Green);
            tbarB3 = new TrackBar(); tbarB3 = formatTBar(fromLeft, startSpot + vertSpace * 2, 0, 255, 140, Color.Blue);
            tbarT3 = new TrackBar(); tbarT3 = formatTBar(fromLeft, startSpot + vertSpace * 3, 0, 255, 120, Color.LightGray);

            startSpot = 5;
            fromLeft = fromLeft - 10;
            c1 = new Label(); c1 = formatLabel(Color.FromArgb(tbarT1.Value, tbarR1.Value, tbarG1.Value, tbarB1.Value), fromLeft, startSpot);
            startSpot += (int)(4.5 * vertSpace);
            c2 = new Label(); c2 = formatLabel(Color.FromArgb(tbarT2.Value, tbarR2.Value, tbarG2.Value, tbarB2.Value), fromLeft, startSpot);
            startSpot += (int)(4.5 * vertSpace);
            c3 = new Label(); c3 = formatLabel(Color.FromArgb(tbarT3.Value, tbarR3.Value, tbarG3.Value, tbarB3.Value), fromLeft, startSpot);

            ccontrols.Controls.Add(tbarR1); ccontrols.Controls.Add(tbarG1); ccontrols.Controls.Add(tbarB1);
            ccontrols.Controls.Add(tbarR2); ccontrols.Controls.Add(tbarG2); ccontrols.Controls.Add(tbarB2);
            ccontrols.Controls.Add(tbarR3); ccontrols.Controls.Add(tbarG3); ccontrols.Controls.Add(tbarB3);

            ccontrols.Controls.Add(tbarT1); ccontrols.Controls.Add(tbarT2); ccontrols.Controls.Add(tbarT3);
            ccontrols.Controls.Add(c1); ccontrols.Controls.Add(c2); ccontrols.Controls.Add(c3);

            vertSpace = 36;
            startSpot = 500;
            fromLeft = fromLeft + 10;
            tbarNumPetals1 = new TrackBar(); tbarNumPetals1 = formatTBar(fromLeft, startSpot, 3, 60, 9, Color.LightSteelBlue);

            startSpot += vertSpace;
            tbarPetLen1 = new TrackBar(); tbarPetLen1 = formatTBar(fromLeft, startSpot, 200, 600, 400, Color.LightPink);

            startSpot += vertSpace;
            tbarBulgPerc1 = new TrackBar(); tbarBulgPerc1 = formatTBar(fromLeft, startSpot, 1, 99, 55, Color.LightCoral);

            startSpot += vertSpace;
            tbarBulgWid1 = new TrackBar(); tbarBulgWid1 = formatTBar(fromLeft, startSpot, 10, 200, 40, Color.LightSlateGray);

            startSpot += vertSpace + 10;
            cbShow2ndLayer = new CheckBox();
            cbShow2ndLayer.Top = startSpot;
            cbShow2ndLayer.Left = fromLeft;
            cbShow2ndLayer.Text = "Use Layer2 also";
            cbShow2ndLayer.Checked = true;
            cbShow2ndLayer.CheckStateChanged += new System.EventHandler(cbShow2ndLayer_CheckStateChanged);

            startSpot += (int)(vertSpace / 2);
            tbarNumPetals2 = new TrackBar(); tbarNumPetals2 = formatTBar(fromLeft, startSpot, 3, 60, 9, Color.LightSteelBlue);

            startSpot += vertSpace;
            tbarPetLen2 = new TrackBar(); tbarPetLen2 = formatTBar(fromLeft, startSpot, 1, 200, 60, Color.LightPink);

            startSpot += vertSpace;
            tbarBulgPerc2 = new TrackBar(); tbarBulgPerc2 = formatTBar(fromLeft, startSpot, 1, 99, 33, Color.LightCoral);

            startSpot += vertSpace;
            tbarBulgWid2 = new TrackBar(); tbarBulgWid2 = formatTBar(fromLeft, startSpot, 1, 100, 40, Color.LightSlateGray);
            ccontrols.Controls.Add(tbarNumPetals1);
            ccontrols.Controls.Add(tbarPetLen1);
            ccontrols.Controls.Add(tbarBulgPerc1);
            ccontrols.Controls.Add(tbarBulgWid1);

            ccontrols.Controls.Add(tbarNumPetals2);
            ccontrols.Controls.Add(tbarPetLen2);
            ccontrols.Controls.Add(tbarBulgPerc2);
            ccontrols.Controls.Add(tbarBulgWid2);


            ccontrols.Controls.Add(cbShow2ndLayer);

            int tempY = ccontrols.Top + ccontrols.Height;
            int tempYY = ccontrols.Top + ccontrols.Height;
            btnMake.Top = ccontrols.Top;
            btnMake.Height = ccontrols.Height;
            btnMake.Width = 70;
            btnMake.Left = 0;

            btn_MakeAllRandom.Left = btnMake.Left;
            btn_MakeAllRandom.Width = 70;
            btn_MakeAllRandom.Top = btnMake.Top + btnMake.Height - btn_MakeAllRandom.Height;

            btn_RandColor.Left = btnMake.Left;
            btn_RandColor.Width = 70;
            btn_RandColor.Top = btnMake.Top + btnMake.Height - btn_RandColor.Height - btn_MakeAllRandom.Height;

            labLisa.Text = "Put the first name of the world's most creative\n" +
                "flower programmer here to go into \"turbo-mode\".";
            labLisa.Width = 240;
            labLisa.Left = 75;
            labLisa.Top = ccontrols.Top + ccontrols.Height - 30;
            labLisa.Height = 24;

            txtTurbo.Left = ccontrols.Width - 50;
            txtTurbo.Width = 48;
            txtTurbo.Top = ccontrols.Top + ccontrols.Height - 30;

            labDets1 = new Label();
            labDets1.Top = tbarNumPetals1.Top;
            labDets1.Height = vertSpace * 4;
            labDets1.Left = tbarNumPetals1.Left + tbarNumPetals1.Width;
            labDets1.Text =
                "These 4 control" +
                "\ndetails of" +
                "\n**MAIN** layer:" +
                "\n\n(1)#OfPetals " +
                "\n\n(2)Petal Length" +
                "\n\n(3)Bulge Location" +
                "\n\n(4)Bulge Size";

            ccontrols.Controls.Add(labDets1);


            labDets2 = new Label();
            labDets2.Top = tbarNumPetals2.Top;
            labDets2.Height = vertSpace * 4;
            labDets2.Left = tbarNumPetals2.Left + tbarNumPetals2.Width;
            labDets2.Text =
                "These 4 control" +
                "\ndetails of" +
                "\n2ndary layer:" +
                "\n\n(1)#OfPetals " +
                "\n\n(2)Petal Length" +
                "\n\n(3)Bulge Location" +
                "\n\n(4)Bulge Size";

            ccontrols.Controls.Add(labDets2);

        }

        private void cbShow2ndLayer_CheckStateChanged(object sender, EventArgs e)
        {
            tbarNumPetals2.Visible = cbShow2ndLayer.Checked;
            tbarPetLen2.Visible = cbShow2ndLayer.Checked;
            tbarBulgPerc2.Visible = cbShow2ndLayer.Checked;
            tbarBulgWid2.Visible = cbShow2ndLayer.Checked;
            labDets2.Visible = cbShow2ndLayer.Checked;
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreForNow == false)
            {
                UpdateColors();
                if (txtTurbo.Text.ToUpper() == "LISA")
                    MakeAFlower();
            }
        }

        private void UpdateColors()
        {
            Color tempC1 = Color.FromArgb(tbarT1.Value, tbarR1.Value, tbarG1.Value, tbarB1.Value);
            Color tempC2 = Color.FromArgb(tbarT2.Value, tbarR2.Value, tbarG2.Value, tbarB2.Value);
            Color tempC3 = Color.FromArgb(tbarT3.Value, tbarR3.Value, tbarG3.Value, tbarB3.Value);

            c1.BackColor = tempC1; c2.BackColor = tempC2; c3.BackColor = tempC3;
            br1 = new SolidBrush(tempC1); br2 = new SolidBrush(tempC2); br3 = new SolidBrush(tempC3);
        }


        private TrackBar formatTBar(int left, int top, int min, int max, int value, Color color)
        {
            TrackBar tempTB = new TrackBar();
            tempTB.Top = top; tempTB.Left = left;
            tempTB.Minimum = min; tempTB.Maximum = max; tempTB.Value = value;
            tempTB.BackColor = color;
            tempTB.Height = 10; tempTB.Width = 180; //tempTB.LargeChange = 10;
            tempTB.ValueChanged += new System.EventHandler(TrackBar1_ValueChanged);
            return tempTB;
        }
        private Label formatLabel(Color color, int left, int top)
        {
            int vertSpace = 36;
            Label tempLab = new Label();
            tempLab.BackColor = color;
            tempLab.Left = left; tempLab.Top = top;
            tempLab.Height = (int)(vertSpace * 4.5);
            tempLab.Width = 240;
            return tempLab;
        }


        private void MakeAFlower()
        {
            ccanvas.Refresh();
            UpdateColors();

            int midPtY = (int)(ccanvas.Height / 2);
            //int midPtX = (int)(ccanvas.Width / 2);
            int midPtX = (int)(ccanvas.Height / 2); //forcing location
            ctr = new Point(midPtX, midPtY);

            g = ccanvas.CreateGraphics();
            path1 = new GraphicsPath(); path2 = new GraphicsPath(); path3 = new GraphicsPath();

            //Important Comment For the following:
            //paths      //numberOfPetals     //offsetFromNoon 
            //lenOfPetal     //bulgLocAsPercent       //bulgSize
            //Example that WORKS GREAT:
            //Layer anotherLayer = new Layer(path1, path2, path3, ctr, 44, .3, 100, .7, 100);

            Layer nextLayer = new Layer(ctr,
                tbarNumPetals1.Value,
                0,
                tbarPetLen1.Value,
                ((double)(tbarBulgPerc1.Value) / 100.0),
                tbarBulgWid1.Value);
            nextLayer.DrawLayer(path1, path2, path3);

            Layer nextLayer2 = new Layer(ctr,
                tbarNumPetals2.Value,
                0,
                tbarPetLen2.Value,
                ((double)(tbarBulgPerc2.Value) / 100.0),
                tbarBulgWid2.Value);

            if (cbShow2ndLayer.Checked == true)
                nextLayer2.DrawLayer(path1, path2, path3);

            g.FillPath(br1, path1); g.FillPath(br2, path2); g.FillPath(br3, path3);
        }
        private void btnMake_Click(object sender, EventArgs e)
        {
            MakeAFlower();
        }

        public void ccanvas_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

         * 
         * *********CLASS LAYER*************
         * using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace FlowerWithClasses
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



         * 
         * **********CLASS PETAL
         * 
         * 
         * 
         * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FlowerWithClasses
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

         * 
         * 
         * 
         * */
    }
}