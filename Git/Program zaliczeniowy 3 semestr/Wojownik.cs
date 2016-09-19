using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Wojownik : Postac
    {
        char Atrybut;
        public Wojownik() : base(){ }
        public Wojownik(string nick,string klasa,int sila, int zwinnosc, int inteligencja) : base(nick,klasa)
        {
            iloscHP = 100;
            iloscMP = 50;
            this.sila = sila +2;
            this.inteligencja = inteligencja + 1;
            this.zwinnosc = zwinnosc + 1;
            iloscPkt = 10;
            obrazenia = 2;
            exp = 0;
            poziom = 1;
        }
      public override void Atak()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Atak Mieczem\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
      public override int ZadawanieObrazen(int atakp, int obronap,int zwinnoscP)
      {
          obronap = (obronap+zwinnoscP) - atakp;
          return obronap; 
      }
       public override  Postac DodajPkt(Postac Woj)
       {
          
           for (int i = 0; i <Woj.IloscPkt; i=0)
          {
               Console.ForegroundColor = ConsoleColor.Gray;
               Atrybut = Console.ReadKey().KeyChar;// wczytanie chara pomocne !
               Console.ForegroundColor = ConsoleColor.DarkYellow;
               switch (Atrybut)
               {
                  case 's':
                       Woj.Sila++;
                       Woj.Obrazenia++;
                       Woj.IloscPkt--;
                       Console.WriteLine(" -> Dodałeś punkt do Siły !");
                       break;
                   case 'i':
                       Woj.Inteligencja++;
                       Woj.IloscPkt--;
                       Console.WriteLine(" -> Dodałeś punkt do Inteligencji !");
                      break;
                  case 'z':
                      Woj.Zwinnosc++;
                      Woj.IloscPkt--;
                       Console.WriteLine(" -> Dodałeś punkt do Zręczności !");
                       break;
                   default:
                       Console.WriteLine(" -> Spróbuj jeszcze raz ");
                       break;
               }
               
           }
           Console.ForegroundColor = ConsoleColor.Gray;
           return Woj;
       }
    }
}
