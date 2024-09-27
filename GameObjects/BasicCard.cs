﻿using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public abstract class BasicCard : Card, ICard
    {
        public BasicCardControl BasicCardControl { get; protected set; }

        protected BasicCard(string cardName, string cardDescription) : base(cardName, cardDescription)
        {
            CardName = cardName; // Gebruik de property direct
            CardDescription = cardDescription; // Gebruik de property direct
            BasicCardControl = new BasicCardControl();
            Width = BasicCardControl.Width;
            Height = BasicCardControl.Height;
        }

        public override bool Play()
        {
            // Speel de kaart, voeg hier logica toe voor validatie
            bool isValid = true; // of valideer de spelregels

            if (isValid)
            {
                // Voer speel-logica uit
                BoardForm.instance.PutCardOnBoard(this);
                return true;
            }
            else
            {
                // Mogelijk wat logica om aan te geven dat spelen niet is toegestaan
                return false;
            }
        }

        public override void SetCardControl()
        {
            BasicCardControl.SetCard(this);
        }

        public override Control GetCardControl()
        {
            return BasicCardControl;
        }
    }
}
