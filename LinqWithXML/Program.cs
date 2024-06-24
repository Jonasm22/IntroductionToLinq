using System.Xml.Linq;

namespace LinqWithXML
{
     class Program
    {



        static void Main(string[] args)
        {
            string studentsXML =
                @"<Students>
                        <Student>
                            <Name>Toni</Name>
                            <Age>21</Age>
                            <University>Yale</University>
                            <Semester>6</Semester>
                       </Student>
                        <Student>
                            <Name>Carla</Name>
                            <Age>17</Age>
                            <University>Yale</University>
                        <Semester>1</Semester>
                       </Student>
                        <Student>
          
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech </University>
                                <Semester>2</Semester>
                       </Student>

                 </Students>";


            XDocument studentsXdoc = new XDocument();

            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value

                           };

            foreach(var studentt in students)
            {
                Console.WriteLine($"Student {studentt.Name} with Age {studentt.Age} from University {studentt.University} in {studentt.Semester} semester");
            }



                var sortedStudents = from student in students orderby student.Age select student;

                Console.WriteLine("Student sorted by Age:");

                foreach (var studentes in sortedStudents)
                {
                Console.WriteLine($"Student {studentes.Name} with Age {studentes.Age} from University {studentes.University}");
                }



            Console.ReadLine();

        }






    }
}
