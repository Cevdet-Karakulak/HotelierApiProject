using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        private void FillDropdowns()
        {
            ViewBag.Genders = new List<SelectListItem>
            {
                new SelectListItem { Text = "Kadın", Value = "Kadın" },
                new SelectListItem { Text = "Erkek", Value = "Erkek" }
            };

            ViewBag.Image = new List<SelectListItem>
            {
                new SelectListItem { Text = "Kadın", Value = "/adminweb/images/avatar/4.jpg" },
                new SelectListItem { Text = "Erkek", Value = "/adminweb/images/avatar/2.jpg" }
            };

            ViewBag.Countries = new List<SelectListItem>
            {
                new SelectListItem { Text = "Türkiye", Value = "Türkiye" },
                new SelectListItem { Text = "Almanya", Value = "Almanya" },
                new SelectListItem { Text = "ABD", Value = "ABD" },
                new SelectListItem { Text = "Fransa", Value = "Fransa" },
                new SelectListItem { Text = "İngiltere", Value = "İngiltere" },
                new SelectListItem { Text = "İtalya", Value = "İtalya" },
                new SelectListItem { Text = "İspanya", Value = "İspanya" },
                new SelectListItem { Text = "Diğer", Value = "Diğer" }
            };
        }

        [HttpGet]
        public IActionResult Index()
        {
            FillDropdowns();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            FillDropdowns();

            if (!ModelState.IsValid)
            {
                return View();
            }

            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.Username,
                ImageUrl = createNewUserDto.ImageUrl,
                WorkDepartment = "Belirtilmedi",
                WorkLocationID = 1,
                Gender = createNewUserDto.Gender,
                Country = createNewUserDto.Country,
                City = createNewUserDto.City
            };

            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
