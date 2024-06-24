namespace LINQ_ObjectsAndQueryOperators
{

    //https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentByAge();
            um.AllStundentFromHsAugsburg();
            um.StudentAndUniversityNameCollection();



            /*
            string input = Console.ReadLine();

            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.allStundentFromSelectedUni(inputAsInt);

            }

            catch
            {

                Console.WriteLine("Error");
            }


            Console.ReadKey();
        */
            }
    }
}
