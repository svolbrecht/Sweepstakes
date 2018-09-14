using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Contestant contestant;
        public string sweepstakesName;

        Dictionary<string, Contestant> contestants = new Dictionary<string, Contestant>();


        public void CreateContestant()
        {
            contestant = new Contestant();

        }

        public Sweepstakes()
        {
        sweepstakesName = UserInterface.NameSweepstakes();
            
        }

    	void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

    	public string PickWinner()
        {

        }

    	void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant information: {0}\nName: {1} {2}\nEmail Address: {3}", contestant.registrationNumber, contestant.firstName, contestant.lastName, contestant.emailAddress);
        }

    }
}
