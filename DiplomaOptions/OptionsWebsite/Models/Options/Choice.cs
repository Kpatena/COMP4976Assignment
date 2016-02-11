using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptionsWebsite.Models.Options
{
    public class Choice
    {
        public int ChoiceId { get; set; }
        public int YearTermId { get; set; }
        public String StudentId { get; set; }
        public String StudentFirstName { get; set; }
        public String StudentLastName { get; set; }
        public int FirstChoiceOptionId { get; set; }
        public int SecondChoiceOptionId { get; set; }
        public int ThirdChoiceOptionId { get; set; }
        public int FourthChoiceOptionId { get; set; }
        public DateTime SelectionDate { get; set; }

        public virtual Options Option { get; set; }
        public virtual YearTerm YearTerm { get; set; }
    }
}