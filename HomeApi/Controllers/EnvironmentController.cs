using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HomeApi.Controllers
{
    public class EnvironmentController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Ping()
        {
            await Task.Delay(10);
            return Ok(DateTime.UtcNow.ToShortTimeString() + Request.RequestUri);
        }

        [HttpPost]
        public IHttpActionResult Record(Models.EnvironmentData data)
        {
            return Ok(data.EpochDateTime + "," + data.LocationId);
        }
    }
}
