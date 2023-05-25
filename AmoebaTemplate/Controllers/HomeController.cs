using AmoebaTemplate.DAL;
using AmoebaTemplate.Models;
using AmoebaTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmoebaTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context; 
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Sliders.ToListAsync();
            List<TeamMember> tmember = await _context.TeamMembers.ToListAsync();
            List<CustomService> service = await _context.CustomServices.ToListAsync();


            HomeVM homeVM = new HomeVM
            {
                Sliders = slider,
                TeamMembers= tmember,
                CustomServices=service

            };
           
            return View(homeVM);
        }

    }
}
