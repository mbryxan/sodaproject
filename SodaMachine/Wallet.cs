﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public List<Coin> Coins;

        //Constructor (Spawner)
        public Wallet()
        {
            Coins = new List<Coin>();
            Coin penny = new Coin();
            Coin nickel = new Coin();
            Coin dime = new Dime();
            Coin quarter = new Quarter();



            FillRegister();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillRegister()
        {
          
        }
    }
}

 