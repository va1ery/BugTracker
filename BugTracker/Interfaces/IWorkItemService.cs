using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Interfaces
{
    public class IWorkItemService
    {
        IEnumerable<WorkItem> GetAllWorkItems();
    }
}
