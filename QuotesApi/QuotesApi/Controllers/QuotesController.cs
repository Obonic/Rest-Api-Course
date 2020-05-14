using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;

namespace QuotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        List<Quote> _quotes = new List<Quote>()
        {
           new Quote(){ID=0,Author="Me",Description="Yep!", Title="THe test Game0"},
           new Quote(){ID=1,Author="YOU",Description="Yep!", Title="THe test Game1"},
           new Quote(){ID=3,Author="THEM",Description="Yep!", Title="THe test Game2"},
        };

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }
    }
}