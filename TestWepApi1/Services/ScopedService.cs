using System;

namespace TestWepApi1.Services
{
    public interface IScopedService: IService{ }
   
    public class ScopedService :IScopedService
    {
        private string _guid;

        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        
        public string GetGuid()
        {
            return _guid;
        }
    }
}