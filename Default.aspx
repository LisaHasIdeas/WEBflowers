<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFlowerJuly1._Default" %>






<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table width="100%">

        <tr>
            <td width="20%">
                <h1>
                    <i>Lisa
                    <br />
                        Flowers</i>
                </h1>
            </td>
            <td>&nbsp;&nbsp; </td>
            <td width="30%">
                <div class="slidecontainer">
                    How many petals do you want the flower to have?
                    
                    <input type="range" min="3" max="60" value="9" class="slider" id="myRange1" /><br />
                    How big do you want the flower to be?                   
                    <input type="range" min="4" max="330" value="200" class="slider" id="myRange2" /><br />
                </div>
            </td>
            <td>&nbsp;&nbsp;&nbsp; </td>
            <td width="30%">
                <div class="slidecontainer">
                    How much bulge do you want each petal to have?                 
                    <input type="range" min="1" max="100" value="40" class="slider" id="myRange3" /><br />
                    Where along each petal should it bulge?  
                    <input type="range" min="1" max="99" value="50" class="slider" id="myRange4" /><br />

                </div>


            </td>


        </tr>
    </table>

    <table width="100%">
        <tr>

            <td>
                <span>Adjust for shape, size and colors (using SLIDERS), then...</span>
                <asp:Button ID="btnShowFlower" runat="server" Text="Click to show your flower" OnClick="btnShowFlower_Click" Font-Size="Medium" BackColor="#99CC00" Font-Bold="True" Font-Italic="True" />

            </td>
            <td></td>
        </tr>
    </table>
    <table width="100%">
        <tr>
            <td width="20%">




                <div id="DivColor1">
                    <div class="slidecontainer">
                        Color-1:
                    <input type="range" min="0" max="255" value="125" class="slider" id="myRangeRed1" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeGreen1" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeBlue1" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeTrans1" style="transform: rotateY(180deg);" /><br />
                    </div>
                </div>

                <div id="DivColor2">
                    <div class="slidecontainer">
                        Color-2:                   
                    <input type="range" min="0" max="255" value="125" class="slider" id="myRangeRed2" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeGreen2" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeBlue2" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeTrans2" style="transform: rotateY(180deg);" /><br />
                    </div>
                </div>

                <div id="DivColor3">

                    <div class="slidecontainer">
                        Color-3:                
                    <input type="range" min="0" max="255" value="125" class="slider" id="myRangeRed3" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeGreen3" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeBlue3" /><br />
                        <input type="range" min="0" max="255" value="125" class="slider" id="myRangeTrans3" style="transform: rotateY(180deg);" /><br />
                    </div>
                </div>

                <br />


            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td border="1">
                <asp:Image ID="Image1" runat="server" Height="600px" Width="600px" />

            </td>
    </table>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <span style="visibility: hidden">Ignore the below:<br />
        <asp:Label ID="Label5" runat="server" Text="!IsPostback=yellow ; IsPostBack=green"></asp:Label>
        <br />

        <asp:Label ID="Label1" runat="server">Status</asp:Label>
        <br />

        <span id="infoSPAN">this is the INFO span</span>
        <br />
        <span id="demo1">this is the demo span</span>
        <br />
        <span id="demo2">this is the 2nd demo span</span>
    </span>
    <br />











    <script>
        var transPadding = .3;
        var outputINFO = document.getElementById("infoSPAN");
        var demo11 = document.getElementById("demo1");

        var slider1 = document.getElementById("myRange1");
        var slider2 = document.getElementById("myRange2");
        var slider3 = document.getElementById("myRange3");
        var slider4 = document.getElementById("myRange4");
        slider1.value = getCookie("MyCookie1");
        slider2.value = getCookie("MyCookie2");
        slider3.value = getCookie("MyCookie3");
        slider4.value = getCookie("MyCookie4");


        var sliderRed1 = document.getElementById("myRangeRed1");
        var sliderGreen1 = document.getElementById("myRangeGreen1");
        var sliderBlue1 = document.getElementById("myRangeBlue1");
        var sliderTrans1 = document.getElementById("myRangeTrans1");
        sliderRed1.value = getCookie("MyCookieRed1");
        sliderGreen1.value = getCookie("MyCookieGreen1");
        sliderBlue1.value = getCookie("MyCookieBlue1");
        sliderTrans1.value = getCookie("MyCookieTrans1");

        var sliderRed2 = document.getElementById("myRangeRed2");
        var sliderGreen2 = document.getElementById("myRangeGreen2");
        var sliderBlue2 = document.getElementById("myRangeBlue2");
        var sliderTrans2 = document.getElementById("myRangeTrans2");
        sliderRed2.value = getCookie("MyCookieRed2");
        sliderGreen2.value = getCookie("MyCookieGreen2");
        sliderBlue2.value = getCookie("MyCookieBlue2");
        sliderTrans2.value = getCookie("MyCookieTrans2");

        var sliderRed3 = document.getElementById("myRangeRed3");
        var sliderGreen3 = document.getElementById("myRangeGreen3");
        var sliderBlue3 = document.getElementById("myRangeBlue3");
        var sliderTrans3 = document.getElementById("myRangeTrans3");
        sliderRed3.value = getCookie("MyCookieRed3");
        sliderGreen3.value = getCookie("MyCookieGreen3");
        sliderBlue3.value = getCookie("MyCookieBlue3");
        sliderTrans3.value = getCookie("MyCookieTrans3");

        changeBackgroundDiv(sliderRed1, sliderGreen1, sliderBlue1, sliderTrans1, "DivColor1");
        changeBackgroundDiv(sliderRed2, sliderGreen2, sliderBlue2, sliderTrans2, "DivColor2");
        changeBackgroundDiv(sliderRed3, sliderGreen3, sliderBlue3, sliderTrans3, "DivColor3");




        slider1.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookie1=" + cookievalue;

        }

        slider2.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookie2=" + cookievalue;

        }

        slider3.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookie3=" + cookievalue;
        }

        slider4.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookie4=" + cookievalue;

        }

        var transPadding = .3;

        sliderRed1.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieRed1=" + cookievalue;
            changeBackgroundDiv(sliderRed1, sliderGreen1, sliderBlue1, sliderTrans1, "DivColor1");
        }
        sliderGreen1.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieGreen1=" + cookievalue;
            changeBackgroundDiv(sliderRed1, sliderGreen1, sliderBlue1, sliderTrans1, "DivColor1");
        }
        sliderBlue1.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieBlue1=" + cookievalue;
            changeBackgroundDiv(sliderRed1, sliderGreen1, sliderBlue1, sliderTrans1, "DivColor1");
        }
        sliderTrans1.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieTrans1=" + cookievalue;
            changeBackgroundDiv(sliderRed1, sliderGreen1, sliderBlue1, sliderTrans1, "DivColor1");
        }

        function changeBackgroundDiv(r, g, b, t, divv) {
            var tempR = parseInt(r.value);
            var tempG = parseInt(g.value);
            var tempB = parseInt(b.value);
            var tempT = parseInt(t.value) / 255;
            document.getElementById(divv).style.background = rgbToHex(tempR, tempG, tempB);;
            document.getElementById(divv).style.opacity = transPadding + tempT;;
        }

        sliderRed2.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieRed2=" + cookievalue;
            changeBackgroundDiv(sliderRed2, sliderGreen2, sliderBlue2, sliderTrans2, "DivColor2");
        }
        sliderGreen2.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieGreen2=" + cookievalue;
            changeBackgroundDiv(sliderRed2, sliderGreen2, sliderBlue2, sliderTrans2, "DivColor2");
        }
        sliderBlue2.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieBlue2=" + cookievalue;
            changeBackgroundDiv(sliderRed2, sliderGreen2, sliderBlue2, sliderTrans2, "DivColor2");
        }
        sliderTrans2.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieTrans2=" + cookievalue;
            changeBackgroundDiv(sliderRed2, sliderGreen2, sliderBlue2, sliderTrans2, "DivColor2");
        }
        sliderRed3.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieRed3=" + cookievalue;
            changeBackgroundDiv(sliderRed3, sliderGreen3, sliderBlue3, sliderTrans3, "DivColor3");
        }
        sliderGreen3.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieGreen3=" + cookievalue;
            changeBackgroundDiv(sliderRed3, sliderGreen3, sliderBlue3, sliderTrans3, "DivColor3");
        }
        sliderBlue3.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieBlue3=" + cookievalue;
            changeBackgroundDiv(sliderRed3, sliderGreen3, sliderBlue3, sliderTrans3, "DivColor3");
        }
        sliderTrans3.oninput = function () {
            cookievalue = this.value + ";"; document.cookie = "MyCookieTrans3=" + cookievalue;
            changeBackgroundDiv(sliderRed3, sliderGreen3, sliderBlue3, sliderTrans3, "DivColor3");
        }

        function showTextofValues() {
            //outputINFO.innerHTML = "relative height=" + slider1.value + " percent.  \nRed=" + sliderRed1.value + "; Green=" + sliderGreen1.value + " and Blue=" + sliderBlue1.value + ".";
        }


        function componentToHex(c) {
            var hex = c.toString(16);
            return hex.length == 1 ? "0" + hex : hex;
        }

        function rgbToHex(r, g, b) {
            return "#" + componentToHex(r) + componentToHex(g) + componentToHex(b);
        }

        function getCookie(cname) {
            var name = cname + "=";
            var decodedCookie = decodeURIComponent(document.cookie);
            var ca = decodedCookie.split(';');
            for (var i = 0; i < ca.length; i++) {
                var c = ca[i];
                while (c.charAt(0) == ' ') {
                    c = c.substring(1);
                }
                if (c.indexOf(name) == 0) {
                    return c.substring(name.length, c.length);
                }
            }
            return "";
        }

    </script>









    <style>
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
</asp:Content>







