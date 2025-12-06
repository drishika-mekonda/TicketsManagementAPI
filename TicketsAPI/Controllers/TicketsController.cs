using Microsoft.AspNetCore.Mvc;
using TicketsAPI.Models;

namespace TicketsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    ShortDescription = "Login fail",
                    Description = "User cannot login using Google SSO",
                    CreatedDate = new DateTime(2025, 6, 1),
                    Severity = "High",
                    TargetDate = new DateTime(2025, 6, 5),
                    Status = "Open"
                },
                new Ticket
                {
                    Id = 2,
                    ShortDescription = "Payment gateway timeout",
                    Description = "Payments irregularly time out on checkout",
                    CreatedDate = new DateTime(2025, 5, 20),
                    Severity = "Medium",
                    TargetDate = new DateTime(2025, 6, 12),
                    Status = "InProgress"
                } 
            };

            return Ok(tickets);
        }
    }
}
