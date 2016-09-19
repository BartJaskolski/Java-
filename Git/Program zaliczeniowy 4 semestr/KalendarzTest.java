import java.util.ArrayList;

import java.util.List;

/**
 * Created by bartek on 2016-06-19.
 */
public class KalendarzTest extends Dni {

    final static int LICZBA_DNI = 5;
    List<List> kalendarzOsoby = new ArrayList<>(LICZBA_DNI);

    public List wypelnianie() {
        for (int i = 0; i < LICZBA_DNI; i++) {
            kalendarzOsoby.add(new Dni().wypelnianieDnia());
        }
        System.out.println(kalendarzOsoby);
        return kalendarzOsoby;
    }
}



