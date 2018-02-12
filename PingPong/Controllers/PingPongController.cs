using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PingPong.Models;
using System;

namespace PingPong
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<string> fakeList = new List<string>{};
        return View(fakeList);
      }

      [HttpPost("/pingpong")]
      public ActionResult Convert()
      {
        int userNum = int.Parse(Request.Form["number"]);
        PingPongGenerator newPingPong = new PingPongGenerator(userNum);

        List<int> userList = newPingPong.CountInput(newPingPong.GetInput());
        List<string> replaceList = newPingPong.ReplacePingPong(userList);
        // string output = string.Join(",", replaceList.ToArray());
        // Console.WriteLine(output);

        return View("Index", replaceList);
      }
    }
}
