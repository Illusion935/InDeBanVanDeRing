using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public abstract class Card : ICard
    {
        public string CardName { get; protected set; } // Directe property
        public string CardDescription { get; protected set; } // Directe property
        public Point ControlLocation { get; set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public abstract Image CardImage { get; } // Abstract property voor de afbeelding

        protected Card(string cardName, string cardDescription)
        {
            CardName = cardName; // Gebruik de property direct
            CardDescription = cardDescription; // Gebruik de property direct
        }

        public abstract bool Play();
        public abstract void SetCardControl();
        public abstract Control GetCardControl();
    }
}
