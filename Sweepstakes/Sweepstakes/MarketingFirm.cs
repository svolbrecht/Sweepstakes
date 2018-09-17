using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {

        public void MarketingFirmActions()
        {
            while (true)
            {
                switch (UserInterface.GetMarketingFirmAction())
                {
                    case "1":
                        FactoryPattern.ChooseSweepstakesManager();
                        break;
                    case "2":
                        Sweepstakes.CreateContestant();
                        break;
                    case "3":
                        Sweepstakes.CreateSweepstakes();
                        return;
                    case "4":
                        Sweepstakes.RegisterContestant();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        MarketingFirmActions();
                        break;
                }
            }
        }

    }
}
