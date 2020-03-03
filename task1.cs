//program NO:1
using System;
					
public class Program
{
    public static void Main()
    {
        Console.WriteLine("The Current Date And Time is " + DateTime.Now);
    }
}
//program NO:2
using System;
					
public class Program
{
    public static void Main()
    {

        int i;
        for (i = 2; i <= 100; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
            else
                Console.WriteLine(-i);
        }

    }
}



//Program No:4
using System;
					
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Heart Shape");
        Console.WriteLine();
        Console.WriteLine(" oo   oo ");
        Console.WriteLine("o  o o  o");
        Console.WriteLine(" o     o ");
        Console.WriteLine("  o   o  ");
        Console.WriteLine("   o o   ");
        Console.WriteLine("    o    ");
    }
}


//Program NO:5
using System;
					
public class Program
{
    public static void Main()
    {
        int a = 10, b = 5, c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("Numbers after swapping are");
        Console.WriteLine(a);
        Console.WriteLine(b);

    }
}

//Program NO:6
using System;
					
public class Program
{
    public static void Main()
    {
        int a, b, h, A;
        Console.WriteLine("Enter value for a");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for b");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for h");
        h = Convert.ToInt32(Console.ReadLine());
        A = ((a + b) / 2) * h;
        Console.WriteLine("the area of trapzoid is : " + A);

    }
}


//Program NO:7
using System;
					
public class Program
{
    public static void Main()
    {
        int a;
        Console.WriteLine("enter a number");
        a = Convert.ToInt32(Console.ReadLine());
        if (a < 100)
        {
            if (a % 2 == 0)
                Console.WriteLine("it is not a prime number");
            else
                Console.WriteLine("it is a prime number");
        }
        else
            Console.WriteLine("invalid number");

    }
}
