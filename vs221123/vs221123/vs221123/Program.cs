class Practical3
{
    static void Main(string[] args)
    {
        Console.WriteLine(args[0]);
        //int[] arr = { 1, 2, 3 };
        //Console.WriteLine(arr[0]);
        //Console.WriteLine(arr[1]);
        //Console.WriteLine(arr[2]);
        //Console.WriteLine(arr[3]);

        //int[] arr = new int[3];
        //Console.WriteLine(arr.[0]);
        //Console.WriteLine(arr[1]);
        //Console.WriteLine(arr[2]);
        //arr[0] = 1;
        //arr[1] = 2;
        //arr[2] = 3;
        //Console.WriteLine(arr.[0]);
        //Console.WriteLine(arr[1]);
        //Console.WriteLine(arr[2]);

        string[] arrstr = new string[2];
        arrstr[0] = "Element1";
        arrstr[1] = "Element2";

        string[] arrstr2 = new string[2];
        arrstr2[0] = "Element1";
        arrstr2[1] = "Element2";

        bool arraysEqual = false;
        if (arrstr[0] == arrstr2[0]
            && arrstr[1] == arrstr2[1])
        {
            arraysEqual = true;
        }
        Console.WriteLine(arraysEqual);

        string[] arrNewElement = new string[3];
        arrNewElement[0] = arrstr[0];
        arrNewElement[1] = arrstr[1];
        arrNewElement[2] = "New Element";
        //Array.Equals(arrstr, arrstr2);
        //bool compare = arrstr == arrstr2;
        //Console.WriteLine(compare);

        Console.WriteLine();

    }






}

