class Practical221116
{
    static void Main(string[] args)
    {
        //string str1 = "wonderful";
        //string str2 = "day";
        //int number1 = 152;
        //int number2 = 65;
        //string strresult = str1 + " " + str2 + number1;
        //console.writeline(strresult);
        //string strnumberres = str1 + (number1 + number2);
        //console.writeline(strnumberres);
        //int modresult1 = 10 % 3;
        //int modresult2 = 15 % 8;
        //console.writeline(modresult1);
        //console.writeline(modresult2);
        //modresult1++;
        //modresult2 *= 3;
        //console.writeline(modresult1 + modresult2);

        //double valudouble = 25.7896;
        //double valuerounded = math.round(valudouble++, 2);
        //console.writeline(valuerounded);

        //valuerounded = math.round(++valuerounded, 2);
        //console.writeline(++valuerounded);


        //bool answer;
        //answer = 13 > 7;
        //answer = 19 < 7;
        //answer = 13 >= 7;
        //answer = 13 > 13;
        //answer = 13 >= 13;
        //answer = 13 == 13;
        //answer = 13 != 13;
        //answer = !true;//false
        //answer = !false;//true
        //answer = true && true;//true
        //answer = true && false;//false
        //answer = false && false; //false

        //double val1 = 26.35885;
        //double val2 = 89.32556;
        //answer = ++val1 == 25 && ++val2 == 90.32556;
        //console.writeline(answer);
        //console.writeline(val1);
        //console.writeline(val2);
        //answer = true || true;
        //answer = true || false;
        //answer = false || false;

        //answer = true && false || false || true;//hard to understand which executes first, not clear, so better not to use
        ////use () to clarify which step is first

        //random rand = new random();
        //double randomresult = rand.nextdouble();
        //int onetoten = (int)(1 + (randomresult * 10));
        //console.writeline(onetoten);
        //bool ismorning = true;
        //if (ismorning)
        //{
        //    console.writeline("wake up!");
        //}

        int time = Int32.Parse (Console.ReadLine());
        if (time >= 5 && time <9)
        {
            Console.WriteLine("Good Morning!");
        }
        else if (time >= 9 && time < 16)
        {
            Console.WriteLine("Good Afternoon!");
        }
        else if (time < 24 && time >=0)
        {
            Console.WriteLine("Good Evening!");
        }
        else 
        {
            Console.WriteLine("Input is not valid");
        }
    }

}
