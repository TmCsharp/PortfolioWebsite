using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace PortfolioWebsite.Pages
{
    public class BioModel : PageModel
    {
        public string FullName { get; set; } = "Your Name";
        public string ProfessionalTitle { get; set; } = "Your Profession";
        public List<string> Skills { get; set; } = new List<string>();
        public List<Education> EducationHistory { get; set; } = new List<Education>();

        public class WorkExperience
        {
            public string Title { get; set; }
            public string Company { get; set; }
            public string Duration { get; set; }
            public List<string> Responsibilities { get; set; }
        }

        public class Education
        {
            public string Degree { get; set; }
            public string Institution { get; set; }
            public string Year { get; set; }
        }

        public void OnGet()
        {
            Skills = new List<string> { "C#", "ASP.NET Core", "SQL" };
            EducationHistory = new List<Education>
            {
                new Education
                {
                    Degree = "BSc Computer Science",
                    Institution = "State University",
                    Year = "2023"
                }
            };
        }
    }
}