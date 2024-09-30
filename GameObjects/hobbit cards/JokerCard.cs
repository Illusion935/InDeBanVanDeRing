using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public class JokerCard : HobbitCard
    {
        public JokerCard(Color color) : base("Joker", "Use this card as any card.", color)
        {
        }

        public override Image CardImage => Properties.Resources.diamond; // Verwijs naar de afbeelding in resources

        public override bool Play()
        {
            bool playedSuccesfully = base.Play();
            MessageBox.Show("You play the Joker card!");
            return playedSuccesfully;
        }
    }
}
