using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptionsWebsite.Models.Options
{
    public class YearTerm
    {
        public int YearTermId { get; set; }
        public int Year { get; set; }
        public int Term { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<Choice> Choices { get; set; }
    }
}