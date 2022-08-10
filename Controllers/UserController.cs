using Microsoft.AspNetCore.Mvc;
using DemoIdentity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DemoIdentity.ViewModel;

namespace DemoIdentity.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public UserController (ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityUser identityUser =  new IdentityUser{
                    UserName = model.Email,
                    Email = model.Email
                };
                IdentityResult result = await _userManager.CreateAsync(identityUser, model.PassWord);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "User");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user==null)
            {
                ViewBag.ErrorMessage = $"User with id = {id} cannot be found.";
                return View("NotFound");
            }

            ViewBag.userId = user.Id;
            ViewBag.userName = user.UserName;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(DeleteUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user==null)
            {
                ViewBag.ErrorMessage = $"User with id = {model.Id} cannot be found.";
                return View("NotFound");
            }
            else
            {
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }
    }
}