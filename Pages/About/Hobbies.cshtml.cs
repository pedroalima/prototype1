using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplicationTest.Pages
{
    public class HobbiesModel : PageModel
    {
        private readonly ILogger<HobbiesModel> _logger;

        public HobbiesModel(ILogger<HobbiesModel> logger)
        {
            _logger = logger;

            // Inicializando as propriedades no construtor
            Name = "Pedro";
            Age = 28;
        }

        public List<string> HobbiesList = new List<string>
        {
            "Play games",
            "Study",
            "Exercices"
        };

        [BindProperty]
        public string Name {get; set;}
        [BindProperty]
        public int Age {get; set;}

        public void OnGet()
        {
            
        }

        public void OnPost() 
        { 

        }
    }
}
