namespace MissionPlanner.Controls
{
    partial class trigerenam
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
            this.trigerenambut = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // trigerenambut
            // 
            this.trigerenambut.Location = new System.Drawing.Point(3, 3);
            this.trigerenambut.Name = "trigerenambut";
            this.trigerenambut.Size = new System.Drawing.Size(120, 35);
            this.trigerenambut.TabIndex = 0;
            this.trigerenambut.Text = "Rekam Malam";
            this.trigerenambut.UseVisualStyleBackColor = true;
            this.trigerenambut.Click += new System.EventHandler(this.trigerenambut_Click);
            // 
            // trigerenam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trigerenambut);
            this.Name = "trigerenam";
            this.Size = new System.Drawing.Size(126, 42);
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton trigerenambut;
    }
}
