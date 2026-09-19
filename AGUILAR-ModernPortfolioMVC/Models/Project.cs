using System;
using System.Collections.Generic;
using System.Linq;

namespace AGUILAR_ModernPortfolioMVC.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Thumbnail { get; set; }
        public string GithubUrl { get; set; }
        public List<string> TechStack { get; set; }
        public string LongDescription { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }

    public class Comment
    {
        public string Author { get; set; }
        public string Text { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public static class ProjectRepository
    {
        private static readonly List<Project> _projects = new List<Project>
        {
            new Project
            {
                Id = "project-1",
                Title = "IT_ELECTIVE_2_PRELIM_EXAM",
                ShortDescription = "Preliminary web design and layout structure.",
                Thumbnail = "/images/THUMB-FIRST.png",
                GithubUrl = "https://github.com/jeaguilar547-ui/PRELIM_EXAM_AGUILAR.git",
                TechStack = new List<string> { "HTML", "CSS", "JavaScript" },
                LongDescription = "Detailed description of the preliminary project implementation and architectural design."
            },
            new Project
            {
                Id = "project-2",
                Title = "IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Aguilar_JohnElias",
                ShortDescription = "Midterm module project exploring structured components.",
                Thumbnail = "/images/THUMB-SECOND.png",
                GithubUrl = "https://github.com/jeaguilar547-ui/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Aguilar_JohnElias.git",
                TechStack = new List<string> { "HTML", "CSS", "JavaScript", "C#" },
                LongDescription = "Midterm milestone project covering hands-on lab exercises and server-side logic."
            },
            new Project
            {
                Id = "project-3",
                Title = "IT_ELECTIVE_2MIDTERM_EXAM_set-5_Aguilar-John-Elias-",
                ShortDescription = "Full-featured ASP.NET Core MVC application.",
                Thumbnail = "/images/THUMB-THIRD.png",
                GithubUrl = "https://github.com/jeaguilar547-ui/IT_ELECTIVE_2_MIDTERM_EXAM_-set-5-_-Aguilar-John-Elias-.git",
                TechStack = new List<string> { "C#", "ASP.NET Core MVC" },
                LongDescription = "Developed using the Model-View-Controller pattern in .NET, demonstrating routing and views."
            },
         
        };

        public static List<Project> GetAllProjects() => _projects;
        public static Project GetProjectById(string id) => _projects.FirstOrDefault(p => p.Id == id);
    }
}