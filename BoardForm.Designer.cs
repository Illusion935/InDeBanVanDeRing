namespace InDeBanVanDeRing
{
    partial class BoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnPlayer1Window = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnGandalfGiveHobbitCards = new System.Windows.Forms.Button();
            this.corruptionLine = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::InDeBanVanDeRing.Properties.Resources.cirkel_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(55, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 60);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnPlayer1Window
            // 
            this.btnPlayer1Window.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayer1Window.Location = new System.Drawing.Point(449, 530);
            this.btnPlayer1Window.Name = "btnPlayer1Window";
            this.btnPlayer1Window.Size = new System.Drawing.Size(170, 49);
            this.btnPlayer1Window.TabIndex = 4;
            this.btnPlayer1Window.Text = "Voeg speler toe (max. 5)";
            this.btnPlayer1Window.UseVisualStyleBackColor = true;
            this.btnPlayer1Window.Click += new System.EventHandler(this.btnPlayer1Window_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartGame.Location = new System.Drawing.Point(449, 588);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(170, 49);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start het spel";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // btnGandalfGiveHobbitCards
            // 
            this.btnGandalfGiveHobbitCards.BackColor = System.Drawing.Color.Gold;
            this.btnGandalfGiveHobbitCards.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGandalfGiveHobbitCards.Location = new System.Drawing.Point(15, 23);
            this.btnGandalfGiveHobbitCards.Name = "btnGandalfGiveHobbitCards";
            this.btnGandalfGiveHobbitCards.Size = new System.Drawing.Size(173, 95);
            this.btnGandalfGiveHobbitCards.TabIndex = 6;
            this.btnGandalfGiveHobbitCards.Text = "Gandalf: ELKE SPELER ontvangt 6 hobbit kaarten";
            this.btnGandalfGiveHobbitCards.UseVisualStyleBackColor = false;
            this.btnGandalfGiveHobbitCards.Click += new System.EventHandler(this.btnGandalfGiveHobbitCards_Click);
            // 
            // corruptionLine
            // 
            this.corruptionLine.ColumnCount = 15;
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.corruptionLine.Location = new System.Drawing.Point(15, 199);
            this.corruptionLine.Name = "corruptionLine";
            this.corruptionLine.RowCount = 1;
            this.corruptionLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.corruptionLine.Size = new System.Drawing.Size(1000, 100);
            this.corruptionLine.TabIndex = 7;
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 738);
            this.Controls.Add(this.corruptionLine);
            this.Controls.Add(this.btnGandalfGiveHobbitCards);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnPlayer1Window);
            this.Controls.Add(this.pictureBox2);
            this.Name = "BoardForm";
            this.Text = "Board";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnPlayer1Window;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnGandalfGiveHobbitCards;
        private System.Windows.Forms.TableLayoutPanel corruptionLine;
    }
}

