using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace InfoView.Controllers
{
  public class ScheduleController : Controller
  {
    // 
    // GET: /Schedule/

    public IActionResult Index()
    {
      return View();
    }

    // 
    // GET: /Schedule/Welcome/  
    public IActionResult Schedule()
    {

      return View();
    }



  }
}