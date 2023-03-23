using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    i
        internal class Doctor
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public String Degree { get; set; }
            public static int NoOfDoctors { get; set; }

            static Doctor()
            {
                Doctor.NoOfDoctors = 4;       // you can access it directly or by using class name
            }

            public Doctor()          //:this(2,"Rohit","BAMS")
            {
                this.Id = 1;
                this.Name = "Suyash";
                this.Degree = "MBBS";

            }

            public Doctor(int id, string name, string degree)  //:this()
            {
                this.Id = id;
                this.Name = name;
                this.Degree = degree;
            }

            public Doctor(Doctor doc)
            {
                this.Id = doc.Id;
                this.Name = doc.Name;
                this.Degree = doc.Degree;
            }



            public void ShowData()
            {
                Console.WriteLine("Id = " + this.Id);
                Console.WriteLine("Name = " + this.Name);
                Console.WriteLine("Degree = " + this.Degree);
            }


        }
    }
}
}
