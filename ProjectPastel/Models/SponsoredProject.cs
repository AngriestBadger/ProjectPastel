using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPastel.Models
{
    public class SponsoredProject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Contacts { get; set; }
        public string InScope { get; set; }
        public string OutOfScope { get; set; }
        public string SkillRequirements { get; set; }
        public string RelatedProjects { get; set; }
        public string TeamSize { get; set; }
        public string Duration { get; set; }
        public string AllocatedStudent { get; set; }
        public bool IsAllocated { get; set; }
    }
}
