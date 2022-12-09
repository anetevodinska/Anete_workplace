class Practical221205
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your phone number:");
        string phone1 = Console.ReadLine();
        bool match = Regex.Match(phone1, @"\+371[0-9]{8}$").Success;
        if (match)
        {
            Console.WriteLine("Provided phone number is correct");
        }
        else
        {
            Console.WriteLine("Provided phone number is incorrect");
        }
    }



}
