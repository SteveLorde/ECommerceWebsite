using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationRazor.Pages
{
    public class LoginProfile : PageModel
    {
        private readonly ILogger<LoginProfile> _logger;

        public LoginProfile(ILogger<LoginProfile> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}