using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptionsWebsite.Models.Options
{
    public class Options
    {
        public int OptionId { get; set; }
        public String Title { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Choice> Choices { get; set; }
    }
}