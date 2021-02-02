using System;

namespace first_csharp_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant practice
            // cannot modify a constants values. 
            const float Pi = 3.14f;


            // Min an Max values
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            // Variable Practice
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Maggie";
            bool isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}
