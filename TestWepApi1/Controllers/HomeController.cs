using Microsoft.AspNetCore.Mvc;
using TestWepApi1.Services;

namespace TestWepApi1.Controllers
{
    public class HomeController : ControllerBase
    {
        private ISingletonService _singleton { get; set; }
        private IScopedService _scoped { get; set; }
        private ITransientService _transient { get; set; }

        public HomeController(ITransientService transient, IScopedService scoped, ISingletonService singleton)
        {
            _transient = transient;
            _scoped = scoped;
            _singleton = singleton;
        }

        public IActionResult Index()
        {
            return Ok(_singleton.GetGuid());
        }
        
        public IActionResult Scoped()
        {
            var scopedGuid = _scoped.GetGuid();
            return Ok(scopedGuid);
        }
        
        public IActionResult Transient()
        {
            return Ok(_transient.GetGuid());
        }
    }
}