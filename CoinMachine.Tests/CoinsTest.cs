using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinMachine.Models;
using System.Collections.Generic;
using System;

namespace CoinMachine.Tests
{
  [TestClass]
  public class CoinsTest
  {
    [TestMethod]
    public void CountCoins_ReturnTheNumberOfQuarters_2()
    {
      int expectedResult = 2;
      Coins testCoin = new Coins(50);

      int actualResult = testCoin.CountCoins()["quarters"];

      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void CountCoins_ReturnTheNumberOfDimes_1()
    {
      int expectedResult = 1;
      Coins testCoin = new Coins(35);

      int actualResult = testCoin.CountCoins()["dimes"];

      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void CountCoins_ReturnTheNumberOfNickels_1()
    {
      int expectedResult = 1;
      Coins testCoin = new Coins(40);

      int actualResult = testCoin.CountCoins()["nickels"];

      Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void CountCoins_ReturnTheNumberOfPennies_2()
    {
      int expectedResult = 2;
      Coins testCoin = new Coins(42);

      int actualResult = testCoin.CountCoins()["pennies"];

      Assert.AreEqual(expectedResult, actualResult);
    }
  }

}
