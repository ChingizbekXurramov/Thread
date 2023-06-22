namespace TAsk2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number:");
            int number = int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => { PrimeNumber(number); });
            Thread thread1 = new Thread(() => { EvenNumber(number); });
            thread.Start();
            thread1.Start();
        }
        static void PrimeNumber(int number)
        {
            for (int i = 1; i < number; i += 2)
            {
                Console.WriteLine("Prime Number");
                Console.WriteLine(i);
            }
        }
        static void EvenNumber(int number)
        {
            for (int i = 0; i < number; i += 2)
            {
                Console.WriteLine("Even Number");

                Console.WriteLine(i);
            }
        }
    }
}