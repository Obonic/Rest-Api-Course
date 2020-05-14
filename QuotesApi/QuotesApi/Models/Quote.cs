using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApi.Models
{
    public class Quote
    {
        public int ID { get; set; }

        public String Title { get; set; }

        public String Author { get; set; }

        public String Description { get; set; }
    }
}
