using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public class HideCard : BasicCard
    {
        public HideCard() : base("Hide", "Use this card to hide from the enemy.")
        {
        }

        public override Image CardImage => Properties.Resources.schuilen; // Verwijs naar de afbeelding in resources

        public override void Play()
        {
            base.Play();
            MessageBox.Show("You play the Hide card!");
        }
    }
}
