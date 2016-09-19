using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
   public class Wyjatki : Exception
    {
    public Wyjatki (string wiadomosc)
        :base("Wystąpił błąd. "+ wiadomosc )
           {}
       public static void Sprawdz(int wybor)
        {
           if(wybor!=1 && wybor!=2 && wybor!=3 && wybor!=4 )
           {
               throw new Wyjatki("Wybrałeś złą liczbę");
           }
        }
 }
    public class Wyjatek2:Exception
    {
        
            public Wyjatek2 (string wiadomosc)
        :base("Wystąpił błąd. "+ wiadomosc )
           {}
        public static void SprawdzZycie(int zycie)
            {
           
             if (zycie <=0)
                {
                    zycie = 0;
                throw new Wyjatek2("Postać nie żyje");
                 
                }
            }
    }
        
}
