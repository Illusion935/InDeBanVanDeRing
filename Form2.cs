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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        private int playerNumber; // Opslag van het speler-nummer
        private string selectedCharacter; // Opslag van het gekozen karakter

        public event Action<string, int> CharacterLockedIn; // Event dat wordt getriggerd wanneer een keuze wordt vastgezet

        public Form2(int playerNumber)
        {
            InitializeComponent();
            instance = this;
            this.playerNumber = playerNumber;

            comboBoxCharacters.Items.AddRange(new string[] { "Frodo", "Sam", "Merry", "Pippin", "Fatty" });

            // Subscribe naar het Load event
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
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
