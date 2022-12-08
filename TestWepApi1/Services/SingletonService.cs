using System;

namespace TestWepApi1.Services
{
    public interface ISingletonService : IService
    {
    }

    public class SingletonService : ISingletonService
    {
        private string _guid;

        public SingletonService()
        {
            _guid = Guid.NewGuid().ToString();
        }

        public string GetGuid()
        {
            return _guid;
        }
    }
}