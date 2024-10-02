namespace InDeBanVanDeRing
{
    partial class LocationBoard
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
            this.preparationGroupBox = new System.Windows.Forms.GroupBox();
            this.btnPrepChooseDie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGandalfReceiveCards = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrepGoNext = new System.Windows.Forms.Button();
            this.lblThrowDieInstructions = new System.Windows.Forms.Label();
            this.preparationGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // preparationGroupBox
            // 
            this.preparationGroupBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.preparationGroupBox.Controls.Add(this.btnPrepGoNext);
            this.preparationGroupBox.Controls.Add(this.btnPrepChooseDie);
            this.preparationGroupBox.Controls.Add(this.label1);
            this.preparationGroupBox.Controls.Add(this.lblThrowDieInstructions);
            this.preparationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparationGroupBox.Location = new System.Drawing.Point(362, 31);
            this.preparationGroupBox.Name = "preparationGroupBox";
            this.preparationGroupBox.Size = new System.Drawing.Size(234, 129);
            this.preparationGroupBox.TabIndex = 10;
            this.preparationGroupBox.TabStop = false;
            this.preparationGroupBox.Text = "Voorbereiding (optioneel)";
            // 
            // btnPrepChooseDie
            // 
            this.btnPrepChooseDie.BackColor = System.Drawing.Color.Crimson;
            this.btnPrepChooseDie.Location = new System.Drawing.Point(10, 84);
            this.btnPrepChooseDie.Name = "btnPrepChooseDie";
            this.btnPrepChooseDie.Size = new System.Drawing.Size(94, 39);
            this.btnPrepChooseDie.TabIndex = 1;
            this.btnPrepChooseDie.Text = "Kies 🎲";
            this.btnPrepChooseDie.UseVisualStyleBackColor = false;
            this.btnPrepChooseDie.Click += new System.EventHandler(this.btnPrepChooseDie_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "De drager van de Ring mag 🎲 om 4 hobbitkaarten te trekken en uit te delen";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.btnGandalfReceiveCards);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 129);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gandalf";
            // 
            // btnGandalfReceiveCards
            // 
            this.btnGandalfReceiveCards.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGandalfReceiveCards.Location = new System.Drawing.Point(37, 84);
            this.btnGandalfReceiveCards.Name = "btnGandalfReceiveCards";
            this.btnGandalfReceiveCards.Size = new System.Drawing.Size(149, 39);
            this.btnGandalfReceiveCards.TabIndex = 1;
            this.btnGandalfReceiveCards.Text = "Ontvang 🃏";
            this.btnGandalfReceiveCards.UseVisualStyleBackColor = false;
            this.btnGandalfReceiveCards.Click += new System.EventHandler(this.btnGandalfReceiveCards_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 61);
            this.label2.TabIndex = 0;
            this.label2.Text = "ELKE SPELER ontvangt 6 hobbit kaarten";
            // 
            // btnPrepGoNext
            // 
            this.btnPrepGoNext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPrepGoNext.Location = new System.Drawing.Point(110, 84);
            this.btnPrepGoNext.Name = "btnPrepGoNext";
            this.btnPrepGoNext.Size = new System.Drawing.Size(104, 39);
            this.btnPrepGoNext.TabIndex = 2;
            this.btnPrepGoNext.Text = "Volgende";
            this.btnPrepGoNext.UseVisualStyleBackColor = false;
            this.btnPrepGoNext.Click += new System.EventHandler(this.btnPrepGoNext_Click);
            // 
            // lblThrowDieInstructions
            // 
            this.lblThrowDieInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrowDieInstructions.Location = new System.Drawing.Point(63, 81);
            this.lblThrowDieInstructions.Name = "lblThrowDieInstructions";
            this.lblThrowDieInstructions.Size = new System.Drawing.Size(93, 42);
            this.lblThrowDieInstructions.TabIndex = 3;
            this.lblThrowDieInstructions.Text = "Gooi de 🎲 (klik erop)";
            this.lblThrowDieInstructions.Visible = false;
            // 
            // LocationBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.preparationGroupBox);
            this.Name = "LocationBoard";
            this.Size = new System.Drawing.Size(958, 190);
            this.preparationGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox preparationGroupBox;
        private System.Windows.Forms.Button btnPrepChooseDie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGandalfReceiveCards;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrepGoNext;
        private System.Windows.Forms.Label lblThrowDieInstructions;
    }
}
