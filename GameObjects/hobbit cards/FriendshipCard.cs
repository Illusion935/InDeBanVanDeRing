using System.Drawing;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects.hobbit_cards
{
    public class FriendshipCard : HobbitCard
    {
        public FriendshipCard(Color color) : base("Friendship", "Use this card to bond new allies.", color)
        {
        }

        public override Image CardImage => Properties.Resources.friendship; // Verwijs naar de afbeelding in resources

        public override bool Play()
        {
            bool playedSuccesfully = base.Play();
            MessageBox.Show("You play the Friendship card!");
            return playedSuccesfully;
        }
    }
}
