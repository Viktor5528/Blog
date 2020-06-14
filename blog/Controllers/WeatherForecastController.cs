using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace blog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        Context db;
   public WeatherForecastController(Context DB)
        {
            db = DB;
        }

        [HttpGet]
        public List<User> Get()
        {
           return db.Users.ToList();
        }
    }
}
