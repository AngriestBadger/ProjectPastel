using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPastel.Models
{
    public class ParentModel
    {
        //public int Id { get; set; }
        public SponsoredProject SponsoredProject { get; set; }
        public GroupPreferences GroupPreferences { get; set; }
    }
}
