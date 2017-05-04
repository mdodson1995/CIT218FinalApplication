using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalApplicationV2.Models
{
    public class Reviews
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Display(Name = "Date Created")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime  DateCreated { get; set; }

        public string Content { get; set; }
    }
}