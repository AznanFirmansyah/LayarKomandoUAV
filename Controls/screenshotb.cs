using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class screenshotb : UserControl
    {
        public screenshotb()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            string datenow = DateTime.Now.ToString("dd-MM-yyyy");
            string path = @"ScreenShot\" + datenow;
            DirectoryInfo di = Directory.CreateDirectory(path);

            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width , Screen.PrimaryScreen.Bounds.Height );
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            String fileName = string.Format(path + @"\" + DateTime.Now.ToString("dd-MM-yyyy_hhmmss") + ".jpg");
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            bitmap.Save(fileName);
        }
    }
}
