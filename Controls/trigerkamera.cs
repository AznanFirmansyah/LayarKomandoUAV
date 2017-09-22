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
    public partial class trigerkamera : UserControl
    {
        static int servo = 8;

        public int thisservo { get; set; }

        public trigerkamera()
        {
            InitializeComponent();
            //radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            //radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            thisservo = servo;
            loadSettings();

        }

        private void kamera1But_Click(object sender, EventArgs e)
        {
            float pwmKameraSekarang = MainV2.comPort.MAV.cs.ch8out;
            if (pwmKameraSekarang < 1300)
            {
                try
                {
                    MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1900, 0, 0,
                        0, 0, 0);
                    labelKameraAktif.Text = "Kamera Malam";
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
            else
            {
                try
                {
                    MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1100, 0, 0,
                        0, 0, 0);
                    labelKameraAktif.Text = "Kamera Siang";
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
                }
            }
            
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
                kamera1But.Text = highdesc;
            }

        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e) {
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //}

        //private void radioButtons_CheckedChanged(object sender, EventArgs e)
        //{
        //    RadioButton radioButton = sender as RadioButton;

        //    //if (radioButton1.Checked)
        //    //{
        //    //    try
        //    //    {
        //    //        MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1900, 0, 0,
        //    //            0, 0, 0);
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
        //    //    }
        //    //}
        //    //else if (radioButton2.Checked)
        //    //{
        //    //    try
        //    //    {
        //    //        MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, thisservo, 1100, 0, 0,
        //    //            0, 0, 0);
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
        //    //    }
        //    //}

        //}
    }
}
