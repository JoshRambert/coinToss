using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinClass
{
    class Coin
    {
        private string sideUp;
        Random rand = new Random();

        //Constructor
        public Coin() {
            sideUp = "Heads";
        }

        //Create a method that simulates tossing the coin
        public void Toss() {
            //Create another random object
            Random rand = new Random();

            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else {
                sideUp = "Tails";
            }
        }

        //GetSide returns the side that is facing upwards
        public string GetSide() {
            return sideUp;
        }
    }
}
