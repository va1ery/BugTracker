using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BugTracker.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using BugTracker.Interfaces;

namespace BugTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
//        IMongoDatabase _database;
          
         private readonly IWorkItemService _workItemService; 
 
         public HomeController(IWorkItemService workItemService) 
               { 
                 _workItemService = workItemService; 
               } 
         public IActionResult Index() 
         { 
            var workItems = _workItemService.GetAllWorkItems(); 
            return View(workItems); 
         } 
         public ActionResult AddWorkItem() 
            { 
                return RedirectToAction("AddItem", "AddWorkItem"); 
            } 
     }
}
