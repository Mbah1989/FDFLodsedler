using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Board
{
    //[Authorize(Roles = "Administrator")]
    public class SletMedlemmerModel : PageModel
    {

        private IBestyrelse Bestyrelse;
        [BindProperty]
        public Bestyrelse bestyrelse { get; set; }

        public SletMedlemmerModel(IBestyrelse bestyrelse)
        {
            Bestyrelse = bestyrelse;
        }

        public void OnGet(int sid)
        {
            bestyrelse = Bestyrelse.GetMedlemmer(sid);

        }
        public IActionResult OnPost()
        {

            Bestyrelse.RemoveMedlemmer(bestyrelse);

            return RedirectToPage("/Board/VisMedlemmer");
        }
    }
}
