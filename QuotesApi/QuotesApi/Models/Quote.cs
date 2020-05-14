using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApi.Models
{
    public class Quote
    {
        public int ID { get; set; }

        public int Title { get; set; }

        public int Author { get; set; }

        public int Description { get; set; }
    }
}
