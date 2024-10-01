using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InDeBanVanDeRing.GameObjects
{
    public partial class HobbitCardControl : UserControl
    {
        private HobbitCard _card; // Houd de kaart bij

        private Label lblCardName;
        private TextBox txtCardDescription;
        private Button btnPlayCard;
        private PictureBox pictureBoxCard;

        public HobbitCardControl()
        {
            InitializeComponent();
        }

        public void SetCard(HobbitCard card)
        {
            _card = card;

            // Stel de eigenschappen van de controle in op basis van de kaart
            this.BackColor = card.Color;
            this.lblCardName.Text = card.CardName;
            this.txtCardDescription.Text = card.CardDescription;
            this.pictureBoxCard.BackgroundImage = card.CardImage; // Stel de afbeelding in
        }

        public HobbitCard GetCard()
        {
            return _card;
        }

        private void btnPlayCard_Click(object sender, EventArgs e)
        {
            IForm currentForm = null;

            if (this.Parent is IForm parentForm)
            {
                // The parent implements IForm
                currentForm = parentForm;
            }
            else if (this.Parent?.Parent is IForm parentOfParentForm)
            {
                // The parent of the parent implements IForm
                currentForm = parentOfParentForm;
            }
            else
            {
                MessageBox.Show("Neither parent nor parent of parent implements IForm.");
                return; // Stop execution if neither implement IForm
            }

            // Probeer de kaart te spelen
            bool cardPlayedSuccessfully = _card.Play();
            if (!cardPlayedSuccessfully)
            {
                // Optioneel: geef hier een foutmelding of doe iets anders als het spelen niet is gelukt
                MessageBox.Show("De kaart kon niet worden gespeeld.");
                return; // Stop de uitvoering als het spelen niet is gelukt
            }

            // Verwijder de kaart uit de parent form
            currentForm.RemoveCardFromLists(_card);
        }

        private void InitializeComponent()
        {
            this.lblCardName = new System.Windows.Forms.Label();
            this.txtCardDescription = new System.Windows.Forms.TextBox();
            this.btnPlayCard = new System.Windows.Forms.Button();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(19, 10);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(85, 20);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "CardName";
            // 
            // txtCardDescription
            // 
            this.txtCardDescription.Enabled = false;
            this.txtCardDescription.Location = new System.Drawing.Point(19, 93);
            this.txtCardDescription.Multiline = true;
            this.txtCardDescription.Name = "txtCardDescription";
            this.txtCardDescription.ReadOnly = true;
            this.txtCardDescription.Size = new System.Drawing.Size(100, 63);
            this.txtCardDescription.TabIndex = 2;
            // 
            // btnPlayCard
            // 
            this.btnPlayCard.Location = new System.Drawing.Point(19, 162);
            this.btnPlayCard.Name = "btnPlayCard";
            this.btnPlayCard.Size = new System.Drawing.Size(100, 41);
            this.btnPlayCard.TabIndex = 3;
            this.btnPlayCard.Text = "Speel";
            this.btnPlayCard.UseVisualStyleBackColor = true;
            this.btnPlayCard.Click += new System.EventHandler(this.btnPlayCard_Click);
            // 
            // pictureBoxCard
            // 
            this.pictureBoxCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCard.Location = new System.Drawing.Point(19, 33);
            this.pictureBoxCard.Name = "pictureBoxCard";
            this.pictureBoxCard.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCard.TabIndex = 0;
            this.pictureBoxCard.TabStop = false;
            // 
            // HobbitCardControl
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnPlayCard);
            this.Controls.Add(this.txtCardDescription);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.pictureBoxCard);
            this.Name = "HobbitCardControl";
            this.Size = new System.Drawing.Size(136, 213);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
