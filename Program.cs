using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System;
using projekt;
namespace ConsoleApp5;
using DetAndetProjekt;
using Program123.DetAndetBil;
using static DetAndetProjekt.Bog;


internal class Program
{
   

    private static void Main(string[] args)
    {

        Console.Title = "C# opgaver";

        int exit = 0;
        while (exit == 0)
        {
            Console.Clear();
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("*.*.* Velkommen til mine C# opgaver *.*.*");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine();
            Console.WriteLine(" Indtaste et nummer for at vælge opgaven:");
            Console.WriteLine("1: variabler:");
            Console.WriteLine("2: Strings:");
            Console.WriteLine("3: Aritmetiske udtryk:");
            Console.WriteLine("4: If-else statements:");
            Console.WriteLine("5: Switch case:");
            Console.WriteLine("6: Loops:");
            Console.WriteLine("7: Udvidet kontrolstrukturer:");
            Console.WriteLine("8: Metoder og instanser: ");
            Console.WriteLine("9: Returtyper og parametre: ");
            Console.WriteLine("10: Instancevariabler: ");
            Console.WriteLine("11: Nedarvning: ");
            Console.WriteLine("12: Konstruktors: ");
            Console.WriteLine("13: Arrays: ");
            Console.WriteLine("14: Gennemløb af arrays: ");
            Console.WriteLine("15: Public, Private og Protected: ");
            Console.WriteLine("16: Rapport: ");
            Console.WriteLine("0: Exit");

            // Menu switch 
            string valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    variable();
                    break;

                case "2":
                    strings();
                    break;


                case "3":
                    Aritmetiske();
                    break;

                case "4":
                    elseogif();
                    break;
                case "5":
                    switchs();
                    break;
                case "6":
                    Loops();
                    break;

                case "7":
                    udvidet();
                    break;
                case "8":
                    Metoder();
                    break;
                case "9":
                   returtyper();
                    break;
                case "10":
                    Instance();
                    break;
                case "11":
                    Nedarvining11();
                    break;
                case "12":
                    konstruktors();
                    break;
                case "13":
                    Arrays();
                    break;
                case "14":
                    Gennemløb();
                    break;
                case "15":
                    Publics();
                    break;
                case "16":
                    Rapport();
                    break;

                case "0":
                    exit = 1;
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    Console.ReadKey();
                    break;
            }





        }

    }

    /// <summary>
    /// //////////////// Varialbe ////////////////////
    /// </summary>
    private static void variable()
    {





        int back = 0;
        while ((back == 0))

        {

            Console.Clear();

            Console.WriteLine("*** Variables Opgaver ***");
            Console.WriteLine();
            Console.WriteLine("1. Variable opg 1.");
            Console.WriteLine("2. Variable opg 2.");
            Console.WriteLine("3. Variable opg 3.");
            Console.WriteLine("4. Variable opg 4.");
            Console.WriteLine("5. Variable opg 5.");
            Console.WriteLine("6. Variabler i udtryk opg 1.");
            Console.WriteLine("7. Variabler i udtryk opg 2.");
            Console.WriteLine("8. Boolske variable opg 1.");
            Console.WriteLine("0. Tilbage ");



            string valg = Console.ReadLine();
            switch (valg)
            {

                case "1":

                    Console.Clear();


                    int tal1 = 5;
                    int tal2 = 3;
                    Console.WriteLine("Tal1 er 5");
                    Console.WriteLine("Tal2 er 3");

                    
                    Console.ReadKey();

                    break;


                case "2":
                    Console.Clear();

                    string Navn = "Søren";
                    int Alder = 16;
                    double Penge = 1234.34;

                    Console.WriteLine("Jeg hedder " + Navn + " er " + Alder + " år gammel og har tjent " + Penge + " kr. På at lappe cykler");

                    Console.ReadKey();
                    break;

                case "3":
                    Console.Clear();


                    double kage = 23.56;
                    double øl = 34.67;
                    double Pølse = 65.34;


                    Console.WriteLine($"Kage: {kage}kr.             Øl:  {øl} kr.          Pølse: {Pølse} kr.");

                    double result = kage + øl + Pølse;

                    Console.WriteLine($"I alt: {result:F2}");

                   
                    Console.ReadKey();
                    break;


                case "4":
                    Console.Clear();

                    string Navn1 = "Hamid";
                    double Alder1 = 28;

                    Console.WriteLine($"Jeg hedder {Navn1} og er {Alder1} år gammel");


                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();

                    Console.WriteLine(" Indtaste tal for at bergene arealet af cirklen: ");

                    double cirkel = double.Parse(Console.ReadLine());
                    double sum = double.Pi * Math.Pow(cirkel, 2);

                    Console.WriteLine($"Den er arealet af cirklen: {sum:F2}");

                    
                    Console.ReadKey();
                    break;


                case "6":
                    Console.Clear();
                    int sum0 = 10;
                    int sum11 = 15;
                    int sum22 = 20;

                    int result1 = sum0 + sum11 - sum22 * sum11 / sum0 % sum22;
                    Console.WriteLine(result1);

                    
                    Console.ReadKey();

                    break;

                case "7":

                    Console.Clear();

                    double tal = 10;
                    int tall1 = 4;
                    double tall2 = 5;

                    double resullt = tal + tall1 - tall2;

                    Console.WriteLine($"variablet tal er {tal} og tal + tal1 er : {tal + tall1}");
                    Console.WriteLine($"Variablet tal1 er {tall1} og tal 1 * tal 2 er : {tall1 * tall2}");
                    Console.WriteLine($"Variablet tal 2 er {tall2} og tal / tal 2 er : {tal / tall2}");
                    Console.WriteLine($"resultat tal + tal1 - tal2 er: {resullt}");


                    Console.ReadKey();
                    break;


                case "8":
                    Console.Clear();
                    int var1 = 7;
                    int var2 = 15;
                    Boolean resultt = var1 > var2;
                    Console.WriteLine(resultt);

                    Console.WriteLine(" Her er jeg ændrete værdierne!");
                    int var11 = 17;
                    int var22 = 15;
                    Boolean resultt1 = var11 > var22;
                    Console.WriteLine(resultt1);
                    Console.ReadKey();

                    break;




                case "0":
                    back = 1;
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    Console.ReadKey();
                    break;

            }

        }


    }


    private static void strings()
    {

        int back = 0;
        while (back == 0)
        {
            Console.Clear();
            Console.WriteLine("***Strings Opgaver***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1:");
            Console.WriteLine("Opgave 2:");
            Console.WriteLine("Opgave 3:");
            Console.WriteLine("Opgave 4:");

            Console.WriteLine("0: Tilbage");




            string valg = Console.ReadLine();
            switch (valg)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine(" string Navn2 = \"Hamid\"; ");
                    Console.WriteLine(" int Alder2 = 28 + 30; ");
                    Console.WriteLine(" double penge = 9.580 + 10.320; ");

                    
                    Console.ReadKey();
                    break;

                case "2":

                    Console.Clear();

                    Console.WriteLine(" string Navn2 =\"Hamid\" +\"Jacob\";");
                    Console.WriteLine(" int Alder2 = 28 + 30; ");
                    Console.WriteLine(" double penge = 9.580 + 10.320; ");

                    Console.ReadKey();
                    break;



                case "3":
                    Console.Clear();

                    string måndel = "December";
                    double dag = 24;
                    Console.WriteLine($"I dag har vi den {dag}.{måndel}");


                    Console.ReadKey();
                    break;

                case "4":
                    double penge = 200.50;
                    string text = "Jeg har ";
                    string text1 = "kr. i banken.";

                    Console.WriteLine(text + penge + text1);
                    Console.ReadKey();
                    break;



                case "5":



                    break;

                case "0":
                    back = 1;
                    break;


                default:
                    Console.WriteLine("Ugyldit valg. Prøv igen.");

                    break;
            }
        }
    }
    /// <summary>
    /// ///////////////////////////////////////////////Sritmetiske////////////////////////////////////////////////
    /// </summary>
    private static void Aritmetiske()
    {


        int back = 0;
        while (back == 0)
        {
            Console.Clear();
            Console.WriteLine("1: Aritmetiske udtryk opg:");

            Console.WriteLine("0: Tilbage");



            string valg = Console.ReadLine();
            switch (valg)
            {

                case "1":

                    Console.Clear();

                    double sum = 2 + 1 * 2;
                    Console.WriteLine(sum);

                    double sum1 = (2 + 1) * 2;
                    Console.WriteLine(sum1);

                    double sum2 = 5 / 2;
                    Console.WriteLine(sum2);

                    double sum3 = 8 % 3;
                    Console.WriteLine(sum3);

                    double sum4 = 1 - 5;
                    Console.WriteLine(sum4);


                    Console.ReadKey();
                    break;

                case "0":
                    back = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;




            }



        }


    }

    private static void elseogif()
    {
        int tilbag = 0;
        while (tilbag == 0)
        {
            Console.Clear();
            Console.WriteLine("***if-els Opgaver***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("Opgave 2: ");
            Console.WriteLine("Opgave 3: ");
            Console.WriteLine("Opgave 4: ");
            Console.WriteLine("Opgave 5: ");
            Console.WriteLine("Opgave 6: ");
            Console.WriteLine("Opgave 7: ");
            Console.WriteLine("0. Tilba: ");


            double vælge = double.Parse(Console.ReadLine());
            switch (vælge)
            {
                case 1:
                    Console.Clear();
                    int tal1 = 50;
                    int tal2 = 50;
                    int result = tal1 + tal2;

                    if (result > 100)
                    {
                        Console.WriteLine("Summen er større end 100!");

                    }

                    else if (result == 100)
                    {
                        Console.WriteLine("Summen er 100");
                    }

                    else
                    {
                        Console.WriteLine("summen er mindre end 100!");

                    }
                    Console.ReadKey();


                    break;


                case 2:

                    Console.WriteLine(" Indtast den alder: ");
                    double alder = double.Parse(Console.ReadLine());

                    if (alder > 57)
                    {
                        Console.WriteLine(" Du er for gammel! ");
                    }


                    else
                    {
                        Console.WriteLine("Du er ikke for gammel!");
                    }
                    Console.ReadKey();


                    break;


                case 3:

                    Console.Clear();

                    Console.WriteLine("Indtaste din alder: ");
                    int alder1 = int.Parse(Console.ReadLine());

                    if (alder1 > 60)
                    {
                        Console.WriteLine("Du er for gammel");
                    }

                    else if (alder1 >= 50)
                    {
                        Console.WriteLine("Du er hverken for gammel eller for ung");
                    }
                    else
                    {
                        Console.WriteLine("Du er for ung");

                    }
                    Console.ReadKey();

                    break;


                case 4:
                    Console.Clear();
                    Console.WriteLine("Indtaste navn: ");
                    string navn = Console.ReadLine();


                    if (navn == "Hamid")
                    {
                        Console.WriteLine("Velcommen!");
                    }

                    else
                    {
                        Console.WriteLine("Forkert!");

                    }


                    Console.WriteLine("Indtaste brugernanve: ");
                    string brug = Console.ReadLine();

                    if (brug == "hh5")
                    {
                        Console.WriteLine("Velkommen brgernavnet");
                    }
                    else
                    {
                        Console.WriteLine("Forkert!");

                    }


                    Console.WriteLine("Indtaste password: ");
                    int pass1 = int.Parse(Console.ReadLine());
                    if (pass1 == 1234)
                    {
                        Console.WriteLine("Korrekt!");
                    }
                    else
                    {
                        Console.WriteLine("Forkert!");

                    }

                    Console.ReadKey();

                    break;

                case 5:


                    Console.Clear();

                    Console.WriteLine("Hvad er din brugenavne: ");
                    String brugernavne = Console.ReadLine();


                    if (brugernavne == "Hamid")
                    {
                        Console.WriteLine("Hvad er din password: ");
                        int pass = int.Parse(Console.ReadLine());

                        if (pass == 1234)
                        {
                            Console.WriteLine("Velkommen brugerens navn");
                            Console.WriteLine("Indtaste din alder: ");
                            int alderr = int.Parse(Console.ReadLine());


                            if (alderr > 60)
                            {
                                Console.WriteLine("Du er for gammel");
                            }

                            else if (alderr >= 50)
                            {
                                Console.WriteLine("Du er hverken for gammel eller for ung");
                            }
                            else
                            {
                                Console.WriteLine("Du er for ung");

                            }
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Passwordet er forkert!");
                        }
                    }


                    else
                    {
                        Console.WriteLine("Brugernavent er forkert");
                    }
                    Console.ReadKey();


                    break;


                case 6:
                    Console.Clear();
                    Console.WriteLine("Fradrage prisen pr.km 25 km til 120 km er 1,93 kr.");
                    Console.WriteLine("Fradrage prisen over 121 km pr.dag er 0,97 kr.");
                    Console.WriteLine("Hvor mange km der køre hver dag til og fra arbejde:");
                    int kør = int.Parse(Console.ReadLine());

                    if (kør <= 24)
                    {
                        Console.WriteLine("Du er under 25 km pr.dag. Så får du ikke noget fradrag.");
                    }
                    if (kør <= 120)
                    {

                        double resultt = 0;

                        resultt = (kør - 24) * 1.93;

                        Console.WriteLine("Fradraget er 1,93 kr pr.dag");
                        Console.WriteLine($"Du får: {resultt:F2} Kr. pr.dag");
                        Console.ReadKey();
                        return;
                    }

                    if (kør >= 121)
                    {
                        Console.WriteLine("Fradraget er 0,97 kr. pr .dag");

                        double result1 = 0;

                        result1 = 96 * 1.93 + (kør - 120) * 0.97;

                        Console.WriteLine($"Du får: {result1:F2} kr. pr.dag");
                        Console.ReadKey();
                        return;

                    }

                    else
                    {
                        Console.WriteLine("Du indtaste forkert!");
                    }


                    Console.ReadKey();

                    break;

                case 7:
                    Console.Clear();

                    Console.Title = "Festen";

                    Console.WriteLine("Hvilken farve foretrækker du! vælger mellem rød, grøn, blå og gul.");
                    string farve = Console.ReadLine().ToLower();


                    if (farve == "rød")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;

                    }

                    else if (farve == "grøn")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }


                    else if (farve == "blå")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }



                    else if (farve == "gul")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    Console.Clear();


                    Console.WriteLine("Hvor gammel er du?");
                    int aldeer = int.Parse(Console.ReadLine());

                    if (aldeer >= 18)
                    {
                        Console.WriteLine("Velkommen til cocktailbaren");
                    }

                    else if (aldeer < 18)
                    {
                        Console.WriteLine("Velkommen til sodavandsbaren");
                    }

                    else
                    {
                        Console.WriteLine(" Forkert tast!");
                    }




                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Programmet lukker automtisk om 10 sekunder!");
                    Thread.Sleep(10000);
                    Environment.Exit(0);


                    Console.ReadKey();


                    break;

                case 0:

                    tilbag = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;

            }
        }
    }


    private static void switchs()
        {
        int tilbag = 0;
        while (tilbag == 0)
        {
            Console.Clear();
            Console.WriteLine("***Switch Case Opgaver***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("Opgave 2: ");
            Console.WriteLine("0: Tilbage");


            double vælge = double.Parse(Console.ReadLine());
            switch (vælge)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Indtaste en værdi mellem 1-6: ");
                    int værdi = int.Parse(Console.ReadLine());


                    switch (værdi)
                    {
                        case 1:

                            Console.WriteLine(" Du har tastet + tallet");

                            break;

                        case 22:

                            Console.WriteLine(" Du har tastet + tallet");

                            break;
                        case 3:

                            Console.WriteLine(" Du har tastet + tallet");

                            break;

                        case 4:

                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("***TILLYKKE DU HAR VUNDET***");


                            break;

                        case 5:

                            Console.WriteLine(" Du har tastet + tallet");

                            break;
                        case 6:

                            Console.WriteLine(" Du har tastet + tallet");

                            break;

                        default:
                            Console.WriteLine("Du har tastet forkert tal. Tallet skal være mellem 1 og 6! ");
                            break;

                    }

                    Console.WriteLine("Programmet lukker efter 10 sekunder!");

                    Thread.Sleep(10000);
                    Environment.Exit(0);

                    Console.ReadKey();


                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("Velkommen menu drink!");

                    Console.WriteLine();
                    Console.WriteLine("Vælge en af drink!");
                    Console.WriteLine("1: Isbjørn");
                    Console.WriteLine("2: Champagnebrus");
                    Console.WriteLine("3: Tequila Sunrise");
                    Console.WriteLine("4: Mojito");
                    Console.WriteLine("5: Brandbil");
                    Console.WriteLine("6: Filur");
                    double vælgee = double.Parse(Console.ReadLine());
                    switch (vælgee)
                    {
                        case 1:
                            Console.WriteLine("**Isbjørn***");
                            Console.WriteLine("Prisen er: 27.50");
                            break;

                        case 2:
                            Console.WriteLine("*** Champagnebrus ***");
                            Console.WriteLine("Prisen er: 47.50");
                            break;
                        case 3:
                            Console.WriteLine("***  Tequila Sunrise ***");
                            Console.WriteLine("Prisen er: 55.00");
                            break;
                        case 4:
                            Console.WriteLine("*** Mojito ***");
                            Console.WriteLine("Prisen er: 33.80");
                            break;
                        case 5:
                            Console.WriteLine("*** Brandbil ***");
                            Console.WriteLine("Prisen er: 89.90");
                            break;
                        case 6:
                            Console.WriteLine("*** Filur ***");
                            Console.WriteLine("Prisen er: 60.33");
                            break;
                        default:
                            Console.WriteLine("Du indtaste forkert!");
                            break;

                    }
                    Console.ReadKey();
                    break;

                case 0:
                    tilbag = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;




            }



        }
        


        }


    private static void Loops()
    {
        int tilbage = 0;
        while(tilbage == 0)
        {
            Console.Clear();
            Console.WriteLine("***Loops Opgaver***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("Opgave 2: ");
            Console.WriteLine("Opgave 3: ");
            Console.WriteLine("Opgave 4: ");
            Console.WriteLine("Opgave 5: ");
            Console.WriteLine("Opgave 6: ");
            Console.WriteLine("Opgave 7: ");
            Console.WriteLine("Opgave 8: ");
            Console.WriteLine("Opgave 9: ");
            Console.WriteLine("0. Tilba: ");
            double vælge = double.Parse(Console.ReadLine());

            switch (vælge)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Loopes med for!");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Loopes med While!");
                    int r = 0;
                    while (r < 10)
                    {
                        Console.WriteLine(r);
                        r++;
                    }

                    Console.ReadKey();


                    break;

                case 2:
                    Console.Clear();

                    Console.WriteLine("Den er for loops");

                    for (int i = 0; i < 100; i++)
                    {

                        Console.WriteLine(i);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Den er Whil");

                    int b = 0;
                    while (b < 100)
                    {
                        Console.WriteLine(b);
                        b++;
                    }
                    Console.ReadKey();




                    break;
                case 3:
                    Console.Clear();


                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"5 * {i} = " + 5 * i);


                    }
                    Console.ReadKey();




                    break;
                case 4:
                    Console.Clear();

                    Console.WriteLine("Den er med for Loops");
                    for (int i = 20; i > 0; i--)
                    {
                        Console.WriteLine(i);

                    }

                    Console.WriteLine("Den er med While Loops");
                    int u = 20;
                    while (u > 0)
                    {
                        Console.WriteLine(u);
                        u--;
                    }
                    Console.ReadKey();




                    break;
                case 5:
                    Console.Clear();


                    for (int i = 1; i <= 10; i++)
                    {

                        Console.Write($"{i} * 7  =  {i * 7} ");
                        if (i % 2 == 0) Console.WriteLine();

                    }



                    Console.ReadKey();



                    break;

                case 6:
                    Console.Clear();

                    Console.WriteLine("Indtaste din tal for at beregne: ");
                    int tal = int.Parse(Console.ReadLine());


                    for (int i = 0; i < 10; i++)
                    {
                        int result = tal * i;

                        Console.WriteLine($" {tal} * {i} = {result}");
                    }
                    Console.ReadKey();



                    break;
                case 7:
                    Console.Clear();

                    int startx = 20;
                    int starty = 4;

                    int sluttex = 30;
                    int sluttey = 8;

                    for (int i = startx; i <= sluttex; i++)
                    {

                        Console.SetCursorPosition(startx, i);
                        Console.WriteLine("*");


                    }

                    for (int i = startx + 1; i <= sluttey; i++)
                    {

                        Console.SetCursorPosition(starty, i);
                        Console.Write("*");
                        Console.SetCursorPosition(i, sluttey);
                        Console.Write("*");


                    }


                    for (int i = starty; i <= sluttey; i++)
                    {


                        Console.SetCursorPosition(i, sluttey);
                        Console.Write("*");


                    }


                    Console.ReadKey();

                    break;

                case 8:
                    Console.Clear();

                    Console.SetCursorPosition(50, 15);
                    Console.WriteLine("Hamid Heidari");
                    Console.ReadKey();


                    break;



                case 9:
                    Console.Clear();

                    Console.WriteLine("Indtaste start X: ");
                    int startx1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Indtaste start Y: ");
                    int starty1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Indtaste slutte X: ");
                    int sluttex1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Indtaste slutte y: ");
                    int sluttey1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Indtaste dit navn: ");
                    string navn = (Console.ReadLine());

                    for (int i = startx1; i <= sluttex1; i++)
                    {

                        Console.SetCursorPosition(i, startx1);
                        Console.Write("*");

                    }
                    for (int i = starty1; i <= sluttey1; i++)
                    {

                        Console.SetCursorPosition(i, starty1);
                        Console.Write("*");

                        Console.SetCursorPosition(sluttey1, i);
                        Console.WriteLine("*");
                    }

                    for (int i = startx1; i <= sluttex1; i++)
                    {
                        Console.SetCursorPosition(i, sluttex1);
                        Console.Write("*");
                    }

                    // Beregn positionen for navnet, så det placeres i midten af rammen
                    int nameX = startx1 + (sluttex1 - startx1) / 2 - navn.Length / 2;
                    int nameY = starty1 + (sluttey1 - starty1) / 2;

                    // Placer navnet
                    Console.SetCursorPosition(nameX, nameY);
                    Console.Write(navn);

                    // Hold konsollen åben efter udførelse
                    Console.SetCursorPosition(0, sluttey1 + 2);
                    Console.ReadKey();


                    Console.ReadKey();

                    break;




                case 0:
                    tilbage = 1;
                    break;
                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;

            }


        }
    }


    private static void udvidet()
    {

        int tilbag = 0;

        while (tilbag == 0)
        {
            Console.Clear();
            Console.WriteLine("***Udvidet Kontrolstrukturer Opgaver***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("Opgave 2: ");
            Console.WriteLine("Opgave 3: ");
            Console.WriteLine("Opgave 4: ");
            Console.WriteLine("Opgave 5: ");
            
            Console.WriteLine("0. Tilba: ");


            double vælge = double.Parse(Console.ReadLine());
            switch (vælge)
            {
                case 1:

                    Console.Clear ();

                    Console.WriteLine("Loope med For");

                    for (int i = 0; i <= 10; i++)
                    {

                        int result = i * 3;

                        if (result == 21)
                        {


                            Console.WriteLine("Loopen er nu stopet");

                            break;

                        }

                        Console.WriteLine($"{i} * 3 = {result}");



                    }

                    Console.ReadKey();

                    break;
                case 2:

                    Console.Clear();
                    Console.WriteLine("Loope med While");
                    int tal = 0;

                    while (tal < 10)
                    {

                        int result = tal * 4;

                        Console.WriteLine($" {tal} * 4 = {result}");
                        tal++;

                        if (result == 16)
                        {

                            Console.WriteLine("Loopen er nu stoppet");
                            break;

                        }

                    }

                    Console.ReadKey();

                    break;
                case 3:

                    Console.Clear();

                    Console.WriteLine("Fradraget 25-100 km 1.54 øre pr.km og over 100 0,77 øre pr. km");
                    Console.WriteLine("Indtast KM for udregner befordringsfradrag!");
                    double km = double.Parse(Console.ReadLine());

                    double fradrag = 0;

                    double km1 = 1.54;
                    double km2 = 0.77;

                    double result1 = (km - 24) * km1;
                    double result2 = (100 - 24) * km1;
                    double result3 = (km - 100) * km2;

                    fradrag = result2 + result3;


                    if (km < 24 || km == 0)
                    {


                        Console.WriteLine($"Du får ingen fradrag: ");

                    }

                    else if (km >= 25 && km <= 100)
                    {

                        Console.WriteLine($"Fradraget pr. km er 1.54 kr");
                        Console.WriteLine($"Du får {result1} kr.");
                    }

                    else if (km >= 101)
                    {
                        Console.WriteLine($"Fradraget pr. km er 0.77 kr");
                        Console.WriteLine($"Du får {fradrag} kr.");
                    }


                    else
                    {
                        Console.WriteLine(" Du tastede forkert!");


                    }


                    Console.ReadKey();

                    break;
                case 4:

                    Console.Clear();
                    Console.WriteLine("********************************************");
                    Console.WriteLine(" ***** Velkommen til skatbetaling ***** ");
                    Console.WriteLine("********************************************");
                    Console.WriteLine();
                    Console.WriteLine(" bundskat 30% ==> Over 42.000 kr ");
                    Console.WriteLine(" mellemska 6% ==> Over 280.000 kr ");
                    Console.WriteLine(" topskat 15% ==> Over 390.000 kr ");
                    Console.WriteLine();
                    Console.WriteLine(" Indtast dit beløb: ");
                    double indkomst = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    double bundskat = 0;
                    double mellemskat = 0;
                    double topskat = 0;

                    double totalskat = 0;


                    if (indkomst < 24000)
                    {
                        Console.WriteLine("Du skal ikke betale  skat");
                    }

                    else if (indkomst >= 24000 && indkomst < 280000)
                    {

                        bundskat = indkomst * 0.30;
                        totalskat = bundskat;
                        Console.WriteLine(" Du skal betale bundskat på 30%.");
                        Console.WriteLine($" Total betaling: {totalskat:F2} ");

                    }

                    else if (indkomst >= 280000 && indkomst < 390000)
                    {
                        bundskat = indkomst * 0.30;
                        mellemskat = (indkomst - 280000) * 0.06;
                        totalskat = mellemskat + bundskat;

                        Console.WriteLine("bundskat på 30% og mellemskat på 6% . ");
                        Console.WriteLine($" Total betaling: {totalskat:F2} kr");

                    }

                    else if (indkomst >= 390000)
                    {
                        bundskat = indkomst * 0.30;
                        mellemskat = (indkomst - 280000) * 0.06;
                        totalskat = (indkomst - 390000) * 0.15;
                        totalskat = bundskat + mellemskat + topskat;



                        Console.WriteLine("bundskat på 30%, mellemskat på 6% og topskat på 15%.");
                        Console.WriteLine($" Total betaling: {totalskat:F2} kr.");
                    }



                    Console.ReadKey();

                    break;
                case 5:

                    Console.Clear();
                    Console.WriteLine("Hvor mang penge der står på kontoen:  ");
                    double penge = double.Parse(Console.ReadLine());

                    double rente = 0;

                    double rentesats = 0.25;
                    double rentesats1 = 1.25;

                    if (penge < 25000)
                    {

                        rente = penge * rentesats / 100;


                        Console.WriteLine(" Der står rente efter 1 år i Banken på 0,25%.");
                        Console.WriteLine($" Rente er: {rente}");
                    }

                    else if (penge >= 25000 && penge <= 150000)
                    {
                        rente = penge * rentesats1 / 100;


                        Console.WriteLine(" Der står rente efter 1 år i Banken på 1,25%.");
                        Console.WriteLine($" Rente er: {rente}");
                    }

                    else if (penge > 150000)
                    {

                        double renteop = (150000 * 1.25 / 100);
                        double rentesatsover = (penge - 150000) * 0.5 / 100;
                        rente = renteop + rentesatsover;

                        Console.WriteLine(" Der står rente efter 1 år i Banken på 1,25%.");
                        Console.WriteLine($" Rente er: {rente:F2} kr");


                        Console.WriteLine();
                    }

                    break;
                case 0:
                    tilbag = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;


            }


        }


    }

    public static void Metoder()
    {
        int tilbage = 0;
        while (tilbage == 0)
        {

            Console.Clear();
            Console.WriteLine("***Metoder og instanser***");
            Console.WriteLine();
            Console.WriteLine("1: Opgave 1 OG 2: ");
            
            Console.WriteLine("0. Tilbag:");
            double vælge = double.Parse(Console.ReadLine());

            switch (vælge)
            {
                case 1:
                    Console.Clear();

                    Bog SherlockHolmes = new Bog();

                    SherlockHolmes.PrintInfo();

                    int pris = 150;
                    int penge = 250;

                    bool harRåd1 = SherlockHolmes.HarRåd(pris, penge);


                    if (harRåd1)
                    {

                        Console.WriteLine("Jeg har råd til det!");
                    }
                    else
                    {
                        Console.WriteLine("Jeg har desværre ikke råd");


                    }

                    int penge1 = 50;
                    bool harRåd2 = SherlockHolmes.HarRåd(pris, penge1);

                    if (harRåd2)
                    {

                        Console.WriteLine("Jeg har råd til det!");
                    }
                    else
                    {
                        Console.WriteLine("Jeg har desværre ikke råd");


                    }
                    Console.ReadKey();


                    break;

                case 0:
                    tilbage = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;


            }


        }
    }


    public static void returtyper()
    {
        
        int tilbag = 0;
        while( tilbag == 0)
        {

            Console.Clear();
            Console.WriteLine("***Returtyper og parametre***");
            Console.WriteLine();
            Console.WriteLine("1: Opgave 1: ");
            Console.WriteLine("2: Opgave 2 og 3: ");
            Console.WriteLine("3: Opgave 4: ");

            Console.WriteLine("0. Tilbag:");
            double vælge = double.Parse(Console.ReadLine());
            Console.ReadKey();
            switch (vælge)
            {
                case 1:

                    Console.Clear();
                    bil minbil = new bil();

                    minbil.MotorStart();
                    minbil.MotorSlukket();

                    Console.ReadKey();
                    break;

                case 2:

                    Console.Clear();
                    bil bil2 = new bil();


                    bil2.FillGas(2.5, true);
                    bil2.FillGas(2.6, false);
                    
                    
                    Console.ReadKey();
                    break;

                    case 3:

                    Console.Clear();

                    bil MinBil = new bil();

                    double resterendeGas = MinBil.RemainingGas(50.30);

                    Console.WriteLine("Resterende brændstof " + resterendeGas + " liter");


                    Console.ReadKey();



                    break;



                case 0:
                    tilbag = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;
            }

        }
    }



    public static void Instance()
    {
        int tilbage = 0;
        while( tilbage == 0)
        {

            Console.Clear();
            Console.WriteLine("***Instancevariabler***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("0: Tilbage: ");
            double vælge = double.Parse(Console.ReadLine());

            switch(vælge)
            {
                case 1:
                    Console.Clear();

                    Bog bog = new Bog();
                    {
                        bog.Titel = "Moby Dick";
                        bog.Pris = 240;
                    };
                    Console.WriteLine($"{bog.Titel} - koster {bog.Pris} kr.");

                    Console.ReadKey();


                    break;

                case 0:
                    tilbage = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;
            }



        }
    }




    public static void Nedarvining11()
    {
        int tilbage = 0;

        while (tilbage == 0)
        {
            Console.Clear();

            Console.WriteLine("***Neddarvning***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("0: Tilbage: ");
            double vælge = double.Parse(Console.ReadLine());
            switch (vælge)
            {
                case 1:

                    Computer computer = new Computer();
                    computer.Showchair();


                    break;



                case 0:
                    tilbage = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;

            }

        }

    }




    public static void konstruktors()
    {
        int tilbage = 0;

        while (tilbage == 0)
        {
            Console.Clear();

            Console.WriteLine("***Konstruktors***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("0: Tilbage: ");
            double vælge = double.Parse(Console.ReadLine());

            switch (vælge)
            {
                case 1:
                    Console.Clear();
                    Bog book = new Bog("Kongeord", 199.95);
                    book.printInfo();
                    Console.ReadKey();
                    break;




                case 0:
                    tilbage = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;



            }



        }

    }
    public static void Arrays()
    {
        int tilbage = 0;

        while (tilbage == 0)
        {
            Console.Clear();


            Console.WriteLine("***Arrays***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("0: Tilbage: ");
            double vælge = double.Parse(Console.ReadLine());
            switch (vælge)
            {
                case 1:

                    Console.Clear();

                    int[] tal = [-2, -1, 0, 10];
                    int[] tal1 = { -2, -1, 0, 10 };


                    Console.WriteLine(tal[1]);
                    Console.WriteLine(tal1[3]);


                    int sum = tal.Sum();
                    Console.WriteLine($"Summen af elementerne: {sum}");


                    Console.ReadKey();


                    break;




                case 0:
                    tilbage = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;



            }


        }

    }
    public static void Gennemløb()
    {
        int tilbage = 0;

        while (tilbage == 0)
        {
            Console.Clear();

            Console.WriteLine("***Gennemløb af arrays***");
            Console.WriteLine();
            Console.WriteLine("Opgave 1: ");
            Console.WriteLine("0: Tilbage: ");
            double vælge = double.Parse(Console.ReadLine());
            switch (vælge)
            {
                case 1:

                    Console.Clear();

                    int[] tal3 = [2, 5, -7, 9, 4, 0, 3];
                    int sum = 0;
                    for (int i = 0; i < tal3.Length; i++)
                    {


                        sum += tal3[i];

                    }

                    Console.WriteLine($"Summen af arrays {sum}");
                    Console.WriteLine();
                    Console.WriteLine("Udskriv af min string array");


                    string[] bil = [" Benz", " BMW", " Mazda", " VW"];
                    for (int i = 0; i < bil.Length; i++)
                    {

                        Console.WriteLine(bil[i]);
                    }


                    Console.ReadKey();

                    break;




                case 0:
                    tilbage = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;



            }



        }

    }
    public static void Publics()
    {
        int tilbage = 0;

        while (tilbage == 0)
        {
            Console.Clear();
            Console.WriteLine("***Public, Private og Protected***");
            Console.WriteLine();
            Console.WriteLine("1: Hvad betyder private? ");
            Console.WriteLine("2: Hvad betyder protected? ");
            Console.WriteLine("3: Hvad betyder public? ");
            Console.WriteLine("4: Hvorfor har vi denne indkapsling? ");
            Console.WriteLine("0: Tilbage: ");
            double vælge = double.Parse(Console.ReadLine());
            switch (vælge)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("  Hvad betyder private? ");
                    Console.WriteLine("");
                    Console.WriteLine("    Private betyder kan kun tilgås inden for den klass, ");
                    Console.WriteLine("    og beskytter data fra at blive ændret eller læst fra andre klasser.");                
                    Console.ReadKey();

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(" Hvad betyder protected? ");
                    Console.WriteLine("");
                    Console.WriteLine("   Protrcted betyder, at et medlem kun kan tilgår fra den samme kalsse og afledte klasser.  ");
                    Console.WriteLine("   Det giver en form for beskyttelse, så kun de klaser, der er tæt knyttet, ");
                    Console.WriteLine("   kan få adgang til medlemmene, mens de stadig skjules for eksterne klasser. ");
                    Console.ReadKey();

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(" Hvad betyder public? ");
                    Console.WriteLine("");
                    Console.WriteLine("   Public betyder, kna det tilgås og ændres af enhver anden klasse, objekt eller metode.");
                    Console.WriteLine("   Det giver fuld synlighed af medlemmet, så det er frit tilgængeligt for alle dele af programmet.");
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine(" Hvorfor har vi denne indkapsling? ");
                    Console.WriteLine("");
                    Console.WriteLine("   Indkapsling giver flere vigtige fordele i sofwareudvikling.");
                    Console.WriteLine("   Indkapsling beskytter objektets ved private eller protected.");
                    Console.WriteLine("   For exsempel, i stedet for at lade andre klasser ændre bilens farve direkte,");
                    Console.WriteLine("                kan vi gøre farven privat og kun tillade ændringer gennem en metode.");
                    Console.ReadKey();
                    break;

                case 0:
                    tilbage = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;



            }




        }

    }
    public static void Rapport()
    {
        int tilbage = 0;

        while (tilbage == 0)
        {
            Console.Clear();
            Console.WriteLine("                              ***Rapport***");
            Console.WriteLine();
            Console.WriteLine("                           Navn: Hamid Heidari ");
            Console.WriteLine("                     Uddannelse: IT-Datakommunikation");
            Console.WriteLine("                           Siden 1 : Indledning ");
            Console.WriteLine("                           Siden 2 : Konklusion ");
            Console.WriteLine("                               0: Tilbage: ");
            double vælge = double.Parse(Console.ReadLine());
            switch (vælge)
            {
                case 1:

                    Console.Clear();
                    Console.WriteLine("                                         *** Indledning*** ");
                    Console.WriteLine("");
                    Console.WriteLine("           Opgaven handler om grundlæggende syntaks og lære nye C# kommandoer. Vi skal desuden lave ");
                    Console.WriteLine("         en menu, som giver adgang til forskellige opgaver. I opgaven der er forskelig varibler,   ");
                    Console.WriteLine("         loops, if-else betingelser som skal lave dem, udover der er matmetik opgaver, . ");
                    Console.WriteLine("         skal vi løse dem til at beregne alder, skat eller priser. ");
                    Console.WriteLine("         Derudover skal vi arbejde med forskelig medtoder og objekter, som vi kan definere,  ");
                    Console.WriteLine("         ændre og bruge til beregninger.Til sidst skal forklar om dem forstårlig og laver rapport. ");
                    Console.WriteLine("          ");
                    Console.WriteLine("         Tryk INTER for tilbage");
                    Console.ReadKey();


                    break;

                case 2:

                    Console.Clear();
                    Console.WriteLine("                                          ***Konklusion***");
                    Console.WriteLine("");
                    Console.WriteLine("           I denne opgave har jeg genopfriske min forståelse af syntaks, og udfordringer med  ");
                    Console.WriteLine("           metoder og bergninger.Jeg har også lært at anvende matematiske funktion i kombination if-else og loops, ");
                    Console.WriteLine("           især til bergninger km om procent. Derudover har jeg arbejdet med opbaver, ");
                    Console.WriteLine("             der involverer brug af setCusorPosition, og udvidet denne funktionalitet ved at lade brugeren");
                    Console.WriteLine("           indtaste rammestørrelse X og Y, og navnet, hvorefter rammen vises på skarmen. Desuden skal jeg lave      ");
                    Console.WriteLine("            en projekt ud fra mit nuværende projekt, og definder feler metoder samt tildele dem en objekt,");
                    Console.WriteLine("                  så de kan interagere med hinanden, derudover skal jeg vise i mine menu,");                             
                    Console.WriteLine("                           der giver mulighed for at navigere frame og tilbag.");
                    Console.WriteLine("");
                    Console.WriteLine("         Tryk INTER for tilbage");

                    Console.ReadKey();






                    break;




                case 0:
                    tilbage = 1;
                    break;

                default:
                    Console.WriteLine(" Ugyldit tal. prøve igen.");
                    break;



            }




        }

    }



}
















