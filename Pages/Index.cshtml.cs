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

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataClassRepositary _languageRepository;

        public IndexModel(ILogger<IndexModel> logger, DataClassRepositary languageRepository)
        {
            _logger = logger;
            _languageRepository = languageRepository;
        }
        public List<DataClass> Languages { get; set; } = new List<DataClass>();
        public void OnGet()
        {
             Languages = _languageRepository.GetList();
        }

    }
}