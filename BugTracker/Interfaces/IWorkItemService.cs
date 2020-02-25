using BugTracker.Data;
using BugTracker.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Interfaces
{
    public interface IWorkItemService
    {
        IEnumerable<WorkItem> GetAllWorkItems();
        void InsertWorkItem(WorkItem workItem);
    }
    public class WorkItemService : IWorkItemService
    {
        private readonly MongoDBRepository repository;

        public WorkItemService(IOptions<Settings> settings)
        {
            repository = new MongoDBRepository(settings);
        }        
        public IEnumerable<WorkItem> GetAllWorkItems()
        {
            return repository.WorkItems.Find(x => true).ToList();
        }
        public void InsertWorkItem(WorkItem workItem) 
            { 
        //        throw new System.NotImplementedException(); 
            repository.WorkItems.InsertOne(workItem);
            }
        public interface IWorkItemService 
           { 
             IEnumerable<WorkItem> GetAllWorkItems(); 
             void InsertWorkItem(WorkItem workItem); 
           } 
    }
}
