using InDeBanVanDeRing.GameObjects;
using InDeBanVanDeRing;
using System.Collections.Generic;

public class Player
{
    // Eigenschappen van de Player klasse
    public int PlayerNum { get; set; }                // Voor het bijhouden van het speler nummer
    public PlayerForm PlayerForm { get; set; }        // Voor het bijhouden van de vorm van de speler
    public string Character { get; set; }              // Voor het bijhouden van het karakter van de speler
    public PlayerPawnControl PawnControl { get; set; } // De pawn control voor de speler
    public List<string> LifeTokens { get; set; }   // Lijst van levenspunten, nu van het type LifeToken

    // Constructor
    public Player(int playerNum, PlayerForm playerForm, string character)
    {
        PlayerNum = playerNum;
        PlayerForm = playerForm;                        // Zet de PlayerForm
        Character = character;
        PawnControl = SetPawnControl(character);        // Stel de pawn in met een kleur
        LifeTokens = new List<string>();                // Initialiseer de lijst van levenspunten
    }

    // Methode om de PawnControl in te stellen afhankelijk van het karakter
    private PlayerPawnControl SetPawnControl(string character)
    {
        switch (character)
        {
            case "Frodo":
                return new PlayerPawnControl("Yellow");
            case "Sam":
                return new PlayerPawnControl("Red");
            case "Merry":
                return new PlayerPawnControl("Blue");
            case "Pippin":
                return new PlayerPawnControl("Green");
            case "Fatty":
                return new PlayerPawnControl("Orange");
            default:
                return new PlayerPawnControl("Blue"); // Standaardkleur als het karakter niet herkend wordt
        }
    }
}
