﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace InfoView.Controllers
{
  public class GroupsController : Controller
  {
    // 
    // GET: /Groups/

    public IActionResult Index(int numTimes = 1)
    {
      ViewData["NumTimes"] = numTimes;
      return View();
    }

    // 
    // GET: /Groups/Welcome/  
    public IActionResult Rooms(string name, int numTimes = 7)
    {
      ViewData["Message"] = "Hello " + name;
      ViewData["NumTimes"] = numTimes;

      return View();
    }

    public IActionResult Edit(string name, int numTimes = 7)
    {
      return View();
    }



  }
}