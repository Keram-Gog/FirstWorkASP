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
    public class RemoveModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataClassRepositary _languageRepository;

        public RemoveModel(ILogger<IndexModel> logger, DataClassRepositary languageRepository)
        {
            _logger = logger;
            _languageRepository = languageRepository;
        }
        public List<DataClass> Languages { get; set; } = new List<DataClass>();
        public void OnGet()
        {
            Languages = _languageRepository.GetList();
        }
        public void OnPost()
        {
            var theme1 = Request.Form["nameRemove"].FirstOrDefault();
            _languageRepository.Remove(theme1);
            Response.Redirect("Remove");

        }
    }
}
