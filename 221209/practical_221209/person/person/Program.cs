class person
{
    static void Main(string[] args)
    {
        person person = new person();
        person.FirstName = Anete
        person.LastName = Vodinska

    }

}
class Names
{
    private string firstName;
    private string lastName;
    private int age;
}

class Date
{
    private int day, month, year;
    public int Day
    { get
        {
            return this.day;
        }
        set
        {
            if (value < 0 || value > 31)
            {
                Console.WriteLine("Entered date is invalid");
            }
            else
            {
                this.day = value;
            }
        }
    }
    public int Month
    {
        get
        {
            return this.month;
        }
        set
        {
            if (value < 0 || value > 12)
                Console.WriteLine("Entered month is invalid");
            else
                this.month = value;
        }
    } 
}

