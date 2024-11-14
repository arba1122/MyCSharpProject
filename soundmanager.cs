using System;
using System.Media;

public class SoundManager
{
    // Metod för att spela upp ett ljud från en angiven fil
    public void PlaySound(string soundFileName)
    {
        try
        {
            //instans för att spela upp ljudet
            using (SoundPlayer player = new SoundPlayer(soundFileName))
            {
                player.Load();      
                player.PlaySync();  
            }
        }
        // Hantering av eventuella fel som uppstår vid ljuduppspelning
        catch (Exception e)
        {
            // Visar ett felmeddelande i konsolen om uppspelningen misslyckas
            Console.WriteLine("Fel vid uppspelning av ljud: " + e.Message);
        }
    }
}
