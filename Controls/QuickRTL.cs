using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class QuickRTL : UserControl
    {
        public QuickRTL()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ((Button)sender).Enabled = false;
                MainV2.comPort.setMode("RTL");
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }
            ((Button)sender).Enabled = true;
        }
    }
}
