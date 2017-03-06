using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace De_Gokkers
{
    class Horse
    {
        static string[] horseName1 = new string [6];
        static string[] horseName2 = new string [6];
        static string[] horseName3 = new string [6];
        static string[] horseName4 = new string [6];
        static string[] horseName5 = new string [6];
        static string[] horseName6 = new string [6];
        public string name1 = "ERROR: 404. friekandels niet gevonden.";
        public string name2 = "ERROR: 404. friekandels niet gevonden.";
        public string name3 = "ERROR: 404. friekandels niet gevonden.";
        public string name4 = "ERROR: 404. friekandels niet gevonden.";
        public string name5 = "ERROR: 404. friekandels niet gevonden.";
        public string name6 = "ERROR: 404. friekandels niet gevonden.";

        public void MakeName1()
        {
            Random rnd = new Random();
            int rdnmrhrsnm1 = rnd.Next(0, 6);

            if (rdnmrhrsnm1 == 0)
            {
                this.name1 = "Dont get on your High Horse";
            }
            else if (rdnmrhrsnm1 == 1)
            {
                this.name1 = "I've got the High Horse Anakin";
            }
            else if (rdnmrhrsnm1 == 2)
            {
                this.name1 = "Don't get horse over heel";
            }
            else if (rdnmrhrsnm1 == 3)
            {
                this.name1 = "pony up";
            }
            else if (rdnmrhrsnm1 == 4)
            {
                this.name1 = "Quit horsing around";
            }
            else if (rdnmrhrsnm1 == 5)
            {
                this.name1 = "Joseph Stallion";
            }
        }

        public void MakeName2()
        {           
            Random rnd = new Random();
            int rdnmrhrsnm2 = rnd.Next(0, 21);

            if (rdnmrhrsnm2 >= 0 && rdnmrhrsnm2 <= 3)
            {
                this.name2 = "It's nice to be Stable";
            }
            else if (rdnmrhrsnm2 >= 4 && rdnmrhrsnm2 <= 7)
            {
                this.name2 = "Better hoof it";
            }
            else if (rdnmrhrsnm2 >= 8 && rdnmrhrsnm2 <= 11)
            {
                this.name2 = "Now I'm saddled with you";
            }
            else if (rdnmrhrsnm2 >= 12 && rdnmrhrsnm2 <= 15)
            {
                this.name2 = "quit stalling";
            }
            else if (rdnmrhrsnm2 >= 16 && rdnmrhrsnm2 <= 19)
            {
                this.name2 = "I've fallen and I can't giddyup";
            }
            else if (rdnmrhrsnm2 == 20)
            {
                this.name2 = "Fastfood";
            }
        }

        public void MakeName3()
        {
            Random rnd = new Random();
            int rdnmrhrsnm3 = rnd.Next(0, 6);

            if (rdnmrhrsnm3 == 0)
            {
                this.name3 = "Stable tennis";
            }
            else if (rdnmrhrsnm3 == 1)
            {
                this.name3 = "Mane St.";
            }
            else if (rdnmrhrsnm3 == 2)
            {
                this.name3 = "Chuck horrse";
            }
            else if (rdnmrhrsnm3 == 3)
            {
                this.name3 = "May the horse be with you";
            }
            else if (rdnmrhrsnm3 == 4)
            {
                this.name3 = "The mane goal";
            }
            else if (rdnmrhrsnm3 == 5)
            {
                this.name3 = "Woah Woah WOAH";
            }
        }

        public void MakeName4()
        {
            Random rnd = new Random();
            int rdnmrhrsnm4 = rnd.Next(0, 6);

            if (rdnmrhrsnm4 == 0)
            {
                this.name4 = "I could eat a horse";
            }
            else if (rdnmrhrsnm4 == 1)
            {
                this.name4 = "Baxter";
            }
            else if (rdnmrhrsnm4 == 2)
            {
                this.name4 = "Nicole";
            }
            else if (rdnmrhrsnm4 == 3)
            {
                this.name4 = "Stop stallion";
            }
            else if (rdnmrhrsnm4 == 4)
            {
                this.name4 = "Jonny";
            }
            else if (rdnmrhrsnm4 == 5)
            {
                this.name4 = "Renegade";
            }
        }

        public void MakeName5()
        {
            Random rnd = new Random();
            int rdnmrhrsnm5 = rnd.Next(0, 6);

            if (rdnmrhrsnm5 == 0)
            {
                this.name5 = "Cinders";
            }
            else if (rdnmrhrsnm5 == 1)
            {
                this.name5 = "Harry Trotter";
            }
            else if (rdnmrhrsnm5 == 2)
            {
                this.name5 = "Diego";
            }
            else if (rdnmrhrsnm5 == 3)
            {
                this.name5 = "Sweet Dreams";
            }
            else if (rdnmrhrsnm5 == 4)
            {
                this.name5 = "Nimbus";
            }
            else if (rdnmrhrsnm5 == 5)
            {
                this.name5 = "Fire";
            }
        }

        public void MakeName6()
        {
            Random rnd = new Random();
            int rdnmrhrsnm6 = rnd.Next(0, 6);

            if (rdnmrhrsnm6 == 0)
            {
                this.name6 = "Chrome";
            }
            else if (rdnmrhrsnm6 == 1)
            {
                this.name6 = "Horsepower";
            }
            else if (rdnmrhrsnm6 == 2)
            {
                this.name6 = "funny";
            }
            else if (rdnmrhrsnm6 == 3)
            {
                this.name6 = "Trojan Horse";
            }
            else if (rdnmrhrsnm6 == 4)
            {
                this.name6 = "Henry";
            }
            else if (rdnmrhrsnm6 == 5)
            {
                this.name6 = "Flashflame";
            }

        }

        public void Run()
        {
            //eigenlijk niet meer nodig omdat het al in de form zit
        }
        
        public void TakeStartingPosition()
        {
            //see run     
        }

        public string GetName1()
        {
            return this.name1;
        }

        public string GetName2()
        {
            return this.name2;
        }

        public string GetName3()
        {
            return this.name3;
        }

        public string GetName4()
        {
            return this.name4;
        }

        public string GetName5()
        {
            return this.name5;
        }

        public string GetName6()
        {
            return this.name6;
        }
    }
}