/**
 * Created by bartek on 2016-04-12.
 */
public class Hospital
{
    public static final int MAX_PERSONS =100;

    Person[] tabOfPersons ;
    int number;

    public int getNumber() {
        return number;
    }

    public void setNumber(int number) {
        this.number = number;
    }


    public Hospital()
    {
        tabOfPersons = new Person[MAX_PERSONS];
        number =0;
    }

    public  Person[] getPerson(){
        Person[] tabOfPersons1 = new Person[number];
        for(int i=0;i<number;i++)
        {
            tabOfPersons1[i]=tabOfPersons[i];
        }
        return tabOfPersons1;
    }
    public void add(Person person)
    {
        if(number <MAX_PERSONS)
        {
            tabOfPersons[number] = person;
            number++;
        }
    }

}
