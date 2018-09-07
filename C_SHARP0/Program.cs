using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP0
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            Console.WriteLine(a);

            var studentGrades = new int[] { 1, 2, 34, 56, 7 };
            foreach (var i in studentGrades)
            {
                Console.WriteLine(i);
            }

            //OOP
            var student = new Student();
            student.Name = "Jimmy";
            student.Phone = 6666666;
            student.Birtday = "12-10-1990";

            var students = new List<Student>();

            var adding = true;
            while (adding)
            {
                var newStudent = new Student();
                Console.Write("Dude name:");
                newStudent.Name = Console.ReadLine();

                Console.Write("dude grade:");
                newStudent.Grade = int.Parse(Console.ReadLine());

                students.Add(newStudent);
                //wykorzystabie static z dolu
                Student.Counter++;

                Console.Write("Add another? y/n?");

                if (Console.ReadLine() != "y")
                    adding = false;


            }

        }
    }

    class Student
    {
        //liczenie obi8ekjto
        public static int Counter;

        public string Name;
        public int Grade;
        public string Birtday;
        public string Address;
        int phone; //domyslnie leci priate
        //c# property
        //uzywasz tego jak wlasnosci klasy, przzypisujaca bezposnednio gdzeis wartosc
        // student.Phone = 12321412;
        public int Phone
        {
            set { phone = value;}

        }

        public void SetPhone(int number)
        {
            phone = number;
        }
            
    }
}
