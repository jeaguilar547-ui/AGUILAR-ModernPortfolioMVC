using Microsoft.AspNetCore.Mvc;
using AGUILAR_ModernPortfolioMVC.Models;

namespace AGUILAR_ModernPortfolioMVC.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index() => View(ProjectRepository.GetAllProjects());

        public IActionResult Detail(string id)
        {
            var project = ProjectRepository.GetProjectById(id);
            if (project == null) return NotFound();
            return View(project);
        }

        [HttpPost]
        public IActionResult AddComment(string id, string author, string text)
        {
            var project = ProjectRepository.GetProjectById(id);
            if (project != null && !string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(text))
            {
                project.Comments.Add(new Comment { Author = author, Text = text });
            }
            return RedirectToAction("Detail", new { id });
        }
    }
}
