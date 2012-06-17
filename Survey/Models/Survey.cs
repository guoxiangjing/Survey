using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SurveyApp.Models
{
    public class Survey
    {
        public int SurveyID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class SurveyDBContext : DbContext
    {
        public DbSet<Survey> Surveys { get; set; }
    }

}
