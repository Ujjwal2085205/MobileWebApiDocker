using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileDockerAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileController : ControllerBase
    {
        List<Mobile> MobileList = new List<Mobile>()
        {
            new Mobile { Name="Samsung S21", Color="White",Price=32000 },
            new Mobile { Name="Redmi Note 10", Color="Blue",Price=22000 },
            new Mobile { Name="Lenevo K19+", Color="Glacier",Price=19999 },
            new Mobile { Name="Apple Iphone 13", Color="Red",Price=75000 },


        };

        public List<Mobile> GetMobile()
        {
            return MobileList;
        }
    }
}
