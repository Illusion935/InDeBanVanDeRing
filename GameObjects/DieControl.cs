using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InDeBanVanDeRing.GameObjects
{
    public partial class DieControl : UserControl
    {
        public event EventHandler DieClicked;

        private List<Image> dieFaces;
        private Timer rollTimer;
        private int rollCounter;
        private int totalRolls = 10; // Aantal keren dat de dobbelsteen 'rolt'
        private int maxInterval = 400; // Maximale tijd tussen de rollen
        private int previousFaceIndex = -1;
        private Random r = new Random();
        private TaskCompletionSource<int> rollCompletionSource;

        public DieControl()
        {
            InitializeComponent();
            // Initialiseer de lijst voor de dobbelsteen gezichten
            dieFaces = new List<Image>();

            // Lijst van suffixen die overeenkomen met de resources in Properties.Resources
            string[] faceNames = { "White", "OneDot", "TwoDots", "ThreeDots", "Cards", "Eye" };

            // Gebruik reflectie om elke resource op te halen en toe te voegen aan de lijst
            foreach (string face in faceNames)
            {
                string resourceName = "die" + face;
                var resourceProperty = typeof(Properties.Resources).GetProperty(resourceName, BindingFlags.Static | BindingFlags.NonPublic);

                if (resourceProperty != null)
                {
                    Image dieFaceImage = (Image)resourceProperty.GetValue(null);
                    dieFaces.Add(dieFaceImage);
                }
                else
                {
                    MessageBox.Show("Bruhhhhhhhh, can't find the dieface");
                }
            }
        }

        public async Task<int> RollDie()
        {
            rollCounter = 1;
            rollCompletionSource = new TaskCompletionSource<int>();

            rollTimer = new Timer();
            rollTimer.Interval = CalculateInterval(rollCounter); // Gebruik de aangepaste intervalberekening
            rollTimer.Tick += RollTimer_Tick;
            rollTimer.Start();

            // Wacht totdat de timer klaar is met rollen en geef het resultaat terug
            return await rollCompletionSource.Task;
        }

        private void RollTimer_Tick(object sender, EventArgs e)
        {
            int newFaceIndex;

            // Zorg ervoor dat de nieuwe waarde niet hetzelfde is als de vorige
            do
            {
                newFaceIndex = r.Next(6); // Genereer een willekeurige index tussen 0 en 5
            } while (newFaceIndex == previousFaceIndex);
            // Update de vorige waarde
            previousFaceIndex = newFaceIndex;

            diePictureBox.BackgroundImage = dieFaces[newFaceIndex];
            rollCounter++;

            // Bereken het nieuwe interval voor een logaritmisch/boogvormig effect
            rollTimer.Interval = CalculateInterval(rollCounter);

            if (rollCounter > totalRolls)
            {
                rollTimer.Stop();
                // Laat het uiteindelijke resultaat zien
                do
                {
                    newFaceIndex = r.Next(6);
                } while (newFaceIndex == previousFaceIndex); // Nogmaals controleren dat het resultaat anders is
                previousFaceIndex = newFaceIndex;
                diePictureBox.BackgroundImage = dieFaces[newFaceIndex];
                rollCompletionSource.SetResult(newFaceIndex); // Voltooi de Task en geef het resultaat terug
            }
        }

        private int CalculateInterval(int rollIndex)
        {
            // Boogvormige curve - hoe verder in de tijd, hoe langzamer
            // Het interval begint klein en neemt toe in een boogvormige/logaritmische curve.
            double progress = (double)rollIndex / totalRolls;

            // Gebruik een kwadratische curve of logaritmische progressie om het effect te maken
            double curvedProgress = Math.Pow(progress, 2); // Kwadratische curve
                                                           // double curvedProgress = Math.Log10(1 + 9 * progress); // Voor logaritmisch effect, optioneel

            // Bereken het nieuwe interval op basis van de curve
            return (int)(curvedProgress * maxInterval);
        }

        private void diePictureBox_Click(object sender, EventArgs e)
        {
            if (!BoardForm.instance.dieLocked)
                DieClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
