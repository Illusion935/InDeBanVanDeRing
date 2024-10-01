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
        private Dictionary<string, Player> players = new Dictionary<string, Player>();
        private List<string> availableCharacters = new List<string> { "Frodo", "Sam", "Merry", "Pippin", "Fatty" };
        private Stack<Card> deck;
        private List<Card> cardsOnBoard = new List<Card>();
        private Dictionary<int, Panel> tilePanelsDict;
        private Dictionary<int, Point> tilePawnLocations;

        public BoardForm()
        {
            InitializeComponent();
            instance = this;

            InitializeCorruptionLine();
            InitializePawnLocationsSetup();
            deck = CreateNewDeck();
        }

        private void InitializePawnLocationsSetup()
        {
            int tw = tilePanelsDict[1].Width;
            int th = tilePanelsDict[1].Height;
            int ph = new PlayerPawnControl("Red").Height;

            tilePawnLocations = new Dictionary<int, Point>()
            {
                { 0, new Point(3, 3) },        // Pawn 1
                { 1, new Point(tw/2, th/3-ph/2) },      // Pawn 2
                { 2, new Point(3, th/2-ph/2) },       // Pawn 3
                { 3, new Point(tw/2, th/3*2-ph/2) },      // Pawn 4
                { 4, new Point(3, th/4*3-3) },       // Pawn 5
            };
        }

        private void InitializeCorruptionLine()
        {
            tilePanelsDict = new Dictionary<int, Panel>();
            // Verwijder eventuele bestaande controls
            corruptionLine.Controls.Clear();

            // Voeg 15 panelen toe, elk met een andere grijstint
            for (int i = 0; i < 15; i++)
            {
                Panel tilePanel = new Panel();
                tilePanel.Dock = DockStyle.Fill;

                // Stel de kleur in op basis van de index (verschillende grijstinten)
                int greyValue = 255 - (i * 15); // Dit zorgt voor een aflopende grijstint
                tilePanel.BackColor = Color.FromArgb(greyValue, greyValue, greyValue);
                // Stel de border van het panel in
                tilePanel.BorderStyle = BorderStyle.FixedSingle;

                // Voeg het stepPanel toe aan de betreffende kolom in de eerste rij
                corruptionLine.Controls.Add(tilePanel, i, 0);

                // Voeg het tilePanel toe aan de dictionary om het later te kunnen opzoeken
                tilePanelsDict.Add(i+1, tilePanel);
            }
        }

        private void MovePawnOnTile(PlayerPawnControl pawnControl, int tileNum)
        {
            Panel tile = tilePanelsDict[tileNum];
            int pawnIndex = tile.Controls.Count;
            
            Point point = tilePawnLocations[pawnIndex];
            pawnControl.Location = point;

            tile.Controls.Add(pawnControl);
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
                Controls.Add(card.GetCardControl());

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
        private void Form_CharacterLockedIn(Player player)
        {
            players[player.Character] = player;
            MovePawnOnTile(player.PawnControl, 1);
            // Verwijder het gekozen character uit de beschikbare characters
            availableCharacters.Remove(player.Character);

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
