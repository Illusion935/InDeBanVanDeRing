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
        }

        public override void Play()
        {
            Form1.instance.PutCardOnBoard(this);
        }

        public override void SetCardControl()
        {
        }

        public override void AddControlToForm(Form form)
        {
            form.Controls.Add(BasicCardControl);
        }
    }
}
