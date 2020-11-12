using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using OnlineFurniture.Models;

namespace OnlineFurniture.Controllers
{
    [Route("api/[controller]"), ApiController]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

       
        

        
        //POST : /api/Account/Register
        //TODO ApplicationUserModel ->  RegisterViewModel
        [HttpPost]
        [Route("Register")]
        public async Task<Object> PostApplicationUser(ApplicationUserModel model)
        {
            Console.WriteLine("###################"+"Start");
            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                return Ok(result);
               
            }
            catch (Exception ex)
            {
                //Todo add logger ex
                
                return StatusCode(500);
                
            }
        }
    }
}
