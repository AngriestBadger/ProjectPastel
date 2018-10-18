using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPastel.Models
{
    public class GroupPreferences
    {
        public int Id { get; set; }
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }
        //public List<String> StudentId { get; set; }   // Doesn't like the "string" thing, something about not being able to map it
        public int GroupSize { get; set; }              // GroupSize = List.Count(); 
        [Display(Name = "Preference 1")]
        public List<SponsoredProject> Preference1 { get; set; }
        [Display(Name = "Preference 2")]
        public List<SponsoredProject> Preference2 { get; set; }

        public List<SponsoredProject> projectsList; 

        [Display(Name = "Preference 3")]
        public int selectedProjectId3 { get; set; }

        public IEnumerable<SelectListItem> ProjectItems3
        {
            //get { return new SelectList(_projects, "Id", "Sponsorname");  }

            get
            {
                var allProjects = projectsList.Select(f => new SelectListItem
                {
                    Value = f.Id.ToString(),
                    Text = f.SponsorName
                });
                return DefaultProjectItem.Concat(allProjects); 
            }
        }

        public IEnumerable<SelectListItem> DefaultProjectItem
        {
            get {
                return Enumerable.Repeat(new SelectListItem
                {
                    Value = "-1",
                    Text = "Select a Project"
                }, count: 1); 
            }
        }
    }
}
