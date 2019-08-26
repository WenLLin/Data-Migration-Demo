using System;
using System.Linq;
using static ReefSurvey.Model.ReefTable;

namespace directory
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new SurveyContext())
            {
                var record = context.Records;
                var date = context.Date;
                var region = context.Region;
                var subregion = context.Subregions;
                var studyArea = context.StudyAreas;
                var survey = context.Survey;
                var surveyDetail = context.SurveyDetail;
                var fish = context.Fish;
                var family = context.Family;

                var count = context.Records.Count();

                System.Console.WriteLine(count);
                Console.ReadLine();
            }
        }
    }
}
