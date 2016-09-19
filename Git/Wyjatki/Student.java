
/**
 * Created by bartek on 2016-04-13.
 */
public class Student {
    private  int studentId;
    private  String firstName;
    private  String lastName;

    public Student(int studentId, String firstName, String lastName) {
        setStudentId(studentId);
        setFirstName(firstName);
        setLastName(lastName);
    }

    public int getStudentId() {
        return studentId;
    }

    public void setStudentId(int studentId) {
        this.studentId = studentId;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }
    @Override
    public String toString() {
        return "Student{" +
                "studentId=" + studentId +
                ", firstName='" + firstName + '\'' +
                ", lastName='" + lastName + '\'' +
                '}';
    }
}
