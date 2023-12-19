using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Leaders
{
    //[Authorize(Roles = "Administrator")]
    public class VisLederModel : PageModel
    {
        private Ileder Leder;

        [BindProperty]

        public IEnumerable<Leder> Leders { get; set; }

       

        public VisLederModel(Ileder leder)
        {
            Leder = leder;
        }

        public void OnGet()
        {
            Leders = Leder.GetLeder();
        }

    }
}
