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
    public partial class BoardForm : Form, IForm
    {
        public static BoardForm instance;

        private Dictionary<int, PlayerForm> playerForms = new Dictionary<int, PlayerForm>();
        private List<string> availableCharacters = new List<string> { "Frodo", "Sam", "Merry", "Pippin", "Fatty" };
        private List<Card> cards = new List<Card>();

        public BoardForm()
        {
            InitializeComponent();
            instance = this;
        }

        public void PutCardOnBoard(Card newCard)
        {
            cards.Clear();
            foreach (var cardControl in this.Controls.OfType<BasicCardControl>())
            {
                cards.Add(cardControl.GetCard());
            }

            cards.Add(newCard);

            int xPos = 50; // Beginpositie op de x-as
            int yPos = 50; // Beginpositie op de y-as

            foreach (var card in cards)
            {
                // Stel de locatie van de controle in
                card.ControlLocation = new Point(xPos, yPos);

                card.SetCardControl();
                card.AddControlToForm(this);
               
                xPos += card.Width + 10; // Verplaats naar rechts voor de volgende kaart (en wat ruimte ertussen)
            }
        }

        public void RemoveCardFromList(Card card)
        {
            cards.Remove(card); // Verwijder de bijbehorende kaart uit de lijst
        }

        private void btnPlayer1Window_Click(object sender, EventArgs e)
        {
            if (playerForms.Count < 5) {
                int playerNumber = Enumerable.Range(1, 5).Except(playerForms.Keys).First();

                PlayerForm form = new PlayerForm(playerNumber);
                form.PlayerName = "player " + playerNumber.ToString();

                playerForms.Add(playerNumber, form);

                // Update de beschikbare characters in de nieuwe form
                form.UpdateCharacterOptions(availableCharacters);

                // Subscribe naar het CharacterLockedIn event
                form.CharacterLockedIn += Form_CharacterLockedIn;
                form.FormClosing += (s, ev) => NewForm_FormClosing(s, ev, playerNumber);
                form.Show();
            }
            else
            {
                MessageBox.Show("Maximaal 5 spelers toegestaan.");
            }
        }

        // Event handler voor wanneer een speler zijn keuze vastzet
        private void Form_CharacterLockedIn(string selectedCharacter, int playerNumber)
        {
            // Verwijder het gekozen character uit de beschikbare characters
            availableCharacters.Remove(selectedCharacter);

            // Update de character opties in de andere forms
            foreach (var form in playerForms.Values)
            {
                if (form != null && form.Enabled) // Controleer of het form nog open is
                {
                    form.UpdateCharacterOptions(availableCharacters);
                }
            }
        }

        private void NewForm_FormClosing(object sender, FormClosingEventArgs e, int playerNumber)
        {
            // Verwijder het form uit de dictionary
            if (playerForms.ContainsKey(playerNumber))
            {
                playerForms.Remove(playerNumber);
            }
        }
    }
}
