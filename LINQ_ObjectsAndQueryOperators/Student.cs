using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ObjectsAndQueryOperators
{
     class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //foreign Key
        public int UniversityId { get; set; }

        public void print()
        {
            Console.WriteLine($"Stundent: {Name} with id: {Id}, Gender ;" +
                $" {Gender} and Age : {Age} from university with the id:  {UniversityId}");
        }








    }
}
