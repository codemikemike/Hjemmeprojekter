namespace MyCarApp;

class Program
{
    static void
        Main(string[] args) //args giver mulighed for at modtage input fra kommandolinjen i stedet for Console.ReadLine() f.eks.
    {
        /*
        BiloplysningsApp
        Terminologi: Der er blevet reflekteret over "applikation", "instruktion", "sætning (statement)" og "kodeblok" Opg1.1
        Jeg har oprettet MyCarApp projektet her i JetBrain Rider Opg1.2
        Jeg har fjernet standard beskeden med "Hello World" og initialiseret variablerne i koden samt tilføjet sætninger Opg1.3
        Indhent oplysninger fra brugeren: De faste værdier er fjernet og erstattet med brugerinput og samlet udskrift Opg1.4
        Udskrivning af bilens oplysninger i en sætning Opg1.5
        Debugging og Step Over (F10) til at gennemgå koden trin for trin og add breakpoints og kontroller med dem kodens virke for hver step Opg1.6

        Shift + F9 starter debugging, F10 til Step Over (trin for trin), Se Debug tool Window, Shift F5 Stopper Debug

        Udvidet biloplysninger tilføjet som variabler og skrive- læsefunktioner samt brændstofberegning Opg2.2
        Beregning af brændstofforbrug og brændstofomkostninger Opg2.2
        Opg2.3

         Nyttige Keyboard shortcuts på MAC:
         -Tryk på Cmd + Shift + R for at åbne Find and Replace in Path
         -Hold Shift + Option (⌥) nede og klik på hver Console.WriteLine();-linje, som skal rykkes
         -Tryk på ⌘ (Cmd) + D flere gange for at vælge flere forekomster ét ad gangen. (ved små ændringer)
         -Tryk på ⌘ (Cmd) + Shift + R for at åbne "Find and Replace in Path". (store ændringer)
         */

        //Variablerne med biloplysninger Opg.1
        //Variablerne er ændret til "tomme" fordi opgaven ændrede sig
        //Variablerne er ændret fra eksplicitte typer til implicitte typer med var
        var bilMærke = ""; //Jeg har fjernet mellemrum i "" da det støjer
        var bilModel = ""; //Jeg har fjernet mellemrum i "" da det støjer
        // Hvad med motorstørrelse??
        var bilÅrgang = 0;
        var gearType =
            ' '; //Her skal der dog være mellemrum, man kunne også indsætte et X der viser man ikke har sat noget ind

        //Variablerne med udvidet biloplysninger Opg.2
        var brændstofType = "";
        var kilometerPerLitre = 0.0;
        var brændstofPris = 0.0;
        var kilometerStand = 0; //Burde denne være double??? Nogen skriver komma i stedet for punktum! //Denne er koblet sammen med kørtDistance

        //Endnu en udvidelse Opg2.1.2
        var kørtDistance = 0; //køretur
        var brændstofbehov = 0.0;
        var turPris = 0.0;
        var kilometerstandEfter = 0;

        //Dette er en introtekst
        Console.WriteLine("=== Velkommen til biloplysnings programmet ==="); //Laver tydelig header med ===
        Console.WriteLine("Du vil blive bedt om at indtaste oplysninger om din bil.");
        Console.WriteLine(); // Tom linje for bedre læsbarhed


        //Skriver Variablerne Ud
        Console.WriteLine($"Indtast dit bilmærke:");
        bilMærke = Console
            .ReadLine(); // Brug Console.ReadLine til at læse brugerens input og gemme det i de relevante variabler.

        Console.WriteLine($"Indtast din bilmodel:");
        bilModel = Console.ReadLine();

        //Konvertere det til int ved brug af Convert.ToInt32(Console.ReadLine()).
        Console.WriteLine($"Indtast bilens årgang:");
        bilÅrgang = Convert.ToInt32(Console
            .ReadLine()); //Hvis brugeren indtaster noget, der ikke er et tal, vil Convert.ToInt32() give en fejl. Bedre at bruge int.TryParse()

        Console.WriteLine($"Indtast A for Automat Gear eller M for Manuel Gear:");
        gearType = Console.ReadLine()[0];

        Console.WriteLine(); //En tom linje for bedre læsbarhed

        Console.WriteLine(
            $"Indtast bilens brændstoftype D for Diesel eller B for Benzin:"); //Hvad med at tilføje hybrid eller EL???
        brændstofType = Console.ReadLine();

        Console.WriteLine("Indtast hvad bilen kører per liter:");
        kilometerPerLitre =
            Convert.ToDouble(Console.ReadLine()); //Pas på med at bruge Convert.ToInt32 når det er double

        Console.WriteLine("Indtast prisen i kroner per liter brændstof:");
        brændstofPris = Convert.ToDouble(Console.ReadLine()); //Pas på med at bruge Convert.ToInt32 når det er double

        Console.WriteLine(
            "Indtast hvor mange kilometer bilen har kørt:"); //Min mor skrev. i stedet for, 322.000 og det gav error??
        kilometerStand = Convert.ToInt32(Console.ReadLine()); //int 

        Console.WriteLine(""); //En tom linje for bedre læsbarhed

        //Introtekst om brændstofsøkonomien når man kører i bilen
        Console.WriteLine("Brændstofsberegning af din bil");
        Console.WriteLine(); // Tom linje for bedre læsbarhed

        Console.WriteLine("Intast den ønskede køreturs distance i KM:");
        kørtDistance = Convert.ToInt32(Console.ReadLine()); //Har gjort så man kan indtaste decimaler

        //Brændstofberegninger 
        brændstofbehov = kørtDistance / kilometerPerLitre; //beregning1
        turPris = brændstofbehov * brændstofPris; //beregning2
        kilometerstandEfter = kilometerStand + kørtDistance; //Opg2.3

        Console.WriteLine(); // Tom linje for bedre læsbarhed 

        //Udskrivning af bilens oplysninger samlet i een sætning
        //Har tilføjet $ så variablerne kan indhentes direkte 
        Console.WriteLine("\nBilens oplysninger er: ");
        Console.WriteLine(bilMærke + " " + bilModel + " fra " + bilÅrgang + " med geartype " + gearType);
        Console.WriteLine("Den kører på " + brændstofType + " der koster " + brændstofPris +
                          " DKKR pr liter."); //Hvordan ændre jeg så D for Diesel bliver udskrevet som Diesel i stedet for D?????
        Console.WriteLine("Bilen har i alt kørt " + kilometerStand + " KM");
        Console.WriteLine("For en tur på {0} KM skal du bruge {1:F2} liter brændstof.", kørtDistance,
            brændstofbehov); //hentet fra beregning1 //Har tilføjet string.Format() og {} og F2 for decimaler. Opg
        Console.WriteLine(string.Format("Brændstofudgifterne for {0} km er {1:F2} DKK.", kørtDistance,
            turPris)); //hentet fra beregning2 //Har tilføjet string.Format() og {} og F2 for decimaler. Opg 
        Console.WriteLine("Bilens kilometerstand efter køreturen er " +
                          kilometerstandEfter); //Udskriver alle bilens oplysninger og den nye kilometerstand opg2.1.4

        Console.WriteLine(); // Tom linje for bedre læsbarhed
        
        // Tabeloverskrift (lavet med hjælp)
        Console.WriteLine(string.Format("{0,-15} {1,-15} {2,15}", "BilMærke", "BilModel", "Kilometerstand"));
        Console.WriteLine("".PadLeft(50, '-')); //stiplet linje med 50 stk -
        Console.WriteLine(string.Format("{0,-15} {1,-15} {2,15}", bilMærke, bilModel, kilometerstandEfter));// Tabelrække 
        

    }

}