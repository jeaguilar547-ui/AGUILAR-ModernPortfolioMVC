
using Microsoft.AspNetCore.Mvc;

namespace AGUILAR_ModernPortfolioMVC.Controllers
{
    public class AuthController : Controller
{
    private const string AdminUser = "admin";
    private const string AdminPass = "SecurePortfolio2026!";

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (username == AdminUser && password == AdminPass)
        {
            HttpContext.Session.SetString("UserSession", AdminUser);
            TempData["SuccessMessage"] = "Successfully logged in!";
            return RedirectToAction("Index", "Portfolio");
        }

        ModelState.AddModelError("", "Invalid username or password.");
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Portfolio");
    }
}
}
