using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameFrommail_Lajos_Lorant
{
    class Program
    {
        public static void NameFromEmail()
        {
            Console.WriteLine("Please give me your email address in the following format (firstName.lastName@exam.com): ");
            string email = Console.ReadLine();
            string username = email.Substring(0, email.IndexOf("@"));

            string firstName = username.Substring(0, username.IndexOf("."));
            firstName = char.ToUpper(firstName[0]) + firstName.Substring(1);

            string lastName = username.Substring(username.IndexOf(".") + 1);
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1);

            Console.WriteLine(lastName + " " + firstName);
                        
        }

        static void Main(string[] args)
        {

            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            NameFromEmail();
            Console.ReadLine();

        }
    }
}
