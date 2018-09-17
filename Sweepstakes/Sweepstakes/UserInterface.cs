using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {


        public static string UserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string SetFirstName()
        {
            string userInput = UserInput("Enter first name");
            return userInput;
        }
        public static string SetLastName()
        {
            string userInput = UserInput("Enter last name");
            return userInput;
        }
        public static string SetEmailAddress()
        {
            string userInput = UserInput("Enter email address");
            return userInput;
        }

        public static string NameSweepstakes()
        {
            string userInput = UserInput("Enter sweepstakes name");
            return userInput;
        }

        public static string GetMarketingFirmAction()
        {
            string userInput = UserInput("Choose acion:\nTo choose sweepstakes manager type - Press '1'\nTo create a contestant - Press '2'\nTo create a sweepstakes - Press '3'\nTo add a contestant to a sweepstakes - Press '4'\nTo exit application - Press '5'");
            return userInput;
        }
    }
}
