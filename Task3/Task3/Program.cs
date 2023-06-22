namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the your number:");
            int number = int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => { PrimeNumber(number); });
            Thread thread1 = new Thread(() => { EvenNumber(number); });

            thread.Start();
            thread1.Start();


        }
        static void PrimeNumber(int number)
        {
            string filePath = Path.Combine(@"C:\Users\Hp\Documents\GitHub\3Modul\Thread\Task3", $"Thread-PrimeNumber.txt");
            if (File.Exists(filePath))
            {
                Console.WriteLine("Accaount already created!");
            }
            else
            {
                File.Create(filePath).Close();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 1; i < number; i += 2)
                    {
                        writer.WriteLine(i);
                    }


                }
                Console.WriteLine("Account created successfully");
            }
        }
        static void EvenNumber(int number)
        {
      
            string filePath1 = Path.Combine(@"C: \Users\Hp\Documents\GitHub\3Modul\Thread\Task3", $"Thread-EvenNumber.txt");
            if (File.Exists(filePath1))
            {
                Console.WriteLine("Accaount already created!");
            }
            else
            {
                File.Create(filePath1).Close();
                using (StreamWriter writer1 = new StreamWriter(filePath1))
                {

                  for (int i = 0; i < number; i += 2)
                  {
                    writer1.WriteLine(i);
                  }

                }
            }
            Console.WriteLine("Account created successfully");
        }
    }
    
}
