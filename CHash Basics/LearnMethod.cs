using System;

namespace CHash_Basics
{
    public class LearnMethod
    {
        public void ExecuteMethods()
        {
            // Call the Addi method
            int result = Methodss.Addi();
            Console.WriteLine("The result of Addi method is: " + result);

            // Call the Namemethod
            Methodss.Namemethod();

            // Call the Lastname method
            Methodss.Lastname("Doe");

            // Call the Named method
            string firstName = Methodss.Named("AnyName");
            Console.WriteLine("The first name is: " + firstName);
        }
    }
}
