using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ReefSurvey.Model
{
    public class FishContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bloggfing.db");
        }
    }

    public class Main
    {
        public int recordId { get; set; }

        public string region { get; set; }

        public string surveryIndex { get; set; }

        public string management { get; set; }

        public string batchCode { get; set; }

        public int surveyYear { get; set; }

    }



    public class Fish
    {
        public int fishId { get; set; }
        public string structureType { get; set; }

        public ICollection<Family> familyId { get; set; }
    }

    public class Family
    {
        public int familyId { get; set; }
        public string trophic { get; set; }
        public string scientificName { get; set; }
    }

    public class 
}
