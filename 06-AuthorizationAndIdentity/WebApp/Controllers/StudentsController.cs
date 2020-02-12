using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;

namespace WebApp.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {            
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

    }

}