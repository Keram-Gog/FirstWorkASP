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
    public class UpdateModel : PageModel
    {
        private readonly ILogger<UpdateModel> _logger;
        private readonly  DataClassRepositary _lectionRepository;

        public UpdateModel(ILogger<UpdateModel> logger, DataClassRepositary lectionRepository)
        {
            _logger = logger;
            _lectionRepository = lectionRepository;
        }
        public IList<DataClass> Languages { get; set; } = new List<DataClass>();
        public void OnGet()
        {
            //Lections = System.IO.File.ReadAllLines("Data/data.txt").ToList();
            Languages = _lectionRepository.GetList();
        }

        public void OnPost()
        {

            var theme12 = Request.Form["nameWhoUpdate"].FirstOrDefault();
            var theme123 = Request.Form["newName"].FirstOrDefault() + " "
                + Request.Form["newType"].FirstOrDefault() + " "
                + Request.Form["newReiting"].FirstOrDefault();
            _lectionRepository.Update(theme12, theme123);
            Response.Redirect("Update");
        }
    }
}
