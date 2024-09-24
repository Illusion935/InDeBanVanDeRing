namespace InDeBanVanDeRing
{
    partial class Form2
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
            this.txtPlayerNaam = new System.Windows.Forms.Label();
            this.comboBoxCharacters = new System.Windows.Forms.ComboBox();
            this.btnLockCharacter = new System.Windows.Forms.Button();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerNaam
            // 
            this.txtPlayerNaam.AutoSize = true;
            this.txtPlayerNaam.Location = new System.Drawing.Point(23, 22);
            this.txtPlayerNaam.Name = "txtPlayerNaam";
            this.txtPlayerNaam.Size = new System.Drawing.Size(86, 20);
            this.txtPlayerNaam.TabIndex = 0;
            this.txtPlayerNaam.Text = "player num";
            // 
            // comboBoxCharacters
            // 
            this.comboBoxCharacters.FormattingEnabled = true;
            this.comboBoxCharacters.Location = new System.Drawing.Point(27, 58);
            this.comboBoxCharacters.Name = "comboBoxCharacters";
            this.comboBoxCharacters.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCharacters.TabIndex = 1;
            this.comboBoxCharacters.Text = "karakters";
            this.comboBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharacters_SelectedIndexChanged);
            // 
            // btnLockCharacter
            // 
            this.btnLockCharacter.Location = new System.Drawing.Point(154, 57);
            this.btnLockCharacter.Name = "btnLockCharacter";
            this.btnLockCharacter.Size = new System.Drawing.Size(150, 37);
            this.btnLockCharacter.TabIndex = 2;
            this.btnLockCharacter.Text = "Bevestig keuze";
            this.btnLockCharacter.UseVisualStyleBackColor = true;
            this.btnLockCharacter.Click += new System.EventHandler(this.btnLockCharacter_Click);
            // 
            // imgCharacter
            // 
            this.imgCharacter.BackgroundImage = global::InDeBanVanDeRing.Properties.Resources.frodo;
            this.imgCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCharacter.Location = new System.Drawing.Point(321, 12);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(93, 95);
            this.imgCharacter.TabIndex = 3;
            this.imgCharacter.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.btnLockCharacter);
            this.Controls.Add(this.comboBoxCharacters);
            this.Controls.Add(this.txtPlayerNaam);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlayerNaam;
        private System.Windows.Forms.ComboBox comboBoxCharacters;
        private System.Windows.Forms.Button btnLockCharacter;
        private System.Windows.Forms.PictureBox imgCharacter;
    }
}