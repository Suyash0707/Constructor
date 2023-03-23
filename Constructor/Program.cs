using Constructor;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        Doctor doctor2 = new Doctor(2, "Tanmay", "BAMS");
        Doctor doctor1 = new Doctor();
        Doctor doctor3 = new Doctor(3, "Avinash", "MD");
        Doctor doctor2copy = new Doctor(doctor2);
        Doctor doctor1copy = new Doctor(doctor1);




        doctor1.ShowData();
        doctor2.ShowData();
        doctor3.ShowData();
        doctor2copy.ShowData();
        doctor1copy.ShowData();








        //Employee emp1 = new Employee(); //call to parameterless constructor.

        //Employee emp2 = new Employee(2,"Gopal",20000); //call to parameterized constructor

        //Employee emp3 = new Employee(3, "Laxman", 30000); 


        //Employee emp3copy = new Employee(emp3);  // call to copy constructor





        //emp1.Showdata();
        //emp2.Showdata();
        //emp3.Showdata();
        //emp3copy.Showdata();




    }
}

