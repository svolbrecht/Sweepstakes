using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class FactoryPattern
    {
        public static ISweepstakesManager ChooseType()
        {
            string userInput = UserInterface.UserInput("Choose preferred Sweepstakes Manager:\nFor Stack style - Press '1'\nFor Queue style - Press '2'");
            switch (userInput)
            {
                case "1":
                    return new SweepstakesStackManager();
                case "2":
                    return new SweepstakesQueueManager();
                default:
                    throw new Exception("Enter valid input");
            }
        }
    }
}
