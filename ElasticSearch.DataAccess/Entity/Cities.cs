using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearch.Data.Entity
{
    public class Cities
    {

        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public int Population { get; set; }
    }
}
