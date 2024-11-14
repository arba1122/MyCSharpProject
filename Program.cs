using System;
// startar Jeopardy spelet  av klassen JeopardyGame som anropar metoden StartGame för att sätta igång spelet
class Program
{
    static void Main()
    {
        JeopardyGame game = new JeopardyGame();
        game.StartGame();  
    }
}
