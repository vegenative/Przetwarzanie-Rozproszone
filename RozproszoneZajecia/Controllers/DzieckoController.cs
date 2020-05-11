using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RozproszoneZajecia.encje;

namespace RozproszoneZajecia.Controllers
{
    [Route("api/dzieci")]
    public class DzieckoController : ControllerBase
    {
        private DzieckoContext dzieci;

        public DzieckoController(DzieckoContext dzieci)
        {
            this.dzieci = dzieci;
        }

        public ActionResult<List<Dziecko>> Get()
        {
            var dziecko = dzieci.dzieci.ToList();

            return dziecko;
        }
    }
}