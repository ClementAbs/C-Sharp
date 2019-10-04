using System;

namespace democonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string message="Hello Clément!";
            Console.WriteLine("Hello World!");
            Console.WriteLine(message);
            Console.WriteLine("Happy Coding!");


                    // Get the current date.
            DateTime thisDay = DateTime.Today;
            // Display the date in the default (general) format.
            Console.WriteLine(thisDay.ToString());
            // Display the date in a variety of formats.
            //Console.WriteLine(thisDay.ToString("D"));
            Console.WriteLine(DateTime.Now);

            int[] myArray = new int[] {78, 3, 30, 40, 101, 45, 23, 189, 203, 2};;
            int max=0;
            for (int i = 0; i <= 9; i++)
            {
                //Console.WriteLine(i);
               // Console.WriteLine(myArray[i]) 

                if(myArray[i]>max)
                {

                    max = myArray[i];
                    
                }

            }
                  Console.WriteLine(max);
               
        }

    }
  
}
