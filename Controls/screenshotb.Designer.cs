namespace MissionPlanner.Controls
{
    partial class screenshotb
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Location = new System.Drawing.Point(3, 3);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(120, 35);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "Screenshot";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // screenshotb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myButton1);
            this.Name = "screenshotb";
            this.Size = new System.Drawing.Size(127, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton myButton1;
    }
}
