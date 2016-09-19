using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Bestia : Postac
    {
        
    
        public Bestia() : base(){ }
        public Bestia(string nick,int iloscHP, int iloscMP,int sila,int zwinnosc ) : base()
        {
            this.nick = nick;
            klasa = " ";
            iloscPkt = 0;
            this.iloscMP = iloscMP;
            this.iloscHP = iloscHP;
            this.sila = sila;
            inteligencja = 1;
            this.zwinnosc = zwinnosc;
            obrazenia = sila;
            exp = 0;
            poziom = 1;
        }
      public override void Atak()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Atak Pazurami\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
      public override int ZadawanieObrazen(int atakp, int obronap, int zwinnoscP)
      {
          obronap = (obronap + zwinnoscP) - atakp;
          return obronap;
      }
       public override Postac DodajPkt(Postac Bes)
       {
           return Bes;
       }
        public bool Pokonany()
       {
            zyje=false;
            return zyje;
       }
    }
}
