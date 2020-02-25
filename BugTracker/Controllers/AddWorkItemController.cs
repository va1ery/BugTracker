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
public class AddWorkItemController : Controller
    {
private readonly IWorkItemService _workItemService; 
 
public AddWorkItemController(IWorkItemService workItemService) 
{ 
    _workItemService = workItemService; 
} 
 
public ActionResult AddItem() 
{ 
    return View(); 
} 
 
[HttpPost] 
public ActionResult CreateWorkItem(AddWorkItem addWorkItem) 
{ 
    var workItem = new WorkItem(addWorkItem); 
    _workItemService.InsertWorkItem(workItem); 
    return RedirectToAction("Index", "Home"); 
} 
}
}