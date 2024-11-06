using System;
using System.Threading;

class Program
{
    // Variabler för att hålla koll på tillgängliga poäng för varje kategori och nivå
    static int cat1_100 = 100, cat1_200 = 200, cat1_300 = 300, cat1_400 = 400, cat1_500 = 500;
    static int cat2_100 = 100, cat2_200 = 200, cat2_300 = 300, cat2_400 = 400, cat2_500 = 500;
    static int cat3_100 = 100, cat3_200 = 200, cat3_300 = 300, cat3_400 = 400, cat3_500 = 500;
    static int cat4_100 = 100, cat4_200 = 200, cat4_300 = 300, cat4_400 = 400, cat4_500 = 500;

    static void Main()
    {
        // Presentation
        Console.WriteLine("*      VÄLKOMMEN TILL JEOPARDY!     *");
        Console.WriteLine("**************************************");
        Console.WriteLine("   Testa era kunskaper och ha kul!    ");
        Console.WriteLine("**********************************\n");

        // Spelarna fyller i sitt namn
        Console.WriteLine("Spelare 1, Var god skriv in ditt namn:");
        string player1 = Console.ReadLine();
        Console.WriteLine("Spelare 2, Var god skriv in ditt namn:");
        string player2 = Console.ReadLine();
        Console.Clear();

        // Presentation av spelare 1
        Console.WriteLine("Låt oss träffa vår första spelare!\n");
        PlayerPresenter.PresentPlayer(player1);

        Console.WriteLine("\nTryck på en tangent för att fortsätta till spelare 2...");
        Console.ReadKey();
        Console.Clear();

        // Presentation av spelare 2
        Console.WriteLine("Låt oss träffa vår andra spelare!\n");
        PlayerPresenter.PresentPlayer(player2);

        // Välkomna till Jeopardy och presentera reglerna
        PresentGameRules();

        // Starta spelet
        StartGame(player1, player2);
    }

    static void PresentGameRules()
    {
        Console.Clear();
        Console.WriteLine("\nRegler:");
        Console.WriteLine("För att få svara, tryck på din knapp så snabbt du kan:");
        Console.WriteLine("Spelare 1 använder tangenten 'A'.");
        Console.WriteLine("Spelare 2 använder tangenten 'L'.");
        Console.WriteLine("Ni har 7 sekunder på er att svara");
        Console.WriteLine("Du kan när som helst avsluta spelet genom att trycka Q.");
        Console.WriteLine("Tryck på valfri tangent för att börja spelet!");
        Console.ReadKey();
        Console.Clear();
    }

    static void PresentCategories()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("\nHär är dagens kategorier:\n");

        // Tabellhuvud med nummer och kategorier
        Console.WriteLine("+--------------------------+--------------------------+--------------------------+--------------------------+");
        Console.WriteLine("|      1. Famous Quotes    |   2. FILMTITLAR I EMOJI 🎬 |     3. GISSA LJUDET 🔊   |  4. SANT ELLER FALSKT    |");
        Console.WriteLine("+--------------------------+--------------------------+--------------------------+--------------------------+");

        Console.WriteLine($"|       {DisplayPoints(cat1_100)}        |       {DisplayPoints(cat2_100)}        |       {DisplayPoints(cat3_100)}        |       {DisplayPoints(cat4_100)}        |");
        Console.WriteLine($"|       {DisplayPoints(cat1_200)}        |       {DisplayPoints(cat2_200)}        |       {DisplayPoints(cat3_200)}        |       {DisplayPoints(cat4_200)}        |");
        Console.WriteLine($"|       {DisplayPoints(cat1_300)}        |       {DisplayPoints(cat2_300)}        |       {DisplayPoints(cat3_300)}        |       {DisplayPoints(cat4_300)}        |");
        Console.WriteLine($"|       {DisplayPoints(cat1_400)}        |       {DisplayPoints(cat2_400)}        |       {DisplayPoints(cat3_400)}        |       {DisplayPoints(cat4_400)}        |");
        Console.WriteLine($"|       {DisplayPoints(cat1_500)}        |       {DisplayPoints(cat2_500)}        |       {DisplayPoints(cat3_500)}        |       {DisplayPoints(cat4_500)}        |");

