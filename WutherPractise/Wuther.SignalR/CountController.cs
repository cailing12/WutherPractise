using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wuther.SignalR
{
    [Route("api/count")]
    public class CountController : Controller
    {
        public readonly IHubContext<CountHub> _countHub;
        public CountController(IHubContext<CountHub> countHub)
        {
            _countHub = countHub;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            await _countHub.Clients.All.SendAsync("someFunc", new {random = "abcd"});
            return Accepted(1);
        }
    }
}
