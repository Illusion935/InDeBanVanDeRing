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
    public partial class PlayerForm : Form, IForm
    {
        public static PlayerForm instance;

        private Player player;
        private int playerNumber; // Opslag van het speler-nummer
        private string selectedCharacter; // Opslag van het gekozen karakter
        private List<Card> cards = new List<Card>();
        private List<Control> cardControls = new List<Control>();

        public event Action<Player> CharacterLockedIn; // Event dat wordt getriggerd wanneer een keuze wordt vastgezet

        public PlayerForm(int playerNumber)
        {
            InitializeComponent();
            instance = this;
            this.playerNumber = playerNumber;

            comboBoxCharacters.Items.AddRange(new string[] { "Frodo", "Sam", "Merry", "Pippin", "Fatty" });

            // Subscribe naar het Load event
            this.Load += PlayerForm_Load;

        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            comboBoxCharacters.SelectedIndex = 0; // Standaard selecteer de eerste optie
            comboBoxCharacters.SelectedItem = comboBoxCharacters.Items[0];
        }

        // Property waarmee je de naam van de speler kunt instellen
        public string PlayerName
        {
            get { return txtPlayerNaam.Text; }
            set { txtPlayerNaam.Text = value; }
        }

        public void AddCardsToHand(List<Card> cardsToAdd)
        {
            cards.AddRange(cardsToAdd);

            foreach (var card in cardsToAdd)
            {
                cardControls.Add(card.GetCardControl());
            }

            ArrangeCardsInPlayerForm();
        }

        public void ArrangeCardsInPlayerForm()
        {
            int cardWidth = cardControls[0].Width;
            int spacing = 10; // De ruimte tussen de kaarten

            int startX = 0;
            int yPos = 0;

            for (int i = 0; i < cardControls.Count; i++)
            {
                Control cardControl = cardControls[i];
                cardControl.Location = new Point(startX + i * (cardWidth + spacing), yPos);
                cardsPanel.Controls.Add(cardControl);
            }
        }

        public void RemoveCardFromLists(Card card)
        {
            cards.Remove(card); // Verwijder de bijbehorende kaart uit de lijst
            cardControls.Remove(card.GetCardControl());
        }

        // Methode die de combobox updates met de beschikbare characters
        public void UpdateCharacterOptions(List<string> availableCharacters)
        {
            comboBoxCharacters.Items.Clear();
            comboBoxCharacters.Items.AddRange(availableCharacters.ToArray());
            if (comboBoxCharacters.Enabled == true)
            {
                comboBoxCharacters.SelectedIndex = 0; // Standaard selecteer de eerste optie
                comboBoxCharacters.SelectedItem = comboBoxCharacters.Items[0];
            }
        }

        private void btnLockCharacter_Click(object sender, EventArgs e)
        {
            selectedCharacter = comboBoxCharacters.SelectedItem.ToString();

            // Disable de ComboBox en de Lock-in button nadat de keuze is vastgezet
            comboBoxCharacters.Enabled = false;
            btnLockCharacter.Enabled = false;

            player = new Player(playerNumber, this, selectedCharacter);

            // Trigger het CharacterLockedIn event en geef de gekozen character en speler-nummer door
            CharacterLockedIn?.Invoke(player);
        }

        private void comboBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCharacter = comboBoxCharacters.SelectedItem.ToString();
            imgCharacter.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(selectedCharacter.ToLower());
        }
    }
}
