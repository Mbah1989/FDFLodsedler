using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Sales
{
    //[Authorize(Roles = "Administrator")]
    public class OverSkudModel : PageModel
    {
        private ISalg Salg;

        public OverSkudModel(ISalg salg)
        {
            Salg = salg;
        }

        [BindProperty]

        public int  Salgs { get; set; }





        public void OnGet()
        {
            Salgs = Salg.Overskud();
        }
    }
}
