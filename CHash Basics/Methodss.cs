using System;
namespace CHash_Basics
{
	public class Methodss
	{
       public static int Addi()
        {
            int a = 3455;
            int b = 2350;

            int c = a + b;


            return c;

        }

        public static void Namemethod()
        {
            string myName = "Javier";
            Console.WriteLine("Your name is : " + myName);
        }

        public static void Lastname(string lname)
        {
            Console.WriteLine("Your Last Name is " + lname);
        }

        public static string Named(string name) // string method
        {
            string mfirstname = "Bittu";
            return mfirstname; // method returning string
        }
    }
}

