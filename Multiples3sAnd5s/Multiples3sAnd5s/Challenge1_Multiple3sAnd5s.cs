using System.Diagnostics.CodeAnalysis;

namespace Multiples3sAnd5s
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiples of 3s and 5s");
            var sum = 0;
            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                { 
                    sum += i;
                }
                
            }
            Console.WriteLine("The sum of multiples of 3 or 5 is: " + sum);

        }
        
    }
}
