using System;

public class Player
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Player(string name)
    {
        // Använder "Anonym Spelare" om name inte fylls i 
        Name = string.IsNullOrEmpty(name) ? "Anonym Spelare" : name;
        Score = 0;
    }
}
