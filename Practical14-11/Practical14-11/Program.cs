class Practical
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, type number:");
        string numb1 = Console.ReadLine();
        Console.WriteLine("Please, enter one more number");
        string numb2 = Console.ReadLine();
        int number1 = Int32.Parse(numb1);
        int number2 = Int32.Parse(numb2);
        int result = number1 + number2;
        int result1 = number1 - number2;
        int result2 = number1 * number2;
        int result3 = number1 / number2;
        Console.WriteLine(result);
        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }
}

