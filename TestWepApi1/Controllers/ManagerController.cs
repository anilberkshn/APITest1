using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using TestWepApi1.Entities;

namespace TestWepApi1.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ManagerController : ControllerBase
    {
        // private List<Manager> Managers = new List<Manager>()
        // {
        //     new Manager {Id = 1,Name = "Sera",Surname = "Kara"},
        //     new Manager {Id = 2,Name = "Can ",Surname = "Kadar"},
        //     new Manager {Id = 3,Name = "Erkan",Surname = "Çivi"},
        //     new Manager {Id = 4,Name = "Sabah",Surname = "Seçil"},
        //     new Manager {Id = 5,Name = "Gündüz",Surname = "Cevap"},
        //     new Manager {Id = 6,Name = "Deniz",Surname = "Canan"}
        // };
        //
        private List<Manager> _manager;

        public ManagerController(List<Manager> manager)
        {
            _manager = manager;
            
        }

        public Manager GetManager(int managerId)
        {
            return _manager.FirstOrDefault(x=> x.Id == managerId);
        }
        
        public List<Manager> GetManagerList(int managerId)
        {
            return _manager;
        }
      
        public void AddManager(Manager manager)
        {
             _manager.Add(manager);
        }
        
        public void DeleteManager(Manager manager)
        {
            _manager.Remove(manager);
        }
        public void UpdateManager(Manager manager)
        {
            _manager.Remove(manager);
            _manager.Add(manager);
        }

    }
}