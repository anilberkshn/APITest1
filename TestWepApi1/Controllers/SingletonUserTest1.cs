using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestWepApi1.Entities;

namespace TestWepApi1.Controllers
{
    public class SingletonUserTest1 : ControllerBase
    {
        private static SingletonUserTest1 _user; //?
        private List<User> _usersList;

        private SingletonUserTest1() // constructor
        {
            _usersList = new List<User>()
            {
                new User { Id = 1, Name = "Sera", Surname = "Kara" },
                new User() { Id = 2, Name = "Can ", Surname = "Kadar" },
                new User() { Id = 3, Name = "Erkan", Surname = "Çivi" },
                new User() { Id = 4, Name = "Sabah", Surname = "Seçil" },
                new User() { Id = 5, Name = "Gündüz", Surname = "Cevap" },
                new User() { Id = 6, Name = "Deniz", Surname = "Canan" }
            };
        }

        public static SingletonUserTest1 GetSingletonUserTest1
        {
            get
            {
                if (_user == null)
                {
                    _user = new SingletonUserTest1();
                }

                return _user;
            }
        }

        [HttpGet("GetAllUsers")]
        private List<User> GetAllUsers()
        {
            return _usersList;
        }

        [HttpPost]
        public void Add([FromBody] User user)
        {
            _usersList.Add(user);
        }

        [HttpPost]
        public void Remove(User item)
        {
            _usersList.Remove(item);
        }

        public int Count()
        {
            return _usersList.Count;
        }

        [HttpPost]
        public void Clear()
        {
            _usersList.Clear();
        } 
       /*---------------------------------------------------------------------------*/
        
        // private SingletonList()
        // {
        //     list = new List<T>();
        // }
        //
        // public static SingletonList<T> Instance
        // {
        //     get
        //     {
        //         if (instance == null)
        //         {
        //             instance = new SingletonList<T>();
        //         }
        //
        //         return instance;
        //     }
        // }
        //
        // public List<T> GetList()
        // {
        //     return list;
        // }
    }

}