using System.Security.Cryptography.X509Certificates;

namespace CodeChallenge2
{
    internal class CodeChallenge2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            // Write a method to find the sum of the even numbers

            int num1 = 1;
            int num2 = 1;
            int newNum = 1;

            int sum = 0;

            

            while (newNum < 4000000)
            {
                if (newNum % 2 == 0)
                    sum += newNum;
                num1 = num2;
                num2 = newNum;
                newNum = num1 + num2;

                
            }
           
            Console.WriteLine(sum);





            int index = 1;

            while (newNum.ToString().Length < 10)
            {
                
                    
                num1 = num2;
                num2 = newNum;
                newNum = num1 + num2;

                index++;
            }

            Console.WriteLine($"{index} is the first index with 10 digits ({newNum})");


            int longestChain = 0;
            int longetsChainStartingNum = 0;

            for(int i = 1; i<=1000; i++)
            {
                int currentValue = i;
                int currentChainLength = 0;

                while(currentValue > 1)
                {
                    if (currentValue % 2 == 0) 
                    {
                        currentValue = currentValue / 2;
                    }
                    else
                    {
                        currentValue = currentValue * 3 + 1;
                    }
                    currentChainLength++;
                }
                if(currentChainLength > longestChain)
                {
                    longestChain = currentChainLength;
                    longetsChainStartingNum = i;
                }
            }
            Console.WriteLine($"The longest chain is {longestChain} at starting number {longetsChainStartingNum}");










        }
    }
}
