namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "Kulthoom";
            int age = 23;
            string job = "Trainer Assistant";
            Console.WriteLine("It is " + name + ", I am " + age + "years old, and currently working as "+job);

            //Casting
            float money = 3.45f;

            //implicit casting, from smaller size data type to lager size of the data type
            int num = 5;
            long ssn = num;
            Console.WriteLine(ssn);

            //explicit casting, from lager size data type to smaller size of the data type
            double payment = 55.3;
            int realPayment = int(payment);

        }
    }
}