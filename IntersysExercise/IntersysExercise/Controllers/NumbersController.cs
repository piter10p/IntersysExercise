using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntersysExercise.Controllers
{
    public class NumbersController : ApiController
    {
        [HttpGet]
        public double GetData(double num)
        {
            return num * 2;
        }
    }
}
