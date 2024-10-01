namespace InDeBanVanDeRing.GameObjects
{
    partial class PlayerPawnControl
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
            this.pawnPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pawnPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pawnPictureBox
            // 
            this.pawnPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pawnPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pawnPictureBox.Location = new System.Drawing.Point(0, 0);
            this.pawnPictureBox.Name = "pawnPictureBox";
            this.pawnPictureBox.Size = new System.Drawing.Size(20, 25);
            this.pawnPictureBox.TabIndex = 0;
            this.pawnPictureBox.TabStop = false;
            // 
            // PlayerPawnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pawnPictureBox);
            this.Name = "PlayerPawnControl";
            this.Size = new System.Drawing.Size(20, 25);
            ((System.ComponentModel.ISupportInitialize)(this.pawnPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pawnPictureBox;
    }
}
