using System.Drawing;
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
        }

        public override void Play()
        {
            Form1.instance.PutCardOnBoard(this);
        }

        public override void SetCardControl()
        {
            BasicCardControl.SetCard(this);
        }

        public override void AddControlToForm(Form form)
        {
            form.Controls.Add(BasicCardControl);
        }
    }
}
