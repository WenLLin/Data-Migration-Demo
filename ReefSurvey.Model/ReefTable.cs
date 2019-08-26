using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ReefSurvey.Model
{
    public class ReefTable
    {
        public class SurveyContext : DbContext
        {
            public DbSet<Record> Records { get; set; }
            public DbSet<Date> Date { get; set; }
            public DbSet<Region> Region { get; set; }
            public DbSet<Subregion> Subregions { get; set; }
            public DbSet<StudyArea> StudyAreas { get; set; }
            public DbSet<Survey> Survey { get; set; }
            public DbSet<SurveyDetail> SurveyDetail { get; set; }
            public DbSet<Fish> Fish { get; set; }
            public DbSet<Family> Family { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = ReefSurvey; Trusted_Connection = True;");
            }
        }

        public class Record
        {
            public int RecordID { get; set; }
            public string RegionID { get; set; }
            public int SurveyIndex { get; set; }
            public string Management { get; set; }
            public string Batchcode { get; set; }
            public int SurveyYear { get; set; }
        }

        public class Date
        {
            public string SurveyDate { get; set; }
        }

        public class Region
        {
            public int RegionID { get; set; }
            public string RegionName { get; set; }
            public string SubRegionID { get; set; }
        }
        public class Subregion
        {
            public int SubRegionID { get; set; }
            public string SubregionName { get; set; }
            public string StudyAreaID { get; set; }
        }
        public class StudyArea
        {
            public int StudyAreaID { get; set; }
            public string StudyAreaName { get; set; }
        }
        public class Survey
        {
            public int SurveyID { get; set; }
            public int SurveyIndex { get; set; }
            public int StudyAreaID { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
        public class SurveyDetail
        {
            public int SurveyIndex { get; set; }
            public int FishID { get; set; }
            public double FishLength { get; set; }
            public int FishCount { get; set; }
        }

        public class Fish
        {
            public int FishID { get; set; }
            public string CommonName { get; set; }
            public string StructureType { get; set; }
            public int FamilyID { get; set; }
        }
        public class Family
        {
            public int FamilyID { get; set; }
            public string Trophic { get; set; }
            public string ScientificName { get; set; }
        }
    }
}

