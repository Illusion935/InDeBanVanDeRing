using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public class HideCard : HobbitCard
    {
        public HideCard(Color color) : base("Hide", "Use this card to hide from the enemy.", color)
        {
        }

        public override Image CardImage => Properties.Resources.schuilen; // Verwijs naar de afbeelding in resources

        public override bool Play()
        {
            bool playedSuccesfully = base.Play();
            MessageBox.Show("You play the Hide card!");
            return playedSuccesfully;
        }
    }
}
