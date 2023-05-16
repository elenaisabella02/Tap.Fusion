using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tap.Fusion.Shared;

namespace Tap.Fusion.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppDataController : ControllerBase
    {
        [HttpGet]
        public List<AppData> Get()
        {
            List<AppData> dataSource = new List<AppData>
            {
                new AppData { Id = 1, Subject = "Reserved", StartTime = new DateTime(2023, 5, 11, 9, 30, 0), EndTime = new DateTime(2023, 5, 11, 11, 0, 0) }
            };
            return dataSource;
        }
    }
}
