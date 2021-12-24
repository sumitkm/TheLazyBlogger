using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheLazyBlogger.Models;

namespace TheLazyBlogger.Controllers;

public class BlogController : Controller
{
    private readonly ILogger<BlogController> _logger;

    public BlogController(ILogger<BlogController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Hello");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
