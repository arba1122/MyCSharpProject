using System;


    public class Player
    {
        public string Name { get; set; }

        // Konstruktor för att skapa en ny spelare 
        public Player(string name)
        {
            Name = name;
        }

        // Presenterar spelaren 
        public void PresentPlayer()
        {
            if (Name.ToLower().Contains("krister"))
            {
                Console.WriteLine($"Här har vi {Name} – en göteborgare som förvandlat snö till hav och fjäll till kust – men hans hjärta slår fortfarande för Östersund!\n" +
                    $"{Name} är inte bara en skicklig spelare; han har även en imponerande bakgrund som lärare, författare och mjukvaruutvecklare.\n" +
                    "Med sin passion för programmering och databaser utbildar han både elever och andra lärare och har skrivit skolböcker inom datorprogrammering.\n" +
                    "Men det slutar inte där! Krister är också en förespråkare för mental hälsa och välbefinnande genom sin undervisning i meditation och arrangemang av tysta retreater.\n" +
                    $"Som spelare är {Name} kreativ och innovativ, alltid redo att samarbeta i team och utveckla nya idéer.\n" +
                    "Hans kärlek till skönlitteratur ger honom ett unikt perspektiv på spelet, vilket gör varje match ännu mer spännande.\n" +
                    $"Låt oss ge ett stort varmt välkomnande till {Name}!");
            }
            else if (Name.ToLower().Contains("jonathan"))
            {
                Console.WriteLine($"{Name} – en riktig stjärna från Borås! \n" +
                    $"{Name} är inte bara en stolt boråsare, han är också en mästare i frisbeegolf! \n" +
                    "Med en frisbee i handen och ett leende på läpparna tar han sig an banorna som en riktig proffs.\n" +
                    "Men efter en lång dag på banan? Ja, då är det dags för en festmåltid... av proteinpannkakor! \n" +
                    "Visst, hamburgare må vara hans drömmat, men i verkligheten står han och vänder proteinpannkakor i köket.\n" +
                    "Kanske hoppas han att om han äter tillräckligt många, kommer de att förvandlas till hamburgare i hans drömmar? \n" +
                    $"{Name} är även en hängiven supporter av FC Barcelona.\n" +
                    "Han kan alla lagets hemligheter och har mer än en gång skrikit av glädje när de gör mål – allt medan han planerar sin nästa pannkaksfest!\n" +
                    "Utöver sina sportiga intressen har {Name} en skarp hjärna för investeringar.\n" +
                    "Medan han drömmer om hamburgare och analyserar aktiemarknaden, har han hittat den perfekta balansen mellan nöje och arbete – och kanske en dag kommer hans investeringar att ge honom råd att köpa den största hamburgaren någonsin!\n" +
                    "Tidigare var han specialpedagog, men nu dyker han ner i den spännande världen av objektorienterad programmering med en passion för artificiell intelligens. \n" +
                    "Han siktar på att bli en expert och kanske en dag skapa en AI som kan laga de perfekta proteinpannkakorna – eller i alla fall hjälpa honom att nå sina hamburgerdrömmar!\n" +
                    $"Så, låt oss ge ett stort och varmt välkomnande till {Name}!");
            }
            else
            {
                Console.WriteLine($"Låt oss välkomna {Name}! \n\n" +
                    $"{Name} är mästaren på att svara \"jag vet inte\" i spelet – men oroa er inte, hen har en exceptionell förmåga att gissa rätt på första försöket! \n\n" +
                    $"När {Name} inte spelar Jeopardy, kan du hitta hen med en stor kopp kaffe och en ännu större dröm om att vinna på lotteri – för vem behöver en plan B, va? \n\n" +
                    $"Ge ett varmt välkomnande till {Name}!");
            }
        }
    }
}
