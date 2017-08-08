using System.Collections.Generic;
using System;

namespace CoinMachine.Models
{
    public class Coins
    {

      Dictionary<string, int> _myCoins;
      private int _initialCoins;

      public Coins(int initialCoins)
      {
        _initialCoins = initialCoins;

        _myCoins = new Dictionary<string, int> ()
        {
          {"quarters", 0},
          {"dimes", 0},
          {"nickels", 0},
          {"pennies", 0}
        };
      }

      public Dictionary<string, int> CountCoins()
      {
        int remainingCoins = _initialCoins;
        _myCoins["quarters"] = remainingCoins / 25;
        remainingCoins %= 25;

        _myCoins["dimes"] = remainingCoins / 10;
        remainingCoins %= 10;

        _myCoins["nickels"] = remainingCoins / 5;
        remainingCoins %= 5;

        return _myCoins;
      }

    }
}
