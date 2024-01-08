using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationTest.Pages
{
    public class HobbiesModel : PageModel
    {
        private readonly ILogger<HobbiesModel> _logger;

        public HobbiesModel(ILogger<HobbiesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
