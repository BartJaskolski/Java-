/**
 * Created by bartek on 2016-04-13.
 */
public class SchoolTest
{
    public static void main(String[] args) {
        School school = new School(3);
        try {
            school.add(new Student(1, "jan", "kowalski"));
            school.add(new Student(2, "jsan", "dskowalski"));
            school.add(new Student(3, "jaffan", "kowasdaalski"));


        }catch (NoMoreSpaceException e){
            System.err.println("nie mozna dodac tylu osob do szkoly");
            System.err.println(e.getMessage());
        }
        try{
            System.out.println(school.find("jsan","dskowalski"));
        }catch (NoElementFoundException e)
        {
            System.err.println("Nie mozna znalesc");
            System.err.println(e.getMessage());
        }
    }
}
