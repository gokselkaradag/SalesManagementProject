using Microsoft.AspNetCore.Mvc;
using SalesManagementProject.Models;

namespace SalesManagementProject.Controllers
{
    public class SalesManagement : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
