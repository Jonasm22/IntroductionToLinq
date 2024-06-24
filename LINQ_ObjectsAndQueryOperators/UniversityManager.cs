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

            students.Add(new Student { Id = 1001, Name = "Carla", Gender = "Female", Age = 17, UniversityId = 001 });
            students.Add(new Student { Id = 1002, Name = "Toni", Gender = "male", Age = 21, UniversityId = 001 });
            students.Add(new Student { Id = 1002, Name = "Leyla", Gender = "Female", Age = 19, UniversityId = 002 });
            students.Add(new Student { Id = 1003, Name = "James", Gender = "male", Age = 25, UniversityId = 002 });
            students.Add(new Student { Id = 1004, Name = "Linda", Gender = "Female", Age = 22, UniversityId = 002 });
            students.Add(new Student { Id = 1005, Name = "Lora", Gender = "Dive", Age = 29, UniversityId = 002 });

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



        public void SortStudentByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Student sorted by Age:" );

            foreach(Student student in sortedStudents) 
            {
                student.print();
            }
        }


        public void AllStundentFromHsAugsburg()
        {
            IEnumerable<Student> hsAuxStudents = from student in students
                                                 join university in universities on student.UniversityId equals university.Id
                                                 where university.Name == "Hochschule Augsburg"
                                                 select student;



            Console.WriteLine("Student from Hochschule Augsburg: ");
            foreach(Student student in hsAuxStudents)
            {
                student.print();
            }
        
        
        }


        public void allStundentFromSelectedUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                                 join university in universities on student.UniversityId equals university.Id
                                                 where university.Id == Id
                                                 select student;



            Console.WriteLine($"Student from Selected Uni: {Id} ");
            foreach (Student student in myStudents)
            {
                student.print();
            }




        }




    }
}
