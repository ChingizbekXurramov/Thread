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
            
            string path = "C:\\Users\\Hp\\Documents\\GitHub\\3Modul\\Thread\\Task3\\PrimeNumber.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(" PrimeNumber ");
                    for (int i = 0; i < number; i++)
                    {

                        int count = 0;
                        for (int j = 1; j <= number; j++)
                        {
                            if (i % j == 0)
                            {
                                count++;
                            }
                        }
                        if (count == 2)
                        {
                            sw.Write(i + " ");

                        }
                    }
                }
            }
        }
        static void EvenNumber(int number)
        {


            string path = "C:\\Users\\Hp\\Documents\\GitHub\\3Modul\\Thread\\Task3\\EvenNumber.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close ();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(" EvenNumber: ");
                    for (int i = 0; i < number; i++)
                    {
                        if (i % 2 == 0)
                        {
                            sw.Write(i + " ");
                        }
                    }
                }
            }
           
        }
    }
    
}