        Console.WriteLine("+--------------------------+--------------------------+--------------------------+--------------------------+");
    }

    static string DisplayPoints(int points)
    {
        if (points > 0)
        {
            return points.ToString();
        }
        else
        {
            return "    ";
        }
    }

    static void StartGame(string player1, string player2)
    {
        while (true)
        {
            PresentCategories();

            Console.WriteLine("Vänligen välj en kategori (1-4):");
            int categoryChoice = ReadCategoryChoice();

            Console.WriteLine("Vänligen välj poäng (100, 200, 300, 400, 500):");
            int pointsChoice = ReadPointsChoice();

            // Ställ frågan
            AskQuestion(categoryChoice, pointsChoice, player1, player2);
        }
    }

    static int ReadCategoryChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Vänligen ange ett giltigt kategori nummer (1-4):");
        }
        return choice;
    }

    static int ReadPointsChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 100 && choice != 200 && choice != 300 && choice != 400 && choice != 500))
        {
            Console.WriteLine("Vänligen ange ett giltigt poäng (100, 200, 300, 400, 500):");
        }
        return choice;
    }

    static void AskQuestion(int category, int points, string player1, string player2)
    {
        string question = "";
        string answer = "";

        switch (category)
        {
            case 1:
                switch (points)
                {
                    case 100:
                        question = "To be or not to be, that is the question.";
                        answer = "William Shakespeare?";
                        break;
                    case 200:
                        question = "May the Force be with you?";
                        answer = "Star Wars?";
                        break;
                    case 300:
                        question = "I have a dream";
                        answer = "Martin Luther King?";
                        break;
                    case 400:
                        question = "Det bästa med att vara barn är att man får lov att drömma.";
                        answer = "Vem var Astrid Lindgren?";
                        break;
                    case 500:
                        question = "En liten gnista kan sätta eld på ett stort hav?";
                        answer = "Vem var Alfred Nobel?";
                        break;
                }
                break;

            case 2: // FILMTITLAR I EMOJI 🎬
                switch (points)
                {
                    case 100:
                        question = "👨‍❤️‍👨🚢💔";
                        answer = "Titanic";
                        break;
                    case 200:
                        question = "🦁👑";
                        answer = "Lejonkungen";
                        break;
                    case 300:
                        question = "🐍⚡";
                        answer = "Harry Potter";
                        break;
                    case 400:
                        question = "🧙‍♂️💍";
                        answer = "Sagan om ringen";
                        break;
                    case 500:
                        question = "🏹🎯";
                        answer = "Hunger Games";
                        break;
                }
                break;

            case 3: // GISSA LJUDET 🔊
                switch (points)
                {
                    case 100:
                        question = "Super Mario-ljud";
                        answer = "Super Mario";
                        break;
                    case 200:
                        question = "The Raiders March från Indiana Jones";
                        answer = "Indiana Jones";
                        break;
                    case 300:
                        question = "Ljudet av Hesa Fredrik";
                        answer = "Hesa Fredrik";
                        break;
                    case 400:
                        question = "The Flintstones-tema";
                        answer = "The Flintstones";
                        break;
                    case 500:
                        question = "Skräckfiol-ljud";
                        answer = "Horror Violin String Screech";
                        break;
                }
                break;

            case 4: // NOSTALGISKA 80-TALS HITS 🎶
                switch (points)
                {
                    case 100:
                        question = "Människor nös snabbare än en gepard kan springa.";
                        answer = "Sant";
                        break;
                    case 200:
                        question = "Den mest sålda singeln på 80-talet var 'Thriller'.";
                        answer = "Falskt";
                        break;
                    case 300:
                        question = "'Livin' on a Prayer' av Bon Jovi";
                        answer = "Sant";
                        break;
                }
                break;
        }

        Console.Clear();
        Console.WriteLine($"Fråga för {points} poäng: {question}");
        Timer(7);

        Console.WriteLine($"Rätt svar är: {answer}");
        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
        Console.ReadKey();
    }

    static void Timer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Tid kvar: {i} sekunder");
            Thread.Sleep(1000);
        }
    }
}
