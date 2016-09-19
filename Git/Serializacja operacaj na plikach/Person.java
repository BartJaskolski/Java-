import java.io.*;
import java.util.Scanner;

/**
 * Created by bartek on 2016-07-25.
 */
public class Person implements Serializable
{
    private  String firstName;
    private  String lastName;
    private static final long serialVersionUID = 3812017177088226529L;
    public String getFirstName(){
        return  firstName;
    }
    public void setFirstName(String firstName){
        this.firstName= firstName;
    }
    public String getLastName(){
        return lastName;
    }
    public void  setLastName(String lastName){
        this.lastName=lastName;
    }
    public Person(){}
    public Person(String firstName, String lastName)
    {
        setFirstName(firstName);
        setLastName(lastName);
    }
    @Override
    public String toString() {
        return firstName+" "+lastName;
    }
}
class Employee extends Person
{
    private double salary;
    private static final long serialVersionUID = 4420226460862818754L;
    public double getSalary(){return salary;}
    public void setSalary(double salary){this.salary=salary;}

    public Employee(String firstName,String lastName,double salary){
        super(firstName,lastName);
        setSalary(salary);
    }
    @Override
    public String toString() {
        return super.toString()+ ", wyplata "+ salary;
    }
}
class Company implements Serializable
{
    private static final long serialVersionUID =-7425273230264572679L;
    public static final int EMPLOYEES=3;
    private Employee[] employees;

    public Employee[] getEmployees(){
        return employees;
    }
    public void setEmployees(Employee[] employees){
        this.employees=employees;
    }
    public Company(){
        employees= new Employee[EMPLOYEES];
    }
    public void add(Employee emp, int index){
        employees[index]=emp;
    }
}
class CompanyApp
{
    public static final String FILE_STORE = "employees.info";
    public static final int READ_FROM_USER =1;
    public static final int READ_FROM_FILE =2;

    public static void main(String[] args) {
        CompanyApp oc =new CompanyApp();
        Company company =new Company();

        Scanner input= new Scanner(System.in);
        System.out.println("wprowadzenie dane pracownikow wybierz "+READ_FROM_USER);
        System.out.println("wczytanie dane pracownikow wybierz "+READ_FROM_FILE);
        int option = input.nextInt();

        if ( option ==READ_FROM_USER){
            oc.writeData(company);
        }else if(option==READ_FROM_FILE){
            oc.readData(company);
        }input.close();
    }
    private void writeData(Company company){
        try(Scanner sc =new Scanner(System.in);
        FileOutputStream fos = new FileOutputStream(FILE_STORE);
        ObjectOutputStream oos =new ObjectOutputStream(fos);) {

            for (int i = 0; i < Company.EMPLOYEES; i++)
            {
                System.out.println("Wprowadz imie: ");
                String fn = sc.nextLine();
                System.out.println("Wprowadz nazwisko: ");
                String ln = sc.nextLine();
                System.out.println("Wprowadz wyplaty: ");
                double salary = sc.nextDouble();
                sc.nextLine();

                company.add(new Employee(fn, ln, salary), i);
            }
            oos.writeObject(company);
        }catch (IOException e){
            e.printStackTrace();
        }
    }
    private void readData(Company company){
        try (FileInputStream fis =new FileInputStream(FILE_STORE);
        ObjectInputStream ois =new ObjectInputStream(fis);){
            company=(Company) ois.readObject();
            for(int i=0;i<Company.EMPLOYEES;i++){
                System.out.println(company.getEmployees()[i]);
            }
        }catch (IOException e)
        {
            e.printStackTrace();
        } catch (ClassNotFoundException e){
            e.printStackTrace();
        }
    }
}
class ObjectWriter{
    public static void main(String[] args) {
        String fileName="person.obj";
        Person p1 = new Person("jan","kowalski");

        try (
                FileOutputStream fs = new FileOutputStream(fileName);
                ObjectOutputStream os = new ObjectOutputStream(fs);
        ){
            os.writeObject(p1);
        }catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }catch (IOException e)
        {
            e.printStackTrace();
        }
        System.out.println("zapisano obiekt do pliku");
    }
}