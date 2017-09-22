using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using log4net;
using MissionPlanner.Comms;
using MissionPlanner.Controls;
using MissionPlanner.Log;
using MissionPlanner.Utilities;
using SerialPort = MissionPlanner.Comms.SerialPort;

namespace MissionPlanner.GCSViews
{
    public partial class Terminal : MyUserControl
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        internal static ICommsSerial comPort;
        public static bool threadrun;
        private readonly List<string> cmdHistory = new List<string>();
        private readonly object thisLock = new object();
        private int history;
        private bool inlogview;
        private int inputStartPos;
        DateTime lastsend = DateTime.MinValue;

        public Terminal()
        {
            InitializeComponent();
        }

        

        private void ConvertToMSBut_Click(object sender, EventArgs e)
        {
            double coord = 0;

            coord = double.Parse(GeoDecimalTxt.Text);

            int sec = (int)Math.Round(coord * 3600);
            int deg = sec / 3600;
            sec = Math.Abs(sec % 3600);
            int min = sec / 60;
            sec %= 60;
            string tipeLat;
            tipeLat = deg < 0 ? "S" : "N";

            string mySec = sec.ToString();
            string myDeg = deg.ToString();
            string myMin = min.ToString();

            GeoMStxt.Text = myDeg + " ° " +  myMin + " ' " + mySec + "''" +" "+ tipeLat;
        }

        private void ConvertMSLonBut_Click(object sender, EventArgs e)
        {
            double coordlon = 0;

            coordlon = double.Parse(GeoDecimalLontxt.Text);

            int sec = (int)Math.Round(coordlon * 3600);
            int deg = sec / 3600;
            sec = Math.Abs(sec % 3600);
            int min = sec / 60;
            sec %= 60;
            string tipeLat;
            tipeLat = deg < 0 ? "W" : "E";

            string mySec = sec.ToString();
            string myDeg = deg.ToString();
            string myMin = min.ToString();

            GeoMSLontxt.Text = myDeg + " ° " + myMin + " ' " + mySec + "''" + " " + tipeLat;
        }

        private void DecToDms_Click(object sender, EventArgs e)
        {
            double coordDeg = 0;
            double coordMin = 0;
            double coordSec = 0;
            

            coordDeg = double.Parse(DegTxt.Text);
            coordMin = double.Parse(MinTxt.Text);
            coordSec = double.Parse(SecTxt.Text);

            double coordDecimal;
            coordDecimal = coordDeg > 0 ? coordDeg + (coordMin / 60) + (coordSec / 3600): coordDeg - (coordMin / 60) - (coordSec / 3600);

            DecimalTxt.Text = coordDecimal.ToString();
        }
    }
}
      
