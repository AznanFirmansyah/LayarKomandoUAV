namespace MissionPlanner.Controls
{
    partial class trigerkamera
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
            this.kamera1But = new MissionPlanner.Controls.MyButton();
            this.labelKameraAktif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kamera1But
            // 
            this.kamera1But.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kamera1But.Location = new System.Drawing.Point(4, 4);
            this.kamera1But.Name = "kamera1But";
            this.kamera1But.Size = new System.Drawing.Size(120, 35);
            this.kamera1But.TabIndex = 4;
            this.kamera1But.Text = "Ganti Kamera";
            this.kamera1But.UseVisualStyleBackColor = true;
            this.kamera1But.Click += new System.EventHandler(this.kamera1But_Click);
            // 
            // labelKameraAktif
            // 
            this.labelKameraAktif.AutoSize = true;
            this.labelKameraAktif.Location = new System.Drawing.Point(155, 15);
            this.labelKameraAktif.Name = "labelKameraAktif";
            this.labelKameraAktif.Size = new System.Drawing.Size(77, 13);
            this.labelKameraAktif.TabIndex = 5;
            this.labelKameraAktif.Text = "Kamera Malam";
            // 
            // trigerkamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelKameraAktif);
            this.Controls.Add(this.kamera1But);
            this.Name = "trigerkamera";
            this.Size = new System.Drawing.Size(258, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton kamera1But;
        private System.Windows.Forms.Label labelKameraAktif;
    }
}
