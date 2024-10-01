using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public partial class PlayerPawnControl : UserControl
    {
        // Property voor de positie van de pawn
        public int Position { get; set; }

        public PlayerPawnControl(string color)
        {
            InitializeComponent();
            // Creëer de volledige naam van de resource op basis van de meegegeven kleur.
            string resourceName = "pawn" + color;

            // Gebruik reflection om de resource op te halen uit Properties.Resources.
            var resourceProperty = typeof(Properties.Resources).GetProperty(resourceName, BindingFlags.Static | BindingFlags.NonPublic);
            pawnPictureBox.BackgroundImage = (Image)resourceProperty.GetValue(null);

            Position = 1;
        }
    }
}
