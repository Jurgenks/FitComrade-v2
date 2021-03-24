using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FitComradeV2.Models;

namespace FitComradeV2.Pages.Login
{
    public class LoginAccountModel : PageModel
    {

        [BindProperty]
        public Profile Profile { get; set; }

        public void OnGet()
        {

        }
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if(!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    Profile = Profile.Login(HttpContext.Session, Profile);
            
        //}
    }
}
