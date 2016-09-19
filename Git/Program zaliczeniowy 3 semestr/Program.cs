using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Program
    {
        public static void Walka(Postac Bohater,Postac Bestia)
        {
            int wybor=0;
            Console.WriteLine(Bohater.Nick + " vs " + Bestia.Nick);
            Console.WriteLine();
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nTwoj ruch\n\nWybierz 1 aby zaatakować\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                //zrobic wyjatek
                try
                {
                    wybor = Int16.Parse(Console.ReadLine());
                    Wyjatki.Sprawdz(wybor);
                }
                catch (FormatException) { }
                catch (Wyjatki e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Wybierz ponownie 1");
                }
                if (wybor == 1)
                {
                    Bohater.Atak();
                    Bestia.IloscHP = Bestia.IloscHP - Bohater.Obrazenia;
                    Console.Write("Przeciwnikowi zostało " );
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Bestia.IloscHP);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n\nRuch przeciwnika\n\n");
                   try
                    {
                        Wyjatek2.SprawdzZycie(Bohater.IloscHP);
                    }
                    catch (Wyjatki e)
                    {
                        Console.WriteLine(e.Message);
                        throw new Wyjatek2("Postać nie żyje,Koniec Gry");
                    }
                    Bohater.IloscHP = Bohater.IloscHP - Bestia.Obrazenia;
                    Bestia.Atak();
                    Console.Write("Zostało Ci ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Bohater.IloscHP);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }

            } while (Bohater.IloscHP >= 0 && Bestia.IloscHP >= 0);
            if (Bohater.IloscHP > Bestia.IloscHP)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("***********************************************");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Pokonałes przeciwnika, gratulacje\n");
                Console.WriteLine("Otrzymujesz 50 doswiadczenia");
                Bohater.Exp += 50;
                Bestia.Zyje = false;
            }
        }
        public static Postac DalszaCzesc(Postac Szczur)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Czas na Twoją pierwszą walkę");
            Console.Write("Walczysz Przeciwko "); Console.ForegroundColor = ConsoleColor.DarkCyan;
           
            Console.Write("\n-> Szczur  \n\t Życie : 30\n\t Mana : 0\n\t Obrazenia : 1-2\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            return Szczur;
        }
        public static Postac WyswietlnieP(Postac P)
        {
            Console.WriteLine("Klasa : " + P.Klasa);
            Console.WriteLine("Ilosc Punktów: " + P.IloscPkt);
            Console.WriteLine("Ilosc życia :" + P.IloscHP);
            Console.WriteLine("Ilosc many: " + P.IloscMP);
            Console.WriteLine("Sila : " + P.Sila);
            Console.WriteLine("Inteligencja : " + P.Inteligencja);
            Console.WriteLine("Zrecznosc : " + P.Zwinnosc);
            Console.WriteLine("Obrazenia: " + P.Obrazenia);
            Console.WriteLine("Poziom : " + P.Poziom);
            Console.WriteLine("Doswiadczenie: " + P.Exp);

            return P;

        }

        public static void Start()
        {

            string nick="x", klasa="nie";
            int Sila=0, Inteligencja=0, Zrecznosc=0;
            
            Postac Szczur = new Bestia("Szczur",30,0,1,1);
            Postac Kot = new Bestia("Kot", 50, 0, 4, 1);
            Postac Kuna = new Bestia("Kuna", 80, 0, 9, 1);
            Postac Woj = new Wojownik(nick, klasa, Sila, Zrecznosc, Inteligencja); // Tworzenie Instancji klasy Postac zaslonienta klasa Wojownik
            Postac Luc = new Lucznik(nick, klasa, Sila, Zrecznosc, Inteligencja);

            Postac[] Przeciwnicy = new Postac[3];
            Przeciwnicy[0] = Szczur;
            Przeciwnicy[1] = Kot;
            Przeciwnicy[2] = Kuna;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Witaj, w grze. \nNajpierw musisz stworzyć własną postać.");
            Console.Write("Podaj Nick swojej postaci: ");
            Woj.Nick = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Teraz wybierz klase, dostępne klasy to: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Wojownik  \n\nAtrybuty startowe : \n Punkty do rozdania : 10 \n Życie : 100\n Mana : 50\n Sila : 2 \n Inteligencja : 1\n Zreczność : 1\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lucznik  \n\nAtrybuty startowe : \n Punkty do rozdania : 10 \n Życie : 80\n Mana : 70\n Sila : 1 \n Inteligencja : 1\n Zreczność : 2\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Aby wybrac klasę, wpisz  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("W ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("L");
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                klasa = Console.ReadLine();
                if (klasa == "W" || klasa == "w")
                { Console.WriteLine("Wybrana przez Ciebie klasa to Wojownik\n"); Woj.Klasa = "Wojownik"; }
                else if (klasa == "L" || klasa == "l")
                { Console.WriteLine("Wybrana przez Ciebie klasa to Łucznik\n"); Luc.Klasa = "Łucznik"; }
                else Console.WriteLine("Wpisana przez Ciebie klasa nie istnieje");
            } while (klasa != "W" &&  klasa != "L" && klasa != "w" && klasa != "l");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Otrzumujesz 10 punktów na start.");
            Console.WriteLine("Dodaj je do poniższych atrybutów.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Siła ");
            Console.WriteLine("Inteligencja ");
            Console.WriteLine("Zręczność ");
            Console.WriteLine("Aby dodac siłe kliknij 's'\n\t  zrecznosc kliknij 'z'\n\t  inteligencje kliknij 'i'");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            if (klasa == "W" || klasa == "w")
                Woj.DodajPkt(Woj);
            else if (klasa == "L" || klasa == "l")
                Luc.DodajPkt(Luc);
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Zakończyłeś kreowanie swojej postaci !\n Podsumowanie : ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
           
            if (klasa == "W" || klasa == "w")
                WyswietlnieP(Woj);
            else if (klasa == "L" || klasa == "l")
                WyswietlnieP(Luc);
       
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Wciśnij jakikolwiek klawisz, aby przejść dalej.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Console.Clear();
            DalszaCzesc(Szczur);
            if (klasa == "W" || klasa == "w")//zrobic metode ktora uwzglednia klasy !
            {
                Walka(Woj, Szczur);
            }
            else
            {
                Walka(Luc,Szczur);
            }

                int wyborP=0;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n****************************\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Zakonczyłeś walkę"); 
                Console.WriteLine("Wybierz co teraz chcesz zrobić\n");
                Console.WriteLine("1.) Wszyscy przeciwnicy ");
                Console.WriteLine("2.) Sprawdz swoją postać");
                Console.WriteLine("3.) Wyświetl pokonanych przeciwników");
                Console.WriteLine("4.) Rozdaj punkty"); 
                Console.WriteLine("5.) Zakończ grę");
                Console.ForegroundColor = ConsoleColor.Gray;

                while (wyborP != 5)
                {
                    try
                    {
                        wyborP = Convert.ToInt16(Console.ReadLine());
                        Wyjatki.Sprawdz(wyborP);
                    }
                    catch (FormatException)   { }
                    catch (Wyjatki e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Wybierz ponownie:");
                    }
                        switch (wyborP)
                    {
                        case 1:
                            for (int i = 0; i <= Przeciwnicy.Length-1;i++)
                            {
                                Console.WriteLine(Przeciwnicy[i].Nick);
                            }
                             break;
                        case 2:
                             WyswietlnieP(Woj);
                            break;
                        case 3:
                            if (Szczur.Zyje==false)
                            {
                                Console.WriteLine(Przeciwnicy[0].Nick);
                            }
                            else if(Kot.Zyje==false)
                            {
                                Console.WriteLine(Przeciwnicy[1].Nick);
                            }
                            else if (Kuna.Zyje == false)
                            {
                                Console.WriteLine(Przeciwnicy[2].Nick);
                            }
                            break;
                        case 4:
                            if (klasa == "W" || klasa == "w")
                            {
                                if (Woj.IloscPkt == 0)
                                {
                                    Console.WriteLine("\nBrak punktów do rozdania\n");
                                }
                                else
                                    Woj.DodajPkt(Woj);
                               
                            }

                            else
                            {
                                if (Luc.IloscPkt == 0)
                                {
                                    Console.WriteLine("\nBrak punktów do rozdania\n");
                                }
                                else
                                Luc.DodajPkt(Luc);
                            }
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Spróbuj jeszcze raz!");
                            break;

                    }
                }
            }

            
            
         static void Main(string[] args)
        {
           
            Start();
            
        }
    }          

    }
