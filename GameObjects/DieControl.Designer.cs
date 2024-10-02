namespace InDeBanVanDeRing.GameObjects
{
    partial class DieControl
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
            this.diePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // diePictureBox
            // 
            this.diePictureBox.BackgroundImage = global::InDeBanVanDeRing.Properties.Resources.dieEye;
            this.diePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.diePictureBox.Location = new System.Drawing.Point(0, 0);
            this.diePictureBox.Name = "diePictureBox";
            this.diePictureBox.Size = new System.Drawing.Size(80, 80);
            this.diePictureBox.TabIndex = 0;
            this.diePictureBox.TabStop = false;
            this.diePictureBox.Click += new System.EventHandler(this.diePictureBox_Click);
            // 
            // DieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.diePictureBox);
            this.Name = "DieControl";
            this.Size = new System.Drawing.Size(80, 80);
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox diePictureBox;
    }
}
