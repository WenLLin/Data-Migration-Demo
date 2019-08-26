using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using static ReefSurvey.Model.ReefTable;

namespace FishDumpLibrary
{
    public class ReefParser
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies 
                // is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvcCore().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<SurveyContext>(options =>
         options.UseSqlServer(Configuration.GetConnectionString("SurveyContext")));
        }
    }
}
