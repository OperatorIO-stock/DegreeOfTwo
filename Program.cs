using System.Globalization;

namespace DegreeOfTwo;

class Program
{
    static void Main(string[] args)
    {
        int numberLowerLimit = 2;
        int numberUpperLimit = 100;
        int resultOperation = 1;
        int numberBase = 2;
        int numberDegree = 0;
        
        Random random = new Random();
        int number = random.Next(numberLowerLimit, numberUpperLimit);

        while (resultOperation <= number)
        {
            resultOperation *= numberBase;
            numberDegree++;
        }
        
        Console.WriteLine($"Number: {number}; Degree: {numberDegree}; Result: {resultOperation}");
    }
}
