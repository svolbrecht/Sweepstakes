using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string registrationNumber;


        public Contestant()
        {
            lastName = UserInterface.SetLastName();
            firstName = UserInterface.SetFirstName();
            emailAddress = UserInterface.SetEmailAddress();
            registrationNumber = UserInterface.SetRegistrationNumber();
        }
    }
}
