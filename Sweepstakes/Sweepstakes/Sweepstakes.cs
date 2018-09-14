using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {

        Dictionary<string, Contestant> contestants = new Dictionary<string, Contestant>();


    	public Sweepstakes()
        {
            UserInterface.NameSweepstakes();
        }

    	void RegisterContestant(Contestant contestant)
        {

        }

    	public string PickWinner()
        {

        }

    	void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Information for contestant registration number: {0}\nName: {1} {2}\nEmail Address: {3}", contestant.registrationNumber, contestant.firstName, contestant.lastName, contestant.emailAddress);
        }

    }
}
