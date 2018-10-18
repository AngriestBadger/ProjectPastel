using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectPastel.Models;

namespace ProjectPastel.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjectPastel.Models.SponsoredProject> SponsoredProject { get; set; }
        public DbSet<ProjectPastel.Models.GroupPreferences> GroupPreferences { get; set; }
    }
}
