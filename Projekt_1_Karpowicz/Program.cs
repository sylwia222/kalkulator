using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_Karpowicz6159
{
    internal class Program
    {
        static void Main(string[] args)
        // od metody main rozpoczyna się działanie programu
        { //deklaracja imiennej dla przechowania 'kodu' naciśniętego klawisza
            ConsoleKeyInfo skWybranaFunkcjonalność;
            do
            {// wyczyszczenie konsoli
                Console.Clear();
                // wypisanie metryki programu->nazwa klasy.nazwa metody
                Console.WriteLine("\n\n\t\tProgram  'Projekt1_Karpowicz6159 umożliwia " +
                    "obliczanie wybranych wielkości matematycznych");
                // wypisanie menu programu
                Console.WriteLine("\n\n\tMenu mojego programu:");
                // wypisanie poszczególnych pozycji Menu programu
                Console.WriteLine("\n\tA.  Laboratorium Nr 1: Kalkulator");
                Console.WriteLine("\n\tB.  Projekt Nr 1: Kalkulator");
                Console.WriteLine("\n\tX.  Zakończenie (wyjście z) programu");
                // odpowiedź dla użytkownika co ma zrobić dalej
                Console.Write("\n\tDla wyboru wymaganej funkcjonalności" +
                    "naciśnij odpowiedni klawisz (A, B lub X): ");
                // wczytanie kodu naciśniętego klawisza
                skWybranaFunkcjonalność = Console.ReadKey();
                //rozpoznanie 'kodu' naciśniętego klawisza
                if (skWybranaFunkcjonalność.Key == ConsoleKey.A)
                {
                    // "uruchomienie" (wywołanie metody) kalkulatora z zajęć labolatoryjnych
                    skKalkulatorLaboratoryjny1();
                }
                else
                    if (skWybranaFunkcjonalność.Key == ConsoleKey.B)
                {
                    //uruchomienie kalkulatora samodzielnie wykonalnego w ramach projektu numer 1
                    skKalkulatorProjektNr1();
                }
                else
                    if (skWybranaFunkcjonalność.Key != ConsoleKey.X)
                {
                    // sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: nacisnąłęś niedozwolony" +
                                                                       "znak");
                    Console.WriteLine("\n\n\tDla kontynuacji działania naciśnij" +
                        " dowolny klawisz");
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("\n\tTeraz nastąpi zakończenie programu");

            } while (skWybranaFunkcjonalność.Key != ConsoleKey.X);
            // wyposanie informacji o Autorze programu
            Console.WriteLine("\n\n\n\tAutor programu:  Karpowicz, numer albumu: 13");

            // wypisanie daty i godziny użytkowania programu
            Console.WriteLine("\n\tDzisiejsza data i godzina: {0}", DateTime.Now);

            //zatrzymanie programu dla obejrzenia wyniku w konsoli
            Console.Write("\n\tDla zakończenia działania programu naciśnij dowolny klawisz . . . ");
            Console.ReadKey();
        }

        // deklaracje metod własnych
        #region Deklaracje metod implementacji funkcjonalności Projektu nr 1
        static void skKalkulatorLaboratoryjny1()
        {

            ConsoleKeyInfo skWybranaFunkcjonalność;
            // Zmiana koloru tła i czcionki dla konsoli kalkulatora labolatoryjnego
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            // metryka kalkulatora labolatoryjnego

            Console.WriteLine("\n\n\t\tKalkulator laboratoryjny");
            // umożliwienie wielokrotnego wyboru funkcjonalności kalkulatora labolatoryjnego
            do
            {// wyczyszczenie konsoli
                Console.Clear();
                // wypisanie menu kalkulatora labolatoryjnego
                Console.WriteLine("\n\n\tMENU funkcjonalne kalkulatora laboratoryjnego");
                Console.WriteLine("\n\tA. Obliczenie sumy wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tB. Obliczenie iloczynu wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tC. Obliczanie średniej arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tD. Wyznaczanie pierwiastków równania kwadratowego");
                Console.WriteLine("\n\tE. Obliczanie wartości wielomianu n-tego stopnia");
                Console.WriteLine("\n\tF. Konwersja liczby z systemu dziesiętnego na dwójkowy");
                Console.WriteLine("\n\tX. Zakończenie (wyjście z) działania kalkulatora " +
                                     "labolatoryjnego");
                // odpowiedź dla użytkownika co ma zrobić dalej
                Console.Write("\n\tDla wyboru wymaganej funkcjonalności" +
                    " naciśnij odpowiedni klawisz (A, B, C, D, E, X): ");
                // wczytanie kodu naciśniętego klawisza
                skWybranaFunkcjonalność = Console.ReadKey();
                // rozpoznanie wybranej funkcjonalności
                switch (skWybranaFunkcjonalność.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("\n\n\tWYBRANO: A. Obliczenie sumy wyrazów " +
                                                "ciągu liczbowego");
                        // deklaracja zmiennych dla przechowania wyników
                        ushort skn;
                        float skSuma;
                        // obliczenie sumy wyrazów ciągu liczbowego
                        skSumaWyrazówCiąguLiczbowego(out skSuma, out skn);
                        // wypisanie wyników obliczeń sumy wyrazów ciągu liczbowego
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona suma wyrazów " +
                            "ciągu liczbowego o liczności n = {0} jest równa: " +
                            "{1, 8:F2}", skn, skSuma);
                        // inna wersja formatowania wypisywanej wartości sumy
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona suma wyrazów " +
                            "ciągu liczbowego o liczności n = {0} jest równa: " +
                            "suma = {1, 8:E2}", skn, skSuma);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona suma wyrazów " +
                            "ciągu liczbowego o liczności n = {0} jest równa: " +
                            "suma = {1, 8:G2}", skn, skSuma);
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("\n\n\tWYBRANO: B. Obliczenie iloczynu " +
                                                "wyrazów ciągu liczbowego");
                        // deklaracja zmiennych dla przechowania wyników
                        float skIloczyn;
                        // obliczenie iloczynu wyrazów ciągu liczbowego
                        skIloczyn = skIloczynWyrazówCiąguLiczbowego();
                        // wypisanie wyników obliczeń sumy wyrazów ciągu liczbowego
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczony iloczyn wyrazów " +
                            "ciągu liczbowego jest równy: {0, 8:F2}", skIloczyn);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczony iloczyn wyrazów " +
                            "ciągu liczbowego jest równy: {0, 8:E2}", skIloczyn);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczony iloczyn wyrazów " +
                            "ciągu liczbowego jest równy: {0, G:8}", skIloczyn);
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine("\n\tWYBRANO: C. Obliczanie średniej arytmetycznej wyrazów ciągu liczbowego");

                        // deklaracje zmiennych
                        float skŚredniaArytmetyczna;
                        skŚredniaArytmetyczna = skŚredniaArytmetycznaWyrazówCiąguLiczbowego(out skn);

                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                            "arytmetyczna wyrazów jest równa: {1, 8:F2}", skn, skŚredniaArytmetyczna);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                            "arytmetyczna wyrazów jest równa: {1, 8:E2}", skn, skŚredniaArytmetyczna);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                            "arytmetyczna wyrazów jest równa: {1, 8:G}", skn, skŚredniaArytmetyczna);
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("\n\tWYBRANO: D. Wyznaczanie pierwiastków równania kwadratowego");
                        skWyznaczaniePierwiastkowRownaniaKwadratowego();
                        break;

                    case ConsoleKey.E://horner
                        Console.WriteLine("\n\tWYBRANO: E. Obliczanie wartości wielomianu" +
                            " n-tego stopnia według schematu Hornera");
                        /*Dane wyjściowe
                         * n - stopień wielomianu: typu ushort (liczba naturalna)
                         * x - wartość zmiennej niezależnej: typu float
                         * ai - współczynniki wielomianu: typu float (dla i = n, n-1, ..., 0)
                         */
                        // deklaracje pomocnicze (dla przechowania wyników obliczeń)
                        // ushort n; jest już zadeklarowane w case Console.Key.A
                        float skx;
                        float skWx;
                        // wywołanie metody obliczającej wartość wielomianu wg schematu hornera
                        skObliczenieWartościWielomianu(out skWx, out skx, out skn);
                        // wypisanie wyników obliczeń
                        Console.WriteLine("\n\n\tWYNIKI:  obliczona wartość {0, 8:F2} wielomianu {1}-go " +
                            "stopnia dla zmiennej niezależnej: {2, 6:F2}", skWx, skn, skx);
                        // poznawcze wypisanie wyników w innych formatach
                        //format wykładniczy
                        Console.WriteLine("\n\n\tWYNIKI:  obliczona wartość {0, 8:E2} wielomianu {1}-go " +
                            "stopnia dla zmiennej niezależnej: {2, 6:E2}", skWx, skn, skx);
                        //format ustawiany automatycznie-> najlepszy dla danej wartości
                        Console.WriteLine("\n\n\tWYNIKI:  obliczona wartość {0, 8:G} wielomianu {1}-go " +
                            "stopnia dla zmiennej niezależnej: {2, 6:G}", skWx, skn, skx);
                        break;

                    case ConsoleKey.F:
                        Console.WriteLine("\n\t WYBRANO: F. Konwersja liczby z systemu dziesiętnego na dwójkowy");
                        // realizacja kompponentu ad 1.
                        string skZZL;
                        ushort skLiczbaPoKonwersji;
                        // wczytanie liczby do konwersji
                        Console.WriteLine("\n\n\tPodaj liczbę (w systemie dziesiętnym) do konwersji: ");
                        skZZL = Console.ReadLine();
                        // usunięcie zbędnych białych znaków
                        skZZL = skZZL.Trim();
                        // konwersja znakowego zapisu liczby na wartość przez wywołanie metody
                        skLiczbaPoKonwersji = skKonwersjaZnakowejLiczbyNaWartość(skZZL);
                        Console.WriteLine("\n\n\tTRACE: liczba po konwersji: " + skZZL.ToString());
          
                        // realizacja komponentu ad 2.
                        ushort skLiczbaDoKonwersji = skLiczbaPoKonwersji;
                        // konwersja wartości (liczby ushort) na znakowy zapis w systemie dwójkowym
                        skKonwersjaLiczbyNaturalnejNaBinarną(skLiczbaDoKonwersji, out skZZL);

                        // wypisanie wyniików konwersji
                        Console.WriteLine("\n\n\tWYNIK KONWERSJI: Wartość liczby po konwersji ze znakowego" +
                            " jej zapisu w dziesiętnym systemie liczbowym: {0}, \n\t\tktóra po konwersji" +
                            "na system dwójkowy (binarny) ma następujący zapis znakowy: {1}", skLiczbaPoKonwersji, skZZL);
                        break;

                    default:
                        Console.WriteLine("\n\tERROR: nacisnąłeś niedozwolony klawisz" +
                            "(znak) - nie ma takiej funkcjonalności w MENU programu");
                        break;
                }
                Console.WriteLine("\n\tDla kontynuacji obliczeń naciśnij " +
                                      "dowolny klawisz ...");
                Console.ReadKey();

            } while (skWybranaFunkcjonalność.Key != ConsoleKey.X);
            Console.Write("\n\tZakończenie działania 'Kalkulatora" +
                " labolatoryjnego': naciśnij dowolny klawisz ... ");
            Console.ReadKey();
        }

        static void skKalkulatorProjektNr1()
        {
            ConsoleKeyInfo skWybórFunkcji;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n\t\tKalkulator Projektowy");
            do
            {
                Console.Clear();
                // wypisanie menu kalkulatora 
                Console.WriteLine("\n\n\tMENU funkcjonalne kalkulatora projektowego");
                Console.WriteLine("\n\tA. Obliczenie średniej harmonicznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tB. Obliczenie średniej kwadratowej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tC. Obliczanie średniej potęgowej (uogólnionej) wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tD. Obliczenie średniej geometrycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\n\tE. Obliczanie ceny jednostki paszy (według średniej ważonej) składającej się " +
                    "\n\t z kilku składników");
                Console.WriteLine("\n\tF. Obliczanie wartości wielomianu n-tego stopnia według schematu Hornera");
                Console.WriteLine("\n\tX. Zakończenie (wyjście z) działania kalkulatora " +
                                     "projektowego");
                // odpowiedź dla użytkownika co ma zrobić dalej
                Console.Write("\n\n\tNaciśnięciem odpowiedniego klawisza wybierz jedną z oferowanych funkcjonalności: ");
                // wczytanie kodu naciśniętego klawisza
                skWybórFunkcji = Console.ReadKey();
                switch (skWybórFunkcji.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("\n\tWYBRANO: A. Obliczenie średniej harmonicznej wyrazów ciągu liczbowego");
                        ushort skn;
                        float skŚredniaHarmoniczna;
                        skŚredniaHarmoniczna = skŚredniaHarmonicznaWyrazówCiąguLiczbowego( out skn, out skŚredniaHarmoniczna);

                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                            "harmoniczna ciągu {0} wyrazów jest równa: {1, 8:F2}", skn, skŚredniaHarmoniczna);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                            "harmoniczna ciągu {0} wyrazów jest równa: {1, 8:G}", skn, skŚredniaHarmoniczna);
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("\n\tWYBRANO: B. Obliczenie średniej kwadratowej wyrazów ciągu liczbowego");
                        
                        float skŚredniaKwadratowa;
                        skŚredniaKwadratowa = skŚredniaKwadratowaWyrazówCiąguLiczbowego(out skn, out skŚredniaKwadratowa);

                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                           "kwadratowa ciągu {0} wyrazów jest równa: {1, 8:F2}", skn, skŚredniaKwadratowa);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                            "kwadratowa ciągu {0} wyrazów jest równa: {1, 8:G}", skn, skŚredniaKwadratowa);
                        break;


                    case ConsoleKey.C:
                        Console.WriteLine("\n\tWYBRANO: C. Obliczanie średniej potęgowej (uogólnionej) wyrazów ciągu liczbowego");

                        float skŚredniaPotęgowa;
                        skŚredniaPotęgowa = skŚredniaPotęgowaWyrazówCiąguLiczbowego(out skn, out skŚredniaPotęgowa);

                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                           "potęgowa ciągu {0} wyrazów jest równa: {1, 8:F2}", skn, skŚredniaPotęgowa);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                            "potęgowa ciągu {0} wyrazów jest równa: {1, 8:G}", skn, skŚredniaPotęgowa);
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("\n\tWYBRANO: D. Obliczenie średniej geometrycznej wyrazów ciągu liczbowego");

                        float skŚredniaGeometryczna;
                        skŚredniaGeometryczna = skŚredniaGeometrycznaWyrazówCiąguLiczbowego(out skn, out skŚredniaGeometryczna);

                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                           "geometryczna ciągu {0} wyrazów jest równa: {1, 8:F2}", skn, skŚredniaGeometryczna);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia " +
                            "geometryczna ciągu {0} wyrazów jest równa: {1, 8:G}", skn, skŚredniaGeometryczna);
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("\n\tWYBRANO: E. Obliczanie ceny jednostki paszy (według średniej ważonej) składającej się " +
                   "\n\t(utworzonej, skomponowanej) z kilku składników");

                        float skCenaJednPaszy;
                        skCenaJednPaszy = skObliczenieCenyJednostkiPaszy(out skn, out skCenaJednPaszy);

                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: cena kilograma mieszanej paszy " +
                           "z {0} składników jest równa: {1, 8:F2}", skn, skCenaJednPaszy);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: cena kilograma mieszanej paszy " +
                            "z {0} składników jest równa: {1, 8:G}", skn, skCenaJednPaszy);
                        break;


                    case ConsoleKey.F:
                        Console.WriteLine("\n\tWYBRANO: F. Obliczanie wartości wielomianu n-tego stopnia według schematu Hornera");
                       
                        float skx;
                        float skWx;
                        // wywołanie metody obliczającej wartość wielomianu wg schematu hornera
                        skObliczenieWartościWielomianu(out skWx, out skx, out skn);
                        // wypisanie wyników obliczeń
                        Console.WriteLine("\n\n\tWYNIKI:  obliczona wartość {0, 8:F2} wielomianu {1}-go " +
                            "stopnia dla zmiennej niezależnej: {2, 6:F2}", skWx, skn, skx);
                        //format ustawiany automatycznie-> najlepszy dla danej wartości
                        Console.WriteLine("\n\n\tWYNIKI:  obliczona wartość {0, 8:G} wielomianu {1}-go " +
                            "stopnia dla zmiennej niezależnej: {2, 6:G}", skWx, skn, skx);
                        break;
               
                    default:
                        Console.WriteLine("\n\tERROR: nacisnąłeś niedozwolony klawisz" +
                            "(znak) - nie ma takiej funkcjonalności w MENU programu");
                        break;

                }
                Console.WriteLine("\n\tDla kontynuacji obliczeń naciśnij " +
                                      "dowolny klawisz ...");
                Console.ReadKey();

            } while (skWybórFunkcji.Key != ConsoleKey.X);
            Console.Write("\n\tZakończenie działania 'Kalkulatora" +
                " projektowego': naciśnij dowolny klawisz ... ");
            Console.ReadKey();

        }

        // deklaracja Regionów ("pojemników" na deklarowane metody)
        #endregion
        #region Deklaracje metod obsługi funkcjonalności kalkulatora labolatoryjnego
        //deklaracje metod
        static void skSumaWyrazówCiąguLiczbowego(out float skSuma, out ushort skn)
        {
            float ska;

            Console.Write("\n\tPodaj liczność ciągu licbowego n: ");
            while (!ushort.TryParse(Console.ReadLine(), out skn))
            {
                Console.WriteLine("\n\tERROR: w zapisie liczności ciągu " +
                    "liczbowego wystąpił niedozwolony znak!!!");
                Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
            }
            //ustalenie początkowego stanu obliczeń
            skSuma = 0.0F;
            for (int ski = 1; ski <= skn; ski++)
            {// wczytanie i-tej wartości ciągu liczbowego
                Console.Write("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", ski);
                while (!float.TryParse(Console.ReadLine(), out ska))
                {// sygnalizacja błędu
                    Console.WriteLine("\n\tERROR: w zapisie {0}-go wyrazu ciągu" +
                                    " liczbowego wystąpił niedozwolony znak!!!", ski);
                    Console.WriteLine("\n\tPodaj ponownie wartość {0}-go wyrazu ciągu" +
                                        " liczbowego: ", ski);
                }
                skSuma = skSuma + ska;
            }
        }

        static float skIloczynWyrazówCiąguLiczbowego()
        {// deklaracja zmiennej pomocniczej dla obliczenia iloczynu
            ushort skn;
            float ska;
            float skIloczyn;
            // wczytanie liczności ciągu liczbowego
            Console.Write("\n\tPodaj liczność ciągu liczbowego: ");
            while (!ushort.TryParse(Console.ReadLine(), out skn))
            { // sygnalizacja błędu
                Console.Write("\n\n\tERROR: w zapisie podanej liczności" +
                    " ciągu liczbowego wystąpił niedozwolony znak");
                // ponowne wczytanie liczności ciągu liczbowego
                Console.Write("\n\n\tPodaj ponownie liczność ciągu liczbowego: ");
            }
            skIloczyn = 1.0F;
            // iteracyjne obliczenie sumy wyrazów ciągu liczbowego
            for (int ski = 1; ski <= skn; ski++)
            {// wczytanie i-tego wyrazu ciągu liczbowego
                Console.Write("\n\tPodaj wartość {0}-ego wyrazu ciągu liczbowego: ", ski);
                while (!float.TryParse(Console.ReadLine(), out ska))
                {// sygnalizacja błędu
                    Console.Write("\n\n\tERROR: w zapisie {0}-go" +
                        " wyrazu ciągu liczbowego wystąpił niedozwolony znak", ski);
                    // ponowne wczytanie liczności ciągu liczbowego
                    Console.Write("\n\n\tPodaj ponownie wartość {0}-go wyrazu ciągu " +
                        "liczbowego: ", ski);

                }
                skIloczyn = skIloczyn * ska;
            }
            return skIloczyn;
        }

        static float skŚredniaArytmetycznaWyrazówCiąguLiczbowego(out ushort skn)
        {
            float skSuma;
            skSumaWyrazówCiąguLiczbowego(out skSuma, out skn);
            return skSuma / skn;


            Console.WriteLine("\n\tPodaj liczność ciągu liczbowego n: ");
            while (!ushort.TryParse(Console.ReadLine(), out skn))
            {// sugnalizacja błędu
                Console.WriteLine("\n\tERROR: w zappisie liczności ciągu wystąpił" +
                                          "niedozwolony znak");
                Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
            }

        }

        static void skWyznaczaniePierwiastkowRownaniaKwadratowego()
        {// deklaracje
            float ska, skb, skc;
            float skDelta, skX1, skX2, skX1_2;
            Console.Write("\n\tPodaj wartość współczynnika a: ");
            ska = float.Parse(Console.ReadLine());
            if (ska == 0.0F)
            {
                Console.WriteLine("\n\tERROR: wartość współczynnika 'a' musi być różna od zera!");
            } while (ska == 0.0F) ;
            Console.Write("\n\tPodaj wartość współczynnika b: ");
            skb = float.Parse(Console.ReadLine());
            Console.Write("\n\tPodaj wartość współczynnika c: ");
            skc = float.Parse(Console.ReadLine());
            skDelta = skb * skb - 4.0F * ska * skc;
            Console.WriteLine("\n\tObliczona wartość Delty wynosi: " + skDelta);
            if (skDelta > 0.0F)
            {
                skX1 = (-skb - (float)Math.Sqrt(skDelta)) / (2.0F * ska);
                skX2 = (-skb + (float)Math.Sqrt(skDelta)) / (2.0F * ska);
                Console.WriteLine("\n\tWYNIKI: \n X1 = {0} \n X2 = {1}", skX1, skX2);
            }
            else
                if (skDelta < 0.0F)
                Console.WriteLine("\n\tRównanie o podanych współczynnikach nie ma pierwiastków rzeczywistych");
            else
            {
                skX1_2 = -skb / (2.0F * ska);
                Console.WriteLine("\n\tWYNIK: X1_2 = {0}", skX1_2);
            }
        }

        static void skObliczenieWartościWielomianu(out float skWx, out float skx, out ushort skn)
        {
            // wczytanie stopnia wielomianu przy zastosowaniu własnej metody
            skWczytajLiczbęNaturalną("Podaj stopień wielomianu", out skn);

            // wczytanie wartości zmiennej niezależnej x
            Console.Write("\n\tPodaj wartość zmiennej niezależnej x: ");

            while (!float.TryParse(Console.ReadLine(), out skx))
            { //sygnalizujemy błąd
                Console.WriteLine("\n\n\tERROR: w podanym zapisie wartości zmiennej " +
                    "niezależnej x wystąpił niedozwolony znak");
                Console.Write("\n\tPodaj ponownie wartość zmiennej niezależnej x: ");
            }
            // deklaracja zmiennej dla przechowywania wartości współczynników
            float ska;
            skWx = 0.0F; //warunek brzegowy (początkowy)
            for (int ski = 0; ski >= 0; ski--)
            {// wczytanie wartości kolejnego współczynnika wielomianu
                Console.Write("\n\tPodaj wartość {0} -go współczynnika wielomianu: ", skn - (ski - 1));
                while (!float.TryParse(Console.ReadLine(), out ska))
                { //sygnalizujemy błąd
                    Console.WriteLine("\n\n\tERROR: w podanym zapisie wartości {0} -go współczynnika " +
                        "wielomianu wystąpił niedozwolony znak", skn - (ski - 1));
                    Console.Write("\n\tPodaj ponownie wartość {0} -go współczynnika wielomianu: ", skn - (ski - 1));

                }
                //obliczenie iteracyjne wielkości wielomianu według Hornera
                skWx = skWx * skx + ska;
            }
        }

        static ushort skKonwersjaZnakowejLiczbyNaWartość(string skZZL)
        {// deklaracje
            ushort skL; // wartość liczby po konwersji
            int skN; // liczba cyfr w ZZL
            byte skp = 10; // podstawa systemu liczbowego dla liczby zapisanej w ZZL

            char skCyfra;
            // określenie (odczytanie) liczby cyfr w ZZL
            skN = skZZL.Length;
            // konwersja ZZL na wartość wg schematu Hornera
            skL = 0; // warunek brzegowy
            for (byte ski = 0; ski < skN; ski++)
            {// pobranie i-tej cyfry z ZZL
                skCyfra = skZZL[ski];
                // sprawdzanie czy to jets na pewno cyfra 0 1 ...9
                if ((skCyfra >= '0') && (skCyfra <= '9'))
                    skL = (ushort)(skL * skp + ((byte)skCyfra - (byte)'0'));
                else
                {// sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w podanym zapisie " +
                        "liczby do konwersji wystąpił niedozwolony znak");
                    // chwilowe zatrzymanie programu
                    Console.WriteLine("\n\tDla zakończenia działania programu " +
                        "naciśnij dowolny klawisz!");
                    Console.ReadKey();
                    // zakończenie konwersji
                    return 0;
                }
            }
            return skL;

        }
        static void skKonwersjaLiczbyNaturalnejNaBinarną(ushort skL, out string skZZL)
        {// konwersja liczby (wartości) skL na zapis znakowu w dwójkowym systemie liczbowym
            string skSchowekReszt = ""; // deklaracja i wyzerowanie schowka dla reszt z dzielenia
            byte skReszta; // dla przechowania reszty z dzielenia
            int skLicznik = 0; // dla liczenia reszt z dzielenia wpisywanych do zmiennej skSchowekReszt

            byte skq = 2; // podstawa systemu liczbowego dla Liczby wyjściowej (po konwersji)
            // wyznaczenie znakowego zapisu liczby w dziesiętnym systemie liczbowym
            while (skL > 0) // powtarzamu obliczenia podczas gdy (skL>0)
            { // obliczeniereszty z dzielenia przez podstawę systemu liczbowego
                skReszta = (byte)(skL % skq); // dzielenie modulo
                                              // dodanie do tworzonego łańcucha znaków reszt z dzielenia nowej reszty
                skSchowekReszt = skSchowekReszt + (char)(skReszta + (byte)'0');
                // zwiekszenie licznika znaków (reszt z dzielenia) wpisanych do zmiennej skSchowekReszt
                skLicznik++;
                // oblicznie wyniku dzielenia całkowitoliczbowego przez podstawę systemu liczbowego
                skL = (ushort)(skL / skq);
            };
            // odwrócenie znakowego zapisu reszt z dzielenia wpisanych do zmiennej skSchowekReszt
            skZZL = ""; // wyzerowanie zmiennej typu 'string'
            for (int skj = skLicznik - 1; skj >= 0; skj--)
                skZZL = skZZL + skSchowekReszt[skj];
            // wynik będzie przechowywany przez parametr wyjściowy: skZZL
        }


        #endregion
        #region Deklaracje metod obsługi funkcjonalności kalkulatora indywidualnego
        //deklaracje metod

        static float skŚredniaHarmonicznaWyrazówCiąguLiczbowego(out ushort skn, out float skŚredniaHarmoniczna)
        { // deklaracje
            int ska;
            float skSuma;
            float skDzielnik = 0.0F;

            Console.Write("\n\tPodaj liczność ciągu liczbowego n: ");
            while (!ushort.TryParse(Console.ReadLine(), out skn))
            {// sugnalizacja błędu
                Console.WriteLine("\n\tERROR: w zapisie liczności ciągu wystąpił" +
                                          "niedozwolony znak");
                Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
            }
            for (int ski = 1; ski <= skn; ski++)
            {// wczytanie i-tego wyrazu ciągu liczbowego
                Console.Write("\n\tPodaj wartość {0}-ego wyrazu ciągu liczbowego: ", ski);
                while (!int.TryParse(Console.ReadLine(), out ska))
                {// sygnalizacja błędu
                    Console.Write("\n\n\tERROR: w zapisie {0}-go" +
                        " wyrazu ciągu liczbowego wystąpił niedozwolony znak", ski);
                    // ponowne wczytanie liczności ciągu liczbowego
                    Console.Write("\n\n\tPodaj ponownie wartość {0}-go wyrazu ciągu " +
                        "liczbowego: ", ski);
                }
                skSuma = ska + ski;
                skDzielnik = (1 / skSuma);

            }
            skŚredniaHarmoniczna = (float)skn / skDzielnik;
            return skŚredniaHarmoniczna;

        }

        static float skŚredniaKwadratowaWyrazówCiąguLiczbowego(out ushort skn, out float skŚredniaKwadratowa)
        { // deklaracje
            int ska;
            float skSuma = 0.0F;
            
            Console.Write("\n\tPodaj liczność ciągu liczbowego n: ");
            while (!ushort.TryParse(Console.ReadLine(), out skn))
            {// sugnalizacja błędu
                Console.WriteLine("\n\tERROR: w zapisie liczności ciągu wystąpił" +
                                          "niedozwolony znak");
                Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
            }
            for (int ski = 1; ski <= skn; ski++)
            {// wczytanie i-tego wyrazu ciągu liczbowego
                Console.Write("\n\tPodaj wartość {0}-ego wyrazu ciągu liczbowego: ", ski);
                while (!int.TryParse(Console.ReadLine(), out ska))
                {// sygnalizacja błędu
                    Console.Write("\n\n\tERROR: w zapisie {0}-go" +
                        " wyrazu ciągu liczbowego wystąpił niedozwolony znak", ski);
                    // ponowne wczytanie liczności ciągu liczbowego
                    Console.Write("\n\n\tPodaj ponownie wartość {0}-go wyrazu ciągu " +
                        "liczbowego: ", ski);
                }
                skSuma = (ska + ski) * (ska + ski);
            }
            skŚredniaKwadratowa = (float)Math.Sqrt(skSuma / skn);
            return skŚredniaKwadratowa;
        }

        static float skŚredniaPotęgowaWyrazówCiąguLiczbowego(out ushort skn, out float skŚredniaPotęgowa)
        {
            int ska;
            int skPotęga;
            float skSuma = 0.0F;
            Console.Write("\n\tPodaj liczność ciągu liczbowego n: ");
            while (!ushort.TryParse(Console.ReadLine(), out skn))
            {// sugnalizacja błędu
                Console.WriteLine("\n\tERROR: w zapisie liczności ciągu wystąpił" +
                                          "niedozwolony znak");
                Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
            }
            Console.Write("\n\tPodaj wartość rzędu: ");
            while (!int.TryParse(Console.ReadLine(), out skPotęga))
            {// sugnalizacja błędu
                Console.WriteLine("\n\tERROR: w zapisie wartości rzędu wystąpił niedozwolony znak");
                Console.Write("\n\tPodaj ponownie wartość rzęu: ");
            }
            for (int ski = 1; ski <= skn; ski++)
            {// wczytanie i-tego wyrazu ciągu liczbowego
                Console.Write("\n\tPodaj wartość {0}-ego wyrazu ciągu liczbowego: ", ski);
                while (!int.TryParse(Console.ReadLine(), out ska))
                {// sygnalizacja błędu
                    Console.Write("\n\n\tERROR: w zapisie {0}-go" +
                        " wyrazu ciągu liczbowego wystąpił niedozwolony znak", ski);
                    // ponowne wczytanie liczności ciągu liczbowego
                    Console.Write("\n\n\tPodaj ponownie wartość {0}-go wyrazu ciągu " +
                        "liczbowego: ", ski);
                }
                skSuma = skSuma + (float)Math.Pow((ska + ski), skPotęga);
            }
            return skŚredniaPotęgowa = (float)Math.Pow((float)skSuma / skn, (float)1 / skPotęga);
        }

        static float skŚredniaGeometrycznaWyrazówCiąguLiczbowego(out ushort skn, out float skŚredniaGeometryczna)
        {// deklaracje
            int ska;
            float skSuma = 0.0F;
            Console.Write("\n\tPodaj liczność ciągu liczbowego n: ");
            while (!ushort.TryParse(Console.ReadLine(), out skn))
            {// sugnalizacja błędu
                Console.WriteLine("\n\tERROR: w zapisie liczności ciągu wystąpił" +
                                          "niedozwolony znak");
                Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
            }
            for (int ski = 1; ski <= skn; ski++)
            {// wczytanie i-tego wyrazu ciągu liczbowego
                Console.Write("\n\tPodaj wartość {0}-ego wyrazu ciągu liczbowego: ", ski);
                while (!int.TryParse(Console.ReadLine(), out ska))
                {// sygnalizacja błędu
                    Console.Write("\n\n\tERROR: w zapisie {0}-go" +
                        " wyrazu ciągu liczbowego wystąpił niedozwolony znak", ski);
                    // ponowne wczytanie liczności ciągu liczbowego
                    Console.Write("\n\n\tPodaj ponownie wartość {0}-go wyrazu ciągu " +
                        "liczbowego: ", ski);
                }
                skSuma += ska + ski;
            }
           return skŚredniaGeometryczna = (float)Math.Pow(skSuma, (float)skn);
        }

        static float skObliczenieCenyJednostkiPaszy(out ushort skn, out float skCenaJednPaszy)
        {
            double skm;
            double skc;
            float skDzielnik = 0.0F;
            float skDzielna = 0.0F;
            Console.Write("\n\tPodaj liczbę składników paszy (n): ");
            while (!ushort.TryParse(Console.ReadLine(), out skn))
            {// sugnalizacja błędu
                Console.WriteLine("\n\tERROR: w zapisie liczby składników wystąpił" +
                                          "niedozwolony znak");
                Console.Write("\n\tPodaj ponownie liczbę składników (n): ");
            }
            for (int ski = 1; ski <= skn; ski++)
            {
                Console.Write("\n\tPodaj masę {0}-ego składnika paszy (w kilogramach): ", ski);
                while (!double.TryParse(Console.ReadLine(), out skm))
                {// sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w zapisie masy {0}-go" +
                        " składnika paszy wystąpił niedozwolony znak", ski);
                    // ponowne wczytanie liczności ciągu liczbowego
                    Console.Write("\n\n\tPodaj ponownie masę {0}-go składnika " +
                        "paszy ( w kilogramach): ", ski);
                }

                Console.Write("\n\tPodaj cenę {0}-ego składnika paszy (w złotówkach): ", ski);
                while (!double.TryParse(Console.ReadLine(), out skc))
                {// sygnalizacja błędu
                    Console.WriteLine("\n\n\tERROR: w zapisie ceny {0}-go" +
                        " składnika paszy wystąpił niedozwolony znak", ski);
                    // ponowne wczytanie liczności ciągu liczbowego
                    Console.Write("\n\n\tPodaj ponownie cenę {0}-go składnika " +
                        "paszy (w złotówkach): ", ski);
                }
                skDzielnik = skDzielnik + (float)skm;
                skDzielna = skDzielna + (float)skm * (float)skc;
            }
            return skCenaJednPaszy = skDzielna / skDzielnik;
        }

       
        #endregion
        #region Deklaracje metod pomocniczych dla obydwu kalkulatorów
        //deklaracje metod

        static void skWczytajLiczbęNaturalną(string skZaproszenieDoPodaniaDanej, out ushort skn)
            {
                Console.Write("\n\t" + skZaproszenieDoPodaniaDanej + ": ");

                while (!ushort.TryParse(Console.ReadLine(), out skn))
                { //sygnalizujemy błąd
                    Console.WriteLine("\n\n\tERROR: w podanym zapisie liczby naturalnej wystąpił" +
                                            " niedozwolony znak");
                    Console.Write("\n\tPodaj ponownie stopień wielomianu: ");
                }
                // wczytanie stopnia wielomianu przy zastosowaniu własnej metody
            }


            #endregion
        
     }
}
