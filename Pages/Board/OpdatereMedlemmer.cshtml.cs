using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Board
{
    public class OpdatereMedlemmerModel : PageModel
    {
        private IBestyrelse Bestyrelse;

        [BindProperty]

        public Bestyrelse bestyrelse { get; set; }

        public OpdatereMedlemmerModel(IBestyrelse bestyrelse)
        {
            Bestyrelse = bestyrelse;
        }

        public void OnGet(int sid)
        {
            bestyrelse = Bestyrelse.GetMedlemmer(sid);

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Bestyrelse.UpdateMedlemmer(bestyrelse);

            return RedirectToPage("/Board/VisMedlemmer");

        }
    }
}
