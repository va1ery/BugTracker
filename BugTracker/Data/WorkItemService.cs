using BugTracker.Interfaces;
using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Data
{
    public class WorkItemService : IWorkItemService
    {
        public IEnumerable<WorkItem> GetAllWorkItems()
        {
            throw new NotImplementedException();
        }
    }
}
