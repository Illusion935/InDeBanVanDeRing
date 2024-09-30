using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public abstract class HobbitCard : Card, ICard
    {
        public HobbitCardControl HobbitCardControl { get; protected set; }

        protected HobbitCard(string cardName, string cardDescription, Color cardColor) : base(cardName, cardDescription)
        {
            CardName = cardName; // Gebruik de property direct
            CardDescription = cardDescription; // Gebruik de property direct

            HobbitCardControl = new HobbitCardControl();
            Width = HobbitCardControl.Width;
            Height = HobbitCardControl.Height;
            Color = cardColor;

            SetCardControl();
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
            HobbitCardControl.SetCard(this);
        }

        public override Control GetCardControl()
        {
            return HobbitCardControl;
        }
    }
}
