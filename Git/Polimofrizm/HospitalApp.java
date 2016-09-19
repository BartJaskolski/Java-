/**
 * Created by bartek on 2016-04-12.
 */
public class HospitalApp
{
    public static void main(String[] args) {
        Hospital hospital =new Hospital();
        hospital.add(new Nurse("zdziska","Kowalski",1000,22));
        hospital.add(new Nurse("Jania","Kssi",900,1));
        hospital.add(new Doctor("Jan","Kupa",8000,2000));
        for (Person p : hospital.getPerson()){
            System.out.println(p);
        }
    }
}
