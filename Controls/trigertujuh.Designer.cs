namespace MissionPlanner.Controls
{
    partial class trigertujuh
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
            this.trigertujuhbut = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // trigertujuhbut
            // 
            this.trigertujuhbut.Location = new System.Drawing.Point(6, 3);
            this.trigertujuhbut.Name = "trigertujuhbut";
            this.trigertujuhbut.Size = new System.Drawing.Size(120, 35);
            this.trigertujuhbut.TabIndex = 0;
            this.trigertujuhbut.Text = "Rekam Siang";
            this.trigertujuhbut.UseVisualStyleBackColor = true;
            this.trigertujuhbut.Click += new System.EventHandler(this.trigertujuhbut_Click);
            // 
            // trigertujuh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trigertujuhbut);
            this.Name = "trigertujuh";
            this.Size = new System.Drawing.Size(134, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton trigertujuhbut;
    }
}
