
/**
 * Created by bartek on 2016-04-13.
 */
public class School {
    private Student[] students;
    private int studnetsNumbers;

    public School(int studnetsNumbers)
    {
        students =new Student[studnetsNumbers];
        this.studnetsNumbers=0;
    }
    public  void  add(Student student) throws NoMoreSpaceException{
        if(studnetsNumbers>=students.length){
            throw  new NoMoreSpaceException("brak miejsca w skole");

        }
        else{
            students[studnetsNumbers]=student;
            studnetsNumbers++;
        }
    }
    public Student find(String firstName,String lastName) throws NoElementFoundException{
        boolean found =false;
        Student foundElement =null;
        int index =0;
        while (!found &&index<students.length){
            if(students[index].getFirstName().equals(firstName)&&students[index].getLastName().equals(lastName)){
                foundElement=students[index];
                found =true;
            }else {
                index++;
            }
        }
        if(foundElement==null){
            throw new NoElementFoundException("Nie nzlezono elem");
        }
        return foundElement;
    }

}
