using InDeBanVanDeRing.GameObjects;
using InDeBanVanDeRing.GameObjects.hobbit_cards;
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

        public List<Control> cardControls { get; }

        private Dictionary<int, PlayerForm> playerForms = new Dictionary<int, PlayerForm>();
        private List<string> availableCharacters = new List<string> { "Frodo", "Sam", "Merry", "Pippin", "Fatty" };
        private Stack<Card> deck;
        private List<Card> cardsOnBoard = new List<Card>();

        public BoardForm()
        {
            InitializeComponent();
            instance = this;

            deck = CreateNewDeck();
        }

        public void PutCardOnBoard(Card newCard)
        {
            cardsOnBoard.Add(newCard);

            int xPos = 50; // Beginpositie op de x-as
            int yPos = this.Height / 2 - newCard.Height / 2; // Beginpositie op de y-as

            foreach (var card in cardsOnBoard)
            {
                // Stel de locatie van de controle in
                card.ControlLocation = new Point(xPos, yPos);

                card.SetCardControl();
                card.GetCardControl();

                xPos += card.Width + 10; // Verplaats naar rechts voor de volgende kaart (en wat ruimte ertussen)
            }
        }

        public void RemoveCardFromLists(Card card)
        {
            cardsOnBoard.Remove(card); // Verwijder de bijbehorende kaart uit de lijst
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

        private Stack<Card> CreateNewDeck(List<Card> discardPile = null)
        {
            // Create a list to temporarily hold the cards
            List<Card> cardList = discardPile;

            if (cardList == null || cardList.Count == 0)
            {
                cardList = new List<Card>();

                for (int i = 0; i < 7; i++)
                {
                    cardList.Add(new FightCard(CardColors.White));
                    cardList.Add(new FriendshipCard(CardColors.White));
                    cardList.Add(new HideCard(CardColors.White));
                    cardList.Add(new TravelCard(CardColors.White));
                }

                for (int i = 0; i < 5; i++)
                {
                    cardList.Add(new FightCard(CardColors.Grey));
                    cardList.Add(new FriendshipCard(CardColors.Grey));
                    cardList.Add(new HideCard(CardColors.Grey));
                    cardList.Add(new TravelCard(CardColors.Grey));
                }

                for (int i = 0; i < 12; i++)
                {
                    cardList.Add(new JokerCard(CardColors.White));
                }
            }

            // Shuffle the list
            ShuffleTheDeck(cardList);

            // Now transfer the shuffled list into a stack
            Stack<Card> deck = new Stack<Card>();

            foreach (var card in cardList)
            {
                deck.Push(card);
            }

            return deck;
        }


        private void ShuffleTheDeck(List<Card> deckList)
        {
            Random rng = new Random();
            int n = deckList.Count;

            // Fisher-Yates shuffle algorithm
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deckList[k];
                deckList[k] = deckList[n];
                deckList[n] = value;
            }
        }

        private void btnGandalfGiveHobbitCards_Click(object sender, EventArgs e)
        {
            foreach(PlayerForm playerForm in playerForms.Values)
            {
                // Create a list to hold the 6 cards for this player
                List<Card> playerHand = new List<Card>();

                // Pop 6 cards from the deck
                for (int i = 0; i < 6; i++)
                {
                    playerHand.Add(deck.Pop());
                }

                playerForm.AddCardsToHand(playerHand);
            }
        }
    }
}
