using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public class FightCard : BasicCard
    {
        public FightCard() : base("Fight", "Use this card to engage in combat.")
        {
        }

        public override Image CardImage => Properties.Resources.vechten; // Verwijs naar de afbeelding in resources

        public override bool Play()
        {
            bool playedSuccesfully = base.Play();
            MessageBox.Show("You play the Fight card!");
            return playedSuccesfully;
        }
    }
}
