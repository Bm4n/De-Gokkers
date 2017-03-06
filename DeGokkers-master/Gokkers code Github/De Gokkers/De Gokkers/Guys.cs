using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Gokkers
{
    class Guys
    {
        public string Name;  // De naam van de gokker
        public Bet MyBet;    // Een instantie van Bet()
        public int Cash;     // Het saldo van de gokker
        public int horseNum;

        public Guys()
        {
            Name = "N/A";
            Cash = 100;
        }

        public Guys(string name, int Cash)
        {
            this.Name = name;
            this.Cash = Cash;
        }


        public void UpdateLabels(string name, int Cash)
        {
            string myLabel = this.Name + " has " + Cash + " euro";

        }

        public bool PlaceBet(int amount, int dog)
        {
            if (amount > this.Cash)
            {
                return false;
            }

            else
            {
                
                this.horseNum = dog;
                this.Cash -= amount;
                
                return true;
            }


        }

        public string GetHorseName(Guys player, Horse horse)
        {
            if (player.horseNum == 1)
            {
                return horse.GetName1();
            }
            if (player.horseNum == 2)
            {
                return horse.GetName2();
            }
            if (player.horseNum == 3)
            {
                return horse.GetName3();
            }
            if (player.horseNum == 4)
            {
                return horse.GetName4();
            }
            if (player.horseNum == 5)
            {
                return horse.GetName5();
            }
            if (player.horseNum == 6)
            {
                return horse.GetName6();
            }
            else
            {
                return "ERROR";
            }
        }



        public string GetGuyName()
        {
            return this.Name;
        }

        public int GetGuyCash()
        {
            return this.Cash;
        }
    }
}
