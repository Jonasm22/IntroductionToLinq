namespace IntroductionToLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            oddNumers(numbers);
            Console.ReadKey();
            
        }

        static void oddNumers(int[] Numbers)
        {
            Console.WriteLine("Odd Numbers: " );
            IEnumerable<int> oddNumbers = from number in Numbers where number % 2 != 0 select number;

            Console.WriteLine(oddNumbers);

            foreach(int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
