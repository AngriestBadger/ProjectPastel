﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPastel.Models
{
    public class SponsoredProject
    {
        public int Id { get; set; }
        [Display(Name = "Sponsor Name")]
        public string SponsorName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Contacts { get; set; }
        [Display(Name = "In Scope")]
        public string InScope { get; set; }
        [Display(Name = "Out of Scope")]
        public string OutOfScope { get; set; }
        [Display(Name = "Skill Requirements")]
        public string SkillRequirements { get; set; }
        [Display(Name = "Related Projects")]
        public string RelatedProjects { get; set; }
        [Display(Name = "Team Size")]
        public string TeamSize { get; set; }
        public string Duration { get; set; }
        [Display(Name = "Allocated Student")]
        public string AllocatedStudent { get; set; }
        public bool IsAllocated { get; set; }
    }
}
