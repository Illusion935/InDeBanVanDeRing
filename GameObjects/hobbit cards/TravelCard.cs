using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects.hobbit_cards
{
    public class TravelCard : HobbitCard
    {
        public TravelCard(Color color) : base("Travel", "Use this card to travel forward on the journey.", color)
        {
        }

        public override Image CardImage => Properties.Resources.travel; // Verwijs naar de afbeelding in resources

        public override bool Play()
        {
            bool playedSuccesfully = base.Play();
            MessageBox.Show("You play the Travel card!");
            return playedSuccesfully;
        }
    }
}
