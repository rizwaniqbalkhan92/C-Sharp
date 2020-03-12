using System;

namespace task2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else , else if conditional statment programs:
          Console.WriteLine("Enter a gender i.e male or felame ");
            string gender = Console.ReadLine();
            if (gender == "male")
            {
               Console.WriteLine("GOOD MORNING SIR !");
          }
           else
           {
               Console.WriteLine("GOOD MORNING Ma'am");
           }
           
            
            
            
            // User input check Vowel or not 
            
            Console.WriteLine("Enter a alphabet to check weather an alphabet is Vowel or Not ");
            string character = Console.ReadLine();
            if (character == "a" || character == "e" || character == "i" || character == "o" || character == "u")
           {
              Console.WriteLine("your answer is  "+character+"\n" + " Vowel");
            }
            else
             {
                Console.WriteLine("Your answer is "+character+"\n"+" Consonent");
            }
            // traffice signal light color 
               Console.WriteLine("Enter a color name for traffic signal and gives a message");
                 string color = Console.ReadLine();
                  if (color =="red")
                      {
                 Console.WriteLine("You Must stop! ");
                  }
                  else if (color == "yellow")
                     {
                       Console.WriteLine("Ready to Move>");

              }
                  else if (color == "green")
                    {
                    Console.WriteLine("GO-->>");
                  }
               else
                       {
                    Console.WriteLine("Invalid color for traffic signal");
               }

            //User input number to check number  program

              Console.WriteLine("are you intersted in number check ? i.e yes or no");
              string user =(Console.ReadLine());

              if (user == "yes") {
                Console.WriteLine("Enter a number to check ve+ or -ve");
             int userNumber = Convert.ToInt32(Console.ReadLine());
            
                if (userNumber > 0)
              {
                    Console.WriteLine("your number is "+userNumber+" (POSITIVE NUMBER)" );
                  }
                    else if (userNumber < 0)
                      {
                            Console.WriteLine("your number is " + userNumber + " (NEGATIVE NUMBER)");

            }
            }
             else
              {
              Console.WriteLine("Invalid Number");
                }

            // PASSWORD VERIFICATION
                  string password = "rizwaniqbalkhan";
                  Console.WriteLine("Enter a password to check right or wrong");
                   string p1 = Console.ReadLine();
                  Console.WriteLine("Enter a password again to check right or wrong");
                 string p2 = Console.ReadLine();

                        if (password == p1 &&  password==p2)
                   {
            
               Console.WriteLine("CorrectPassword!");
              }
                   else
              {
                   Console.WriteLine("Wrong Password!");
                 }




                        //Temperature Converter
            Console.WriteLine("Celsius to Fahrenheit");
            int celsius = 40;
            int f = (celsius * 9 / 5) + 32;
            Console.WriteLine("farhenhiet temper is "+f+" F");

             Console.WriteLine(" Fahrenheit to Celsius");
            int fahrenheit2 = 40;
             int celcius2 = (fahrenheit2 - 32) *5/9 ;
             Console.WriteLine("farhenhiet temper is " + celcius2 + " C");


            
            // Tables
           
            for(int i= 1; i<=10; i++)
            {
                Console.WriteLine('2'+"X"+i+"="+i*2);
            }

            // user input for lenght of table and table number
            Console.WriteLine("Enter a table number i.e 2,3,4,5");
            int tableNumber =Convert .ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter a table lenght i.e 10,15,20,30");
            int tableLength = Convert.ToInt32(Console.ReadLine());
            for(int i= 1; i<=tableLength; i++)
            {
                Console.WriteLine(tableNumber+" X "+i+" = "+tableNumber*i);
            }
            // EVEN NUMBER SERIES PROGRAM
            for(int i=2; i<=30; i += 2)
            {
                Console.WriteLine(i+ " is even number ");
            }
            // EVEN POSITIVE and ODD NEGATIVE NUMBER PROGRAM
            for(int j=1; j<=30; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("Positive and even number "+j);
                }
                else
                {
                    Console.WriteLine("Negative and Odd number"+-j);
                }
            }
            // Even number or odd
                  Console.WriteLine("ENter a number to check weather the number is odd or eeven  .?");
                int num = int.Parse(Console.ReadLine());
              if (num % 2 == 0)
            {
              Console.WriteLine("It is even number");
            
            }
             else
            {
              Console.WriteLine("It is an odd number");
            }
              // check grade 
            Console.WriteLine("Enter your percentge % to check your grade");
            float per = float.Parse(Console.ReadLine());
             if (per >= 80)
            {
                  Console.WriteLine("A +");
                }
             else if (per > 70)
            {
               Console.WriteLine("A");
             }
              else if (per >= 60)
                  {
                    Console.WriteLine("B");
                    }
                    else if (per >= 50)
                      {
                        Console.WriteLine("C");
                    }
                  else if (per >= 40)
                    {
                     Console.WriteLine("D");
                 }
             else if (per >= 35)
             {
               Console.WriteLine("E fail hoty hoty rehgaya");
             }
            else
             {
              Console.WriteLine("Nikal ! dobara mehnat kar");
               }

            // for loop 
             increment operation

            for( int i =0; i<=10; i++)
            {
            Console.WriteLine(i);
               }
            //for loop decrement
                   for(int i=10; i>-11; i--) {
            
                         Console.WriteLine(i);
                       }

             //for loop extra

                        int  a= 0;
                     for (int i = 0; i <= 10; i++)
                    {
                      if (i % 2 == 0)
                    {
                      Console.WriteLine(i);
                    a = a + i;

              }
            else
            {
               Console.WriteLine("----------------");
              Console.WriteLine(a);
            }
            }
              int a = int.Parse(Console.ReadLine("enter a number"));
            for(int i=11; i>0; i--)
            {
              Console.WriteLine(i);
            }

        }
    }
}

    

