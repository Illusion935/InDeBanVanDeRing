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
    public partial class PlayerForm : Form, IForm
    {
        public static PlayerForm instance;

        private int playerNumber; // Opslag van het speler-nummer
        private string selectedCharacter; // Opslag van het gekozen karakter
        private List<Card> cards = new List<Card>();
        private List<Control> cardControls = new List<Control>();

        public event Action<string, int> CharacterLockedIn; // Event dat wordt getriggerd wanneer een keuze wordt vastgezet

        public PlayerForm(int playerNumber)
        {
            InitializeComponent();
            instance = this;
            this.playerNumber = playerNumber;

            comboBoxCharacters.Items.AddRange(new string[] { "Frodo", "Sam", "Merry", "Pippin", "Fatty" });

            // Subscribe naar het Load event
            this.Load += PlayerForm_Load;

            CreateAndShowCards();
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

        public void CreateAndShowCards()
        {
            cards.Add(new FightCard());
            cards.Add(new HideCard());

            cardControls.Clear();
            foreach (var card in cards)
            {
                card.SetCardControl();
                cardControls.Add(card.GetCardControl());
            }

            ArrangeCardsInPlayerForm();
        }

        public void ArrangeCardsInPlayerForm()
        {
            int formWidth = this.ClientSize.Width;
            int cardWidth = cardControls[0].Width;
            int spacing = 10; // De ruimte tussen de kaarten

            int totalWidth = (cardControls.Count * cardWidth) + ((cardControls.Count - 1) * spacing);
            int startX = (formWidth - totalWidth) / 2; // Beginpunt, zodat alles gecentreerd is

            int yPos = this.ClientSize.Height - cardControls[0].Height - 20; // Plaats dicht bij de onderkant

            for (int i = 0; i < cards.Count; i++)
            {
                Control cardControl = cardControls[i];
                cardControl.Location = new Point(startX + i * (cardWidth + spacing), yPos);
                cardControl.Anchor = AnchorStyles.Bottom; // Blijft aan de onderkant verankerd
                this.Controls.Add(cardControl);
            }
        }


        public void RemoveCardFromList(Card card)
        {
            cards.Remove(card); // Verwijder de bijbehorende kaart uit de lijst
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

            // Trigger het CharacterLockedIn event en geef de gekozen character en speler-nummer door
            CharacterLockedIn?.Invoke(selectedCharacter, playerNumber);
        }

        private void comboBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCharacter = comboBoxCharacters.SelectedItem.ToString();
            imgCharacter.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(selectedCharacter.ToLower());
        }
    }
}
