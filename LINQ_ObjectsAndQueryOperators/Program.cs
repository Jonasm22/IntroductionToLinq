namespace LINQ_ObjectsAndQueryOperators
{
     class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um_males = new UniversityManager();
            um_males.MaleStudents();

            Console.WriteLine("----------------------");

            UniversityManager umFemls = new UniversityManager();
            umFemls.FemaleStudents();
            Console.ReadKey();
        }
    }

   




}
