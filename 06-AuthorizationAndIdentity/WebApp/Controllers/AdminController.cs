using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(UserManager<IdentityUser> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {            
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            var userRoles = await _userManager.GetRolesAsync(user);

            var editModel = new UserWithRoleViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                Role = userRoles.FirstOrDefault()
            };

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(UserWithRoleViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == model.Id);
            
            if(model.Role != null)
            {
                await _userManager.AddToRoleAsync(user, model.Role);
            }

            return RedirectToAction("Index");
        }
    }

}