namespace MissionPlanner.Controls
{
    partial class servooptioncam
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
            this.BUT_Low = new MissionPlanner.Controls.MyButton();
            this.labelParasutStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUT_Low
            // 
            this.BUT_Low.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_Low.Location = new System.Drawing.Point(1, 3);
            this.BUT_Low.Name = "BUT_Low";
            this.BUT_Low.Size = new System.Drawing.Size(120, 35);
            this.BUT_Low.TabIndex = 3;
            this.BUT_Low.Text = "Kunci Parasut";
            this.BUT_Low.UseVisualStyleBackColor = true;
            this.BUT_Low.Click += new System.EventHandler(this.BUT_Low_Click);
            // 
            // labelParasutStatus
            // 
            this.labelParasutStatus.AutoSize = true;
            this.labelParasutStatus.Location = new System.Drawing.Point(148, 14);
            this.labelParasutStatus.Name = "labelParasutStatus";
            this.labelParasutStatus.Size = new System.Drawing.Size(86, 13);
            this.labelParasutStatus.TabIndex = 4;
            this.labelParasutStatus.Text = "Parasut Terbuka";
            // 
            // servooptioncam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelParasutStatus);
            this.Controls.Add(this.BUT_Low);
            this.Name = "servooptioncam";
            this.Size = new System.Drawing.Size(252, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MyButton BUT_Low;
        private System.Windows.Forms.Label labelParasutStatus;
    }
}
