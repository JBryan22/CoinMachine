using Microsoft.AspNetCore.Mvc;
using CoinMachine.Models;
using System.Collections.Generic;
using System;

namespace CoinMachine.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/coin/change")]
    public ActionResult Change()
    {

      Coins newCents = new Coins (int.Parse(Request.Form["cents-input"]));

      Dictionary<string, int> cents = new Dictionary<string, int>();
      cents = newCents.CountCoins();

     return View(cents);
    }
  }
}
