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
    public partial class servooptioncam: UserControl
    {

        static int servo = 5;

        public int thisservo { get; set; }

        public servooptioncam()
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

            
            if (!string.IsNullOrEmpty(lowdesc))
            {
                BUT_Low.Text = lowdesc;
            }
        }

        private void BUT_Low_Click(object sender, EventArgs e) //LOCK
        {
            float pwmSekarang = MainV2.comPort.MAV.cs.ch5out;
            if (pwmSekarang < 1300)
            {
                labelParasutStatus.Text = "Parasut Terkunci";
                BUT_Low.Text = "Buka Parasut";
                try
                {
                    MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1700, 0, 0,
                        0, 0, 0);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
            else
            {
                labelParasutStatus.Text = "Parasut Terbuka";
                BUT_Low.Text = "Kunci Parasut";
                try
                {
                    MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1100, 0, 0,
                        0, 0, 0);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
        }
        /*
        private void BUT_High_Click(object sender, EventArgs e) //UNLOCK
        {


            try
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1100, 0, 0,
                    0, 0, 0);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
            }
        }
        */
        //private void ButHigh_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    try
        //    {
        //        MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1500, 0, 0,
        //            0, 0, 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
        //    }
        //}

        //private void ButHigh_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        //private void ButLow_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    try
        //    {
        //        MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1500, 0, 0,
        //            0, 0, 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
        //    }
        //}

        //private void ButLow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    try
        //    {
        //        MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1100, 0, 0,
        //            0, 0, 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
        //    }
        //}


        //private void BUT_Repeat_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1500, 0, 0,
        //            0, 0, 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
        //    }
        //}

    }
}
