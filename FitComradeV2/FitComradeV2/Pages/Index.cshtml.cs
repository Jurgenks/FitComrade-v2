using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using FitComradeV2.Models;

namespace FitComradeV2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public SessionUser sessionUser = new SessionUser();

               
        public void OnGet()
        {
            sessionUser = sessionUser.GetSession(HttpContext.Session, sessionUser);          
            
        }

    }
}
