using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalApplicationV2.Models
{
    public class Movies
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

    }
}