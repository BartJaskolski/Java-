/**
 * Created by bartek on 2016-04-12.
 */
public class Doctor extends Person
{
    int bonus;


    public Doctor(String name, String surName, int salary,int bonus)
    {
        super(name,surName,salary);
        this.bonus =bonus;
    }

    @Override
    public String toString() {
        return "Doctor{" + "name='" + name + '\'' +
                ", surName='" + surName + '\'' +
                ", salary=" + salary +
                "bonus=" + bonus +
                '}';
    }

}
