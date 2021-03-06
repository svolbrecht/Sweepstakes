﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        static Contestant contestant;
        public static string sweepstakesName;
        private Random random;
        int winner;
        Contestant contestantWinner;

        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();


        public void CreateContestant()
        {
            contestant = new Contestant();
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public void CreateSweepstakes()
        {
            sweepstakesName = UserInterface.NameSweepstakes();   
        }

    	public void RegisterContestant()
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            winner = random.Next(1, contestants.Count());

            for (int i = 0; i < contestants.Count; i++)
            {
                if (winner == contestant.registrationNumber)
                {
                    Console.WriteLine("The winner is:\n");
                }
            }

            return contestantWinner;
        }

        void PrintContestantInfo(Contestant contestantWinner)
        {
            Console.WriteLine("Contestant information: {0}\nName: {1} {2}\nEmail Address: {3}", contestant.registrationNumber, contestant.firstName, contestant.lastName, contestant.emailAddress);
        }

    }
}
