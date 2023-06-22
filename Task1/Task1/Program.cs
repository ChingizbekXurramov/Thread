namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the your number:");
            int number = int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => { Numbers(number); });
            thread.Start();

        }
        static void Numbers(int number)
        {
            int count = 0;
            for (int i = 1; i < number; i++)
            {
                count++;
                Thread.Sleep(500);
                Console.WriteLine($"Thread name:{count}= {i}");
            }
        }
    }
}