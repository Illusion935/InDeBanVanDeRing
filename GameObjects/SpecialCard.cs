using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace InDeBanVanDeRing.GameObjects
{
    public abstract class SpecialCard : Card, ICard
    {
        public BasicCardControl BasicCardControl { get; protected set; }
        public override abstract Image CardImage { get; }

        protected SpecialCard(string cardName, string cardDescription) : base(cardName, cardDescription)
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
        }

        public override Control GetCardControl()
        {
            return BasicCardControl;
        }
    }
}
