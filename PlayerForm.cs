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
            cards.Clear();
            foreach (var cardControl in this.Controls.OfType<BasicCardControl>())
            {
                cards.Add(cardControl.GetCard());
            }

            cards.Add(new FightCard());
            cards.Add(new HideCard());

            int xPos = 10; // Beginpositie op de x-as
            int yPos = 80; // Beginpositie op de y-as

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
