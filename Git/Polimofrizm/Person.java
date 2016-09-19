/**
 * Created by bartek on 2016-04-12.
 */
public class Person
{
    String name;

    public String getName() {
        return name;
    }

    public String getSurName() {
        return surName;
    }

    public int getSalary() {
        return salary;
    }

    String surName;
    int salary;

    public Person(String name, String surName, int salary)
    {
        this.name=name;
        this.surName=surName;
        this.salary=salary;
    }
}
