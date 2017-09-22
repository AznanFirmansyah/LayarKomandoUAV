namespace MissionPlanner.GCSViews
{
    partial class Terminal
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.ConvertToMSBut = new MissionPlanner.Controls.MyButton();
            this.GeoDecimalTxt = new System.Windows.Forms.TextBox();
            this.myLabel1 = new MissionPlanner.Controls.MyLabel();
            this.GeoMStxt = new System.Windows.Forms.TextBox();
            this.GeoDecimalLontxt = new System.Windows.Forms.TextBox();
            this.ConvertMSLonBut = new MissionPlanner.Controls.MyButton();
            this.GeoMSLontxt = new System.Windows.Forms.TextBox();
            this.DegTxt = new System.Windows.Forms.TextBox();
            this.MinTxt = new System.Windows.Forms.TextBox();
            this.SecTxt = new System.Windows.Forms.TextBox();
            this.DecimalTxt = new System.Windows.Forms.TextBox();
            this.DecToDms = new MissionPlanner.Controls.MyButton();
            this.myLabel2 = new MissionPlanner.Controls.MyLabel();
            this.myLabel3 = new MissionPlanner.Controls.MyLabel();
            this.myLabel4 = new MissionPlanner.Controls.MyLabel();
            this.myLabel5 = new MissionPlanner.Controls.MyLabel();
            this.myLabel6 = new MissionPlanner.Controls.MyLabel();
            this.myLabel7 = new MissionPlanner.Controls.MyLabel();
            this.SuspendLayout();
            // 
            // ConvertToMSBut
            // 
            resources.ApplyResources(this.ConvertToMSBut, "ConvertToMSBut");
            this.ConvertToMSBut.Name = "ConvertToMSBut";
            this.ConvertToMSBut.UseVisualStyleBackColor = true;
            this.ConvertToMSBut.Click += new System.EventHandler(this.ConvertToMSBut_Click);
            // 
            // GeoDecimalTxt
            // 
            resources.ApplyResources(this.GeoDecimalTxt, "GeoDecimalTxt");
            this.GeoDecimalTxt.Name = "GeoDecimalTxt";
            // 
            // myLabel1
            // 
            resources.ApplyResources(this.myLabel1, "myLabel1");
            this.myLabel1.Name = "myLabel1";
            this.myLabel1.resize = false;
            // 
            // GeoMStxt
            // 
            resources.ApplyResources(this.GeoMStxt, "GeoMStxt");
            this.GeoMStxt.Name = "GeoMStxt";
            // 
            // GeoDecimalLontxt
            // 
            resources.ApplyResources(this.GeoDecimalLontxt, "GeoDecimalLontxt");
            this.GeoDecimalLontxt.Name = "GeoDecimalLontxt";
            // 
            // ConvertMSLonBut
            // 
            resources.ApplyResources(this.ConvertMSLonBut, "ConvertMSLonBut");
            this.ConvertMSLonBut.Name = "ConvertMSLonBut";
            this.ConvertMSLonBut.UseVisualStyleBackColor = true;
            this.ConvertMSLonBut.Click += new System.EventHandler(this.ConvertMSLonBut_Click);
            // 
            // GeoMSLontxt
            // 
            resources.ApplyResources(this.GeoMSLontxt, "GeoMSLontxt");
            this.GeoMSLontxt.Name = "GeoMSLontxt";
            // 
            // DegTxt
            // 
            resources.ApplyResources(this.DegTxt, "DegTxt");
            this.DegTxt.Name = "DegTxt";
            // 
            // MinTxt
            // 
            resources.ApplyResources(this.MinTxt, "MinTxt");
            this.MinTxt.Name = "MinTxt";
            // 
            // SecTxt
            // 
            resources.ApplyResources(this.SecTxt, "SecTxt");
            this.SecTxt.Name = "SecTxt";
            // 
            // DecimalTxt
            // 
            resources.ApplyResources(this.DecimalTxt, "DecimalTxt");
            this.DecimalTxt.Name = "DecimalTxt";
            // 
            // DecToDms
            // 
            resources.ApplyResources(this.DecToDms, "DecToDms");
            this.DecToDms.Name = "DecToDms";
            this.DecToDms.UseVisualStyleBackColor = true;
            this.DecToDms.Click += new System.EventHandler(this.DecToDms_Click);
            // 
            // myLabel2
            // 
            resources.ApplyResources(this.myLabel2, "myLabel2");
            this.myLabel2.Name = "myLabel2";
            this.myLabel2.resize = false;
            // 
            // myLabel3
            // 
            resources.ApplyResources(this.myLabel3, "myLabel3");
            this.myLabel3.Name = "myLabel3";
            this.myLabel3.resize = false;
            // 
            // myLabel4
            // 
            resources.ApplyResources(this.myLabel4, "myLabel4");
            this.myLabel4.Name = "myLabel4";
            this.myLabel4.resize = false;
            // 
            // myLabel5
            // 
            resources.ApplyResources(this.myLabel5, "myLabel5");
            this.myLabel5.Name = "myLabel5";
            this.myLabel5.resize = false;
            // 
            // myLabel6
            // 
            resources.ApplyResources(this.myLabel6, "myLabel6");
            this.myLabel6.Name = "myLabel6";
            this.myLabel6.resize = false;
            // 
            // myLabel7
            // 
            resources.ApplyResources(this.myLabel7, "myLabel7");
            this.myLabel7.Name = "myLabel7";
            this.myLabel7.resize = false;
            // 
            // Terminal
            // 
            this.Controls.Add(this.myLabel7);
            this.Controls.Add(this.myLabel6);
            this.Controls.Add(this.myLabel5);
            this.Controls.Add(this.myLabel4);
            this.Controls.Add(this.myLabel3);
            this.Controls.Add(this.myLabel2);
            this.Controls.Add(this.DecToDms);
            this.Controls.Add(this.DecimalTxt);
            this.Controls.Add(this.SecTxt);
            this.Controls.Add(this.MinTxt);
            this.Controls.Add(this.DegTxt);
            this.Controls.Add(this.GeoMSLontxt);
            this.Controls.Add(this.ConvertMSLonBut);
            this.Controls.Add(this.GeoDecimalLontxt);
            this.Controls.Add(this.GeoMStxt);
            this.Controls.Add(this.myLabel1);
            this.Controls.Add(this.GeoDecimalTxt);
            this.Controls.Add(this.ConvertToMSBut);
            this.Name = "Terminal";
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton ConvertToMSBut;
        private System.Windows.Forms.TextBox GeoDecimalTxt;
        private Controls.MyLabel myLabel1;
        private System.Windows.Forms.TextBox GeoMStxt;
        private System.Windows.Forms.TextBox GeoDecimalLontxt;
        private Controls.MyButton ConvertMSLonBut;
        private System.Windows.Forms.TextBox GeoMSLontxt;
        private System.Windows.Forms.TextBox DegTxt;
        private System.Windows.Forms.TextBox MinTxt;
        private System.Windows.Forms.TextBox SecTxt;
        private System.Windows.Forms.TextBox DecimalTxt;
        private Controls.MyButton DecToDms;
        private Controls.MyLabel myLabel2;
        private Controls.MyLabel myLabel3;
        private Controls.MyLabel myLabel4;
        private Controls.MyLabel myLabel5;
        private Controls.MyLabel myLabel6;
        private Controls.MyLabel myLabel7;
    }
}
