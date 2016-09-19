using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{

    abstract public class Postac : Interfejs
    {
        public bool zyje = true;
        protected string nick;  // nazwa postaci
        protected string klasa; //klasa postaci
        protected int iloscPkt; // ilosc punktow do rozdania
        protected int iloscHP;  // hp
        protected int iloscMP;  // mana
        protected int sila, inteligencja, zwinnosc, obrazenia,exp,poziom;


        //****************************************
        //SET i GET
        //****************************************
        
        public string Nick
        {
            set { nick = value; }
            get { return nick; }
        }
        public string Klasa
        {
            set { klasa = value; }
            get { return klasa; }
        }
        public int IloscPkt
        {
            set { iloscPkt = value; }
            get { return iloscPkt; }
        }
        public int IloscMP
        {
            set { iloscMP = value; }
            get { return iloscMP; }
        }
        public int IloscHP
        {
            set { iloscHP = value; }
            get { return iloscHP; }
        }
        public int Sila
        {
            set { sila = value; }
            get { return sila; }
        }
        public int Inteligencja
        {
            set { inteligencja = value; }
            get { return inteligencja; }
        }
        public int Zwinnosc
        {
            set { zwinnosc = value; }
            get { return zwinnosc; }
        }
        public int Obrazenia
        {
            set { obrazenia = value; }
            get { return obrazenia; }
        }
        public int Exp
        {
            set { exp = value; }
            get { return exp; }
        }
        public int Poziom
        {
            set { poziom = value; }
            get { return poziom; }
        }
        public bool Zyje
        {
            get { return zyje; }
            set { zyje = value; }
        }
        

        //****************************************
        //Konstruktory
        //****************************************

        public Postac()
        {
            nick = "Postac";
            klasa = " klasa";
            iloscPkt = 10;
            iloscMP = 1;
            iloscHP = 1;
            sila = 0;
            inteligencja = 0;
            zwinnosc = 0;
            obrazenia = 0;
            exp = 0;
            poziom = 1;
        }
        public Postac(string nick,string klasa)
        {
            this.nick = nick;
            this.klasa = klasa;
            iloscPkt = 10;
            iloscHP = 1;
            iloscMP = 1;
            sila = 0;
            inteligencja = 0;
            zwinnosc = 0;
            obrazenia = 0;
            exp = 0;
            poziom = 1;

            
        }
        public Postac (string nick, string klasa,int iloscHP,int iloscMP)
        {
            this.nick = nick;
            this.klasa = klasa;
            this.iloscHP = iloscHP;
            this.iloscMP = iloscMP;
            sila = 0;
            inteligencja = 0;
            zwinnosc = 0;
            obrazenia = 0;
            exp = 0;
            poziom = 1;

        }
        public Postac(string nick,string klasa,int iloscPkt,int iloscMP, int iloscHP,int sila,int inteligencja, int zwinnosc,int obrazenia, int exp,int poziom,bool zyje)
        {
            this.nick = nick;
            this.klasa = klasa;
            this.iloscPkt = iloscPkt;
            this.iloscHP = iloscHP;
            this.iloscMP = iloscMP;
            this.sila = sila;
            this.inteligencja = inteligencja;
            this.zwinnosc = zwinnosc;
            this.obrazenia = obrazenia;
            this.exp = exp;
            this.poziom = poziom;
            this.zyje = zyje;
        }
   //****************************************
   //Metody z interfejsu

        public abstract Postac DodajPkt(Postac x);
        
        //****************************************
        //Metody wirtualne
       

        public virtual void Atak()
        {
            Console.WriteLine("Cios");
        }
        public virtual int ZadawanieObrazen( int obrazenia,  int iloscHP,int zwinnosc)
        {
            return iloscHP; 
        }

        //****************************************
        public bool Awansuj()
        {
            if (exp >= 100)
                return true;
            else return false;
        }
    //****************************************    

    }
}
