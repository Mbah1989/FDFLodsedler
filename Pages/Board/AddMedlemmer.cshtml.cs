using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace FDFLodsedler.Pages.Board
{
    //[Authorize(Roles = "Administrator")]
    public class AddMedlemmerModel : PageModel
    {
      
        private IBestyrelse Bestyrelse;

        public AddMedlemmerModel(IBestyrelse bestyrelse)
        {
            Bestyrelse = bestyrelse;
        }

        [BindProperty]
        public Bestyrelse bestyrelse { get; set; }
        
       

        public void OnGet()
        {
           

        }

        public IActionResult OnPost()
        {
            //if(!ModelState.IsValid)
            //{
            // return Page();
            //}
            Bestyrelse.AddMedlemmer(bestyrelse);

            return RedirectToPage("/Board/VisMedlemmer");
        }
    }
}
