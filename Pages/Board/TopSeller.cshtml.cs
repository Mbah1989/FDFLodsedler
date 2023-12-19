using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Board
{
    //[Authorize(Roles = "Administrator")]
    public class TopSellerModel : PageModel

    {
        
        private ISalg salg;
        [BindProperty]
        public IEnumerable<Salg>salgs { get; set; }

        [BindProperty]
        public IEnumerable<Børn> børn { get; set; }
      

       

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
