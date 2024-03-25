using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApplication2.Interface;

namespace WebApplication2.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IRecurringJobManager _recurringJobManager;
        private readonly InterfaceContohWeb1 _interfaceContohWeb1;

        public TestController(IRecurringJobManager recurringJobManager, InterfaceContohWeb1 interfaceContohWeb1)
        {
            _recurringJobManager = recurringJobManager;
            _interfaceContohWeb1 = interfaceContohWeb1;
        }

        [HttpGet("{message}")]
        public async Task<IActionResult> CreateAsync(string message)
        {
            //_recurringJobManager.AddOrUpdate(message, () => _interfaceContohWeb1.SendAsync(message), Cron.MinuteInterval(5));

            RecurringJob.AddOrUpdate(message, () => _interfaceContohWeb1.SendAsync(message), Cron.MinuteInterval(1), new RecurringJobOptions { QueueName = "webaplikasi1" });

            return Ok("Success");
        }

        [HttpGet()]
        public async Task<IActionResult> GetAsync()
        {
            return Ok("Welcome");
        }
    }
}
