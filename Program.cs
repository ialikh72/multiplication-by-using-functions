using System;
class Program
{
    static void Sumof2Numnbers(int num1, int num2) // function defination
    {
        int mul = num1 * num2;
        Console.WriteLine("Multiplication of two numbers: " + mul);

    }
    static void Main()
    {
        Sumof2Numnbers(12, 17); // function call by actual parameters
    }
}
