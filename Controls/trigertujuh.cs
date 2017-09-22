using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MissionPlanner.Utilities;

namespace MissionPlanner.Controls
{
    public partial class trigertujuh : UserControl
    {
        static int servo = 7;
        private Timer _timer;
        public int thisservo { get; set; }

        public trigertujuh()
        {
            InitializeComponent();

            thisservo = servo;

            loadSettings();
        }

        void loadSettings()
        {
            string desc = Settings.Instance["Servo" + thisservo + "_desc"];
            string low = Settings.Instance["Servo" + thisservo + "_low"];
            string high = Settings.Instance["Servo" + thisservo + "_high"];

            string highdesc = Settings.Instance["Servo" + thisservo + "_highdesc"];
            string lowdesc = Settings.Instance["Servo" + thisservo + "_lowdesc"];

            if (!string.IsNullOrEmpty(highdesc))
            {
                trigertujuhbut.Text = highdesc;
            }

            if (!string.IsNullOrEmpty(lowdesc))
            {
                trigertujuhbut.Text = lowdesc;
            }
        }

        //private void trigertujuhbut_Click(object sender, EventArgs e)
        //{

        //}

        private void trigertujuhbut_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1100, 0, 0,
            //        0, 0, 0);
            //}
            //catch (Exception ex)
            //{
            //    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
            //}
            try
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1900, 0, 0,
                    0, 0, 0);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
            }

            _timer = new Timer();
            _timer.Interval = 300;
            _timer.Tick += Do_Something;
            _timer.Start();
        }

        private void Do_Something(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1500, 0, 0,
                    0, 0, 0);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
            }

            _timer.Stop();
            _timer = null;
        }

        //private void trigertujuhbut_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    try
        //    {
        //        MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1900, 0, 0,
        //            0, 0, 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
        //    }
        //}
    }
}
