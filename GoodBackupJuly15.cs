using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFlowerJuly1
{
    public class GoodBackupJuly15
    {
        /**
         * 
         * using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using Brush = System.Drawing.Brush;
//using Brushes = System.Drawing.Brushes;
//using Color = System.Drawing.Color;
//using Pen = System.Drawing.Pen;

namespace WebFlowerJuly1
{
    public partial class _Default : Page
    {
        Graphics g; GraphicsPath path1, path2, path3; Brush br1, br2, br3;

        System.Drawing.Color c1, c2, c3;
        Point ctr;

        Boolean ignoreForNow = false;

        Random Ran = new Random();

        int temp1, temp2, temp3, temp4;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label5.BackColor = Color.PaleGoldenrod;
                String imagepath = "MyImages/dog.jpg"; Image1.ImageUrl = "~/" + imagepath;
                HttpCookie myCookieobj;

                myCookieobj = new HttpCookie("MyCookie1"); myCookieobj.Value = "9"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookie2"); myCookieobj.Value = "330"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookie3"); myCookieobj.Value = "40"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookie4"); myCookieobj.Value = "50"; Response.Cookies.Add(myCookieobj);


                myCookieobj = new HttpCookie("MyCookieRed1"); myCookieobj.Value = "205"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieGreen1"); myCookieobj.Value = "100"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieBlue1"); myCookieobj.Value = "100"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieTrans1"); myCookieobj.Value = "200"; Response.Cookies.Add(myCookieobj);
                c1 = Color.FromArgb(200, 205, 100, 100);

                myCookieobj = new HttpCookie("MyCookieRed2"); myCookieobj.Value = "100"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieGreen2"); myCookieobj.Value = "205"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieBlue2"); myCookieobj.Value = "100"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieTrans2"); myCookieobj.Value = "200"; Response.Cookies.Add(myCookieobj);
                c2 = Color.FromArgb(200, 100, 205, 100);

                myCookieobj = new HttpCookie("MyCookieRed3"); myCookieobj.Value = "100"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieGreen3"); myCookieobj.Value = "100"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieBlue3"); myCookieobj.Value = "205"; Response.Cookies.Add(myCookieobj);
                myCookieobj = new HttpCookie("MyCookieTrans3"); myCookieobj.Value = "200"; Response.Cookies.Add(myCookieobj);
                c3 = Color.FromArgb(200, 100, 100, 205);

                //document.getElementById("DivColor1").style.background = c3;///zzz

                //var tempR = (int)MyCookieRed1.value;
                //var tempG = parseInt(sliderGreen1.value);
                //var tempB = parseInt(sliderBlue1.value);
                //document.getElementById("DivColor1").style.background = rgbToHex(tempR, tempG, tempB); ;

                //var tempR = parseInt(sliderRed2.value);
                //var tempG = parseInt(sliderGreen2.value);
                //var tempB = parseInt(sliderBlue2.value);
                //document.getElementById("DivColor2").style.background = rgbToHex(tempR, tempG, tempB); ;

                //var tempR = parseInt(sliderRed3.value);
                //var tempG = parseInt(sliderGreen3.value);
                //var tempB = parseInt(sliderBlue3.value);
                //document.getElementById("DivColor3").style.background = rgbToHex(tempR, tempG, tempB); ;


            }

            if (IsPostBack)
            {
                Label5.BackColor = Color.ForestGreen;
            }


        }

        protected void btnShowFlower_Click(object sender, EventArgs e)
        {
            DoMainWork();

        }


        private void DoMainWork()
        {
            //Image3.ImageUrl = "~/MyImages/dog.jpg"; //WORKS GREAT!!!!
            Pen whitePen = new Pen(Color.White, 113);

            HttpCookie varCookie1 = Request.Cookies["MyCookie1"];
            HttpCookie varCookie2 = Request.Cookies["MyCookie2"];
            HttpCookie varCookie3 = Request.Cookies["MyCookie3"];
            HttpCookie varCookie4 = Request.Cookies["MyCookie4"];

            HttpCookie varCookieRed1 = Request.Cookies["MyCookieRed1"];
            HttpCookie varCookieGreen1 = Request.Cookies["MyCookieGreen1"];
            HttpCookie varCookieBlue1 = Request.Cookies["MyCookieBlue1"];
            HttpCookie varCookieTrans1 = Request.Cookies["MyCookieTrans1"];

            HttpCookie varCookieRed2 = Request.Cookies["MyCookieRed2"];
            HttpCookie varCookieGreen2 = Request.Cookies["MyCookieGreen2"];
            HttpCookie varCookieBlue2 = Request.Cookies["MyCookieBlue2"];
            HttpCookie varCookieTrans2 = Request.Cookies["MyCookieTrans2"];

            HttpCookie varCookieRed3 = Request.Cookies["MyCookieRed3"];
            HttpCookie varCookieGreen3 = Request.Cookies["MyCookieGreen3"];
            HttpCookie varCookieBlue3 = Request.Cookies["MyCookieBlue3"];
            HttpCookie varCookieTrans3 = Request.Cookies["MyCookieTrans3"];


            temp1 = int.Parse(varCookie1.Value.ToString());
            temp2 = int.Parse(varCookie2.Value.ToString());
            temp3 = int.Parse(varCookie3.Value.ToString());
            temp4 = int.Parse(varCookie4.Value.ToString());

            int tempRed1 = int.Parse(varCookieRed1.Value.ToString());
            int tempGreen1 = int.Parse(varCookieGreen1.Value.ToString());
            int tempBlue1 = int.Parse(varCookieBlue1.Value.ToString());
            int tempTrans1 = int.Parse(varCookieTrans1.Value.ToString());

            int tempRed2 = int.Parse(varCookieRed2.Value.ToString());
            int tempGreen2 = int.Parse(varCookieGreen2.Value.ToString());
            int tempBlue2 = int.Parse(varCookieBlue2.Value.ToString());
            int tempTrans2 = int.Parse(varCookieTrans2.Value.ToString());

            int tempRed3 = int.Parse(varCookieRed3.Value.ToString());
            int tempGreen3 = int.Parse(varCookieGreen3.Value.ToString());
            int tempBlue3 = int.Parse(varCookieBlue3.Value.ToString());
            int tempTrans3 = int.Parse(varCookieTrans3.Value.ToString());

            using (MemoryStream ms = new MemoryStream())
            {
                // create the image 
                System.Drawing.Bitmap bitmapImage = new Bitmap(600, 600);
                using (Graphics g = Graphics.FromImage(bitmapImage))
                {
                    GraphicsPath path1 = new GraphicsPath();
                    GraphicsPath path2 = new GraphicsPath();
                    GraphicsPath path3 = new GraphicsPath();

                    System.Drawing.Brush br1 = new SolidBrush(Color.FromArgb(tempTrans1, tempRed1, tempGreen1, tempBlue1));
                    Brush br2 = new SolidBrush(Color.FromArgb(tempTrans2, tempRed2, tempGreen2, tempBlue2));
                    Brush br3 = new SolidBrush(Color.FromArgb(tempTrans3, tempRed3, tempGreen3, tempBlue3));

                    g.FillRectangle(Brushes.AliceBlue, 0, 0, 600, 600);

                    //MakeAFlower(); <<transfer below to this function eventually;
                    Point ctr = new Point(300, 300);

                    Layer nextLayer = new Layer(
                        ctr,
                        temp1,
                        0,
                        temp2,
                        ((double)(temp4) / 100.0),
                        temp3);
                    nextLayer.DrawLayer(path1, path2, path3);

                    g.FillPath(br1, path1);
                    g.FillPath(br2, path2);
                    g.FillPath(br3, path3);


                    //nextLayer.DrawLayer(path1, path2, path3);

                }
                // get a bytearray representation of the object 
                bitmapImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                Image1.ImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(ms.ToArray(), 0, ms.ToArray().Length);

                bitmapImage.Dispose();
                bitmapImage = null;


            }
            //https://www.youtube.com/watch?v=lKbtGPH2H80
        }

        private void btn_MakeAllRandom_Click(object sender, EventArgs e)
        {

            ignoreForNow = true;
            MakeColorsRandom();
            MakeRestRandom();
            ignoreForNow = false;


        }


        private void MakeAFlower()
        {

            ctr = new Point(600, 300);
            path1 = new GraphicsPath(); path2 = new GraphicsPath(); path3 = new GraphicsPath();

            //Important Comment For the following:
            //paths      //numberOfPetals     //offsetFromNoon 
            //lenOfPetal     //bulgLocAsPercent       //bulgSize
            //Example that WORKS GREAT:
            //Layer anotherLayer = new Layer(path1, path2, path3, ctr, 44, .3, 100, .7, 100);

            Layer nextLayer = new Layer(ctr,
                temp1,
                0,
                temp2,
                ((double)(temp4) / 100.0),
                temp3);
            nextLayer.DrawLayer(path1, path2, path3);

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            //createTBars();
            //MakeColorsRandom();


        }




        private void btn_RandColor_Click(object sender, EventArgs e)
        {
            MakeColorsRandom();
            //MakeRestRandom();
        }

        private void MakeColorsRandom()
        {
            ignoreForNow = true;
            //AdjustRandomly(tbarR1);
            //AdjustRandomly(tbarG1);
            //AdjustRandomly(tbarB1);
            //AdjustRandomly(tbarT1);

            //AdjustRandomly(tbarR2);
            //AdjustRandomly(tbarG2);
            //AdjustRandomly(tbarB2);
            //AdjustRandomly(tbarT2);

            //AdjustRandomly(tbarR3);
            //AdjustRandomly(tbarG3);
            //AdjustRandomly(tbarB3);
            //AdjustRandomly(tbarT3);
            ignoreForNow = false;
            UpdateColors();


            //if (txtTurbo.Text.ToUpper() == "LISA")
            MakeAFlower();

        }


        private void MakeRestRandom()
        {


            ignoreForNow = true;
            //AdjustRandomly(tbarNumPetals1);
            //AdjustRandomly(tbarPetLen1);
            //AdjustRandomly(tbarBulgPerc1);
            //AdjustRandomly(tbarBulgWid1);

            //AdjustRandomly(tbarNumPetals2);
            //AdjustRandomly(tbarPetLen2);
            //AdjustRandomly(tbarBulgPerc2);
            //AdjustRandomly(tbarBulgWid2);
            ignoreForNow = false;

            //UpdateColors();

            //if (txtTurbo.Text.ToUpper() == "LISA")
            MakeAFlower();

        }
        private void AdjustRandomly(Label x)
        {

            //x.Value = Ran.Next(x.Minimum, x.Maximum);
            //x = 40;
            //UpdateColors();

        }

        private void createTBars()
        {



        }

        private void cbShow2ndLayer_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void Label1_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreForNow == false)
            {
                UpdateColors();
                //if (txtTurbo.Text.ToUpper() == "LISA")
                MakeAFlower();
            }
        }

        private void UpdateColors()
        {
            //Color tempC1 = Color.FromArgb(tbarT1.Value, tbarR1.Value, tbarG1.Value, tbarB1.Value);
            //Color tempC2 = Color.FromArgb(tbarT2.Value, tbarR2.Value, tbarG2.Value, tbarB2.Value);
            //Color tempC3 = Color.FromArgb(tbarT3.Value, tbarR3.Value, tbarG3.Value, tbarB3.Value);

            //c1.BackColor = tempC1; c2.BackColor = tempC2; c3.BackColor = tempC3;
            //br1 = new SolidBrush(tempC1); br2 = new SolidBrush(tempC2); br3 = new SolidBrush(tempC3);
        }



        private Label formatTBar(int left, int top, int min, int max, int value, Color color)
        {
            Label tempTB = new Label();
            //tempTB.Top = top; tempTB.Left = left;
            //tempTB.Minimum = min; tempTB.Maximum = max; tempTB.Value = value;
            tempTB.BackColor = color;
            tempTB.Height = 10; tempTB.Width = 180; //tempTB.LargeChange = 10;
            //tempTB.ValueChanged += new System.EventHandler(Label1_ValueChanged);
            return tempTB;
        }
        private Label formatLabel(Color color, int left, int top)
        {
            int vertSpace = 36;
            Label tempLab = new Label();
            tempLab.BackColor = color;
            tempLab.Height = (int)(vertSpace * 4.5);
            tempLab.Width = 240;
            return tempLab;
        }


        //private void MakeAFlower()
        //{
        //    //this.Refresh();
        //    UpdateColors();

        //    //int midPtY = (int)(this.Height / 2);
        //    ////int midPtX = (int)(this.Width / 2);
        //    //int midPtX = (int)(this.Height / 2); //forcing location
        //    //ctr = new Point(midPtX, midPtY);

        //    //g = this.CreateGraphics();
        //    //path1 = new GraphicsPath(); path2 = new GraphicsPath(); path3 = new GraphicsPath();

        //    //Important Comment For the following:
        //    //paths      //numberOfPetals     //offsetFromNoon 
        //    //lenOfPetal     //bulgLocAsPercent       //bulgSize
        //    //Example that WORKS GREAT:
        //    //Layer anotherLayer = new Layer(path1, path2, path3, ctr, 44, .3, 100, .7, 100);

        //    //Layer nextLayer = new Layer(ctr,
        //    //    tbarNumPetals1.Value,
        //    //    0,
        //    //    tbarPetLen1.Value,
        //    //    ((double)(tbarBulgPerc1.Value) / 100.0),
        //    //    tbarBulgWid1.Value);
        //    //nextLayer.DrawLayer(path1, path2, path3);


        //    //if (cbShow2ndLayer.Checked == true)
        //    //    nextLayer2.DrawLayer(path1, path2, path3);

        //    //g.FillPath(br1, path1); g.FillPath(br2, path2); g.FillPath(br3, path3);
        //}
        private void btnMake_Click(object sender, EventArgs e)
        {
            MakeAFlower();
        }



    }

    /*
     * mylabel.Text = "Currently Logged User is" + (loggedUsername != null) ? loggedUsername : "Unknown Person";  
     * 
     * 
     * */

    }
}