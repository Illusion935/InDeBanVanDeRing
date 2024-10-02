using InDeBanVanDeRing.GameObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InDeBanVanDeRing
{
    public partial class LocationBoard : UserControl
    {
        private BoardForm _bf;
        private BoardForm Bf => _bf ?? (_bf = BoardForm.instance);

        private int step = 2;

        public LocationBoard()
        {
            InitializeComponent();
        }

        public void OnDieRolled(object sender, EventArgs e)
        {
            if (step == 2)
            {
                DieRollStep2();
            }
        }

        private async void DieRollStep2()
        {
            int dieResult = await Bf.RollDie();

            Bf.HandleDieRoll(dieResult, Bf.players["Frodo"]);
            Bf.dieLocked = true;

            btnPrepChooseDie.Visible = true;
            btnPrepGoNext.Visible = true;
            lblThrowDieInstructions.Visible = false;
        }

        private void btnGandalfReceiveCards_Click(object sender, EventArgs e)
        {
            foreach (PlayerForm playerForm in Bf.playerForms.Values)
            {
                // Create a list to hold the 6 cards for this player
                List<Card> playerHand = new List<Card>();

                // Pop 6 cards from the deck
                for (int i = 0; i < 6; i++)
                {
                    playerHand.Add(Bf.deck.Pop());
                }

                playerForm.AddCardsToHand(playerHand);
            }

            step = 2;
        }

        private void btnPrepChooseDie_Click(object sender, EventArgs e)
        {
            Bf.dieLocked = false;
            btnPrepChooseDie.Visible = false;
            btnPrepGoNext.Visible = false;
            lblThrowDieInstructions.Visible = true;
        }

        private void btnPrepGoNext_Click(object sender, EventArgs e)
        {

        }
    }
}
