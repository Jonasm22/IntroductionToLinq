using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ObjectsAndQueryOperators
{
     class UniversityManager
    {

        public List<University> universities;
        public List<Student> students;

        //Constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Adding some universities
            universities.Add(new University { Id = 001, Name ="Hochschule Augsburg" } ); 
            universities.Add(new University { Id = 002, Name ="Hochschule Neu-Ulm" } );

            // Adding some Stundents

            students.Add(new Student { Id = 0001, Name = "Carla", Gender = "Female", Age = 17, UniversityId = 1001 });
            students.Add(new Student { Id = 0002, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1001 });
            students.Add(new Student { Id = 0003, Name = "Leyla", Gender = "Female", Age = 19, UniversityId = 2002 });
            students.Add(new Student { Id = 0004, Name = "James", Gender = "male", Age = 25, UniversityId = 2002 });
            students.Add(new Student { Id = 0005, Name = "Linda", Gender = "Female", Age = 22, UniversityId = 2002 });
            students.Add(new Student { Id = 0005, Name = "Lora", Gender = "Dive", Age = 29, UniversityId = 2002 });

        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");

            foreach (Student studentMale in maleStudents)
            {
                studentMale.print();
            }
            
        }


        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "Female" select student;
            Console.WriteLine("Female - Stundets: ");

            foreach(Student female in femaleStudents)
            {
                female.print();

            }


        }




    }
}
