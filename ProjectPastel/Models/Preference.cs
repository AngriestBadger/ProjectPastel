using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPastel.Models
{
    public class Preference
    {
        public int Id { get; set; }
        [Display(Name = "Group Name")]                  // ASSUME groups can't have the same group name
        public string GroupName { get; set; }           //GroupChoice.GroupName = GroupPreferences.GroupName
        public int PreferenceNo { get; set; }           // if(Preference 1) = 1, etc
    }
}
