using AmoebaTemplate.DAL;
using AmoebaTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmoebaTemplate.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CustomServiceController : Controller
    {
        private readonly AppDbContext _context;

        public CustomServiceController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<CustomService> customServices=await _context.CustomServices.ToListAsync();

            return View(customServices);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
