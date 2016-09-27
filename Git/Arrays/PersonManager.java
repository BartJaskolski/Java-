/**
 * Created by bartek on 2016-09-27.
 */
public class PersonManager
{
    public static void main(String[] args) {
        PersonDatabase pdb= new PersonDatabase();
        pdb.add(new Person("ania","dupala","123456789"));
        pdb.add(new Person("basia","hehe","122222289"));
        pdb.add(new Person("bart","dmirv","141417892"));

        System.out.println(pdb);
        pdb.remove(new Person("ania","dupala","123456789"));
        System.out.println();
        System.out.println(pdb);
    }
}
