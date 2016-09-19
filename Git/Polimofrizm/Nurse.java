/**
 * Created by bartek on 2016-04-12.
 */
public class Nurse extends Person
{
    int overTime;


    public  Nurse(String name, String surName, int salary,int overTime)
    {
        super(name,surName,salary);
        this.overTime=overTime;
    }

    @Override
    public String toString() {

        return "Nurse{" +
                "name='" + name + '\'' +
                ", surName='" + surName + '\'' +
                ", salary=" + salary +
                ", overtime "+overTime+'}';
    }
}
