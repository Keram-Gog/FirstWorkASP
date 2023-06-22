using Lab2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Pages
{
    [IgnoreAntiforgeryToken]
    public class AddModel : PageModel
    {
        private readonly ILogger<AddModel> _logger;
        private readonly DataClassRepositary _languageRepository;

        public AddModel(ILogger<AddModel> logger, DataClassRepositary lectionRepository)
        {
            _logger = logger;
            _languageRepository = lectionRepository;
        }
        public void OnPost()
        {
            var theme = Request.Form["nameAdd"].FirstOrDefault() + " "
                + Request.Form["typeAdd"].FirstOrDefault() + " "
                + Request.Form["reitingAdd"].FirstOrDefault();
            if (!string.IsNullOrEmpty(theme))
                _languageRepository.Add(theme);
            Response.Redirect("Adding");
        }
    }
}
