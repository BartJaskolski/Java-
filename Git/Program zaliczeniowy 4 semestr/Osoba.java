import java.lang.Integer;
import java.lang.String;
import java.lang.System;
import java.util.*;

/**
 * Created by Micha? on 2016-05-05.
 */
public class Osoba extends  KalendarzTest{
    public String nazwa;
    public Osoba (String nazwa){
        this.nazwa=nazwa;
        wypelnianie();
    }
    public static void main(String[] args) {
        Osoba w  = new Osoba("Irek");
        Osoba w1 = new Osoba("ziomek");

        szukajka(w,w1);
    }
    public static void szukajka(Osoba w, Osoba w1) {
        boolean zmienna = false;
        for (int i = 0; i < LICZBA_DNI; i++) {
            for (int j = 0; j <w.kalendarzOsoby.get(i).size(); j++) {
                if (w.kalendarzOsoby.get(i).get(j) == w1.kalendarzOsoby.get(i).get(j) && w.kalendarzOsoby.get(i).get(j).equals(0)) {
                    System.out.println("wolny termin w dniu  " + i + " o godzinie " + j);
                    zmienna = true;
                }
            }
        }
        if (zmienna == false) {
            System.out.println("brak wolnych terminow, zaczynam zmiane grafiku");
            algorytmPierwszy(w,w1);
        }
    }
    public static void algorytmPierwszy(Osoba w, Osoba w1) {
        boolean trwa = true;
        for (int i = 0; i < LICZBA_DNI; i++)//przeszukiwanie po dniach
        {
            for (int j = 0; j < w.kalendarzOsoby.get(i).size(); j++)//przeszukiwanie po godzinach
            {
                if (w.kalendarzOsoby.get(i).get(j).equals(0) && w1.kalendarzOsoby.get(i).get(j).equals(1))// jezeli listy dnia i  godziny j jest rowne 0 i listy dnia i godziny j rowne 1 to..
                {
                    while (trwa == true) {
                        if (w1.kalendarzOsoby.get(i).indexOf(0) > 0) {//przypisanie pierwszego zera bo pozniej zostaje zamieniona 1 na 0 i moze sie pojebac
                            int zero = w1.kalendarzOsoby.get(i).indexOf(0);
                            w1.kalendarzOsoby.get(i).set(j, w.kalendarzOsoby.get(i).get(j)); // lista 2 dnia i zmienia z 1 na 0
                            System.out.println("zmiana w dniu " + i + " o godzinie " + j + " pierwsze zero na które bedzie zajete " + zero);// takie dla sprawdzenia
                            w1.kalendarzOsoby.get(i).set(zero, 1);
                            trwa = false;
                        } else {
                            int noweZero = w1.kalendarzOsoby.get(i + 1).indexOf(0);
                            w1.kalendarzOsoby.get(i+1).set(noweZero, 1);// pierwsze zero zamienione na 1 :)
                            w1.kalendarzOsoby.get(i).set(j,0); // pierwsze zero zamienione na 1 :)
                            System.out.println("zmiana w dniu " + i + " o godzinie " + j + " pierwsze zero na które bedzie zajete " + noweZero);// takie dla sprawdzenia
                            trwa = false;
                        }
                    }
                } else if (w.kalendarzOsoby.get(i).get(j).equals(1) && w1.kalendarzOsoby.get(i).get(j).equals(0)) {
                    while (trwa == true) {
                        if (w.kalendarzOsoby.get(i).indexOf(0) > 0) {//przypisanie pierwszego zera bo pozniej zostaje zamieniona 1 na 0 i moze sie pojebac
                            int zero = w.kalendarzOsoby.get(i).indexOf(0);
                            w.kalendarzOsoby.get(i).set(j, w1.kalendarzOsoby.get(i).get(j)); // lista 2 dnia i zmienia z 1 na 0
                            System.out.println("zmiana w dniu " + i + " o godzinie " + j + " pierwsze zero na które bedzie zajete " + zero);// takie dla sprawdzenia
                            w.kalendarzOsoby.get(i).set(zero, 1);
                            trwa = false;
                        } else {
                            int noweZero = w.kalendarzOsoby.get(i + 1).indexOf(0);
                            w.kalendarzOsoby.get(i+1).set(noweZero, 1);// pierwsze zero zamienione na 1 :)
                            w.kalendarzOsoby.get(i).set(j,0);
                            System.out.println("zmiana w dniu " + i + " o godzinie " + j + " pierwsze zero na które bedzie zajete " + noweZero);// takie dla sprawdzenia
                            trwa = false;
                        }
                    }

                }
            }

        }
        System.out.println(w.kalendarzOsoby);
        System.out.println(w1.kalendarzOsoby);
    }
}