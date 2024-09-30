namespace InDeBanVanDeRing
{
    partial class PlayerForm
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
            this.cardsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerNaam
            // 
            this.txtPlayerNaam.AutoSize = true;
            this.txtPlayerNaam.Location = new System.Drawing.Point(23, 23);
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
            // cardsPanel
            // 
            this.cardsPanel.AutoScroll = true;
            this.cardsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardsPanel.Location = new System.Drawing.Point(10, 113);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(780, 369);
            this.cardsPanel.TabIndex = 4;
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.cardsPanel);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.btnLockCharacter);
            this.Controls.Add(this.comboBoxCharacters);
            this.Controls.Add(this.txtPlayerNaam);
            this.Name = "PlayerForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlayerNaam;
        private System.Windows.Forms.ComboBox comboBoxCharacters;
        private System.Windows.Forms.Button btnLockCharacter;
        private System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.Panel cardsPanel;
    }
}