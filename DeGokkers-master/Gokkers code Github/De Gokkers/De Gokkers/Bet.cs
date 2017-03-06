using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Gokkers
{
    class Bet
    {
        public int amount;   //Het bedrag van de weddenschap.
        public Guys Bettor = new Guys();   //De gokker die gewed heeft.

       
        public string GetDescription(string GetGuyName, int amount, string Horse)
        {
            this.amount = amount;
            string AmountAsString = this.amount.ToString();
            string DescriptionAsString = GetGuyName + " wedt " + AmountAsString + " euro op " + Horse;
            return DescriptionAsString;
        }

        public int PayOut(Guys player,int winner)
        {
            if (player.horseNum == winner)
            {
                return player.Cash += (this.amount * 2);
            }
            
            return 0;
        }

    }
}
