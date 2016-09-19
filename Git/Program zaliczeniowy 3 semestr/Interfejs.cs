using System;

namespace Rpg
{
    interface Interfejs
    {
      bool Awansuj();// poziom++ kiedy exp ( dosw ) postaci osiagnie 100 lub wiecej
      void Atak();
      int ZadawanieObrazen(int x,int y,int z);
    }
}
