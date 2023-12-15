using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Board
{
    public class TopSellerModel : PageModel
    {
        private ISalg salg;
        [BindProperty]
        public IEnumerable<Salg>salgs { get; set; }

        public TopSellerModel(ISalg salg)
        {
            this.salg = salg;
        }

        public void OnGet()
        {
            salgs = salg.TopSalg();

        }
    }
}
