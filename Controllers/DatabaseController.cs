using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Histocity_Website.Controllers
{
    public class DatabaseController : Controller
    {
        public String getConnectionString()
        {
            return "Database=heroku_9a1fa21f73d10db;Data Source=eu-cdbr-west-03.cleardb.net;User Id=bcfe6ec0812a08;Password=0f9c4546";
        }
    }
}
