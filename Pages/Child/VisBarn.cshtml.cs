using FDFLodsedler.Interface;
using FDFLodsedler.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FDFLodsedler.Pages.Child
{
    //[Authorize(Roles = "Administrator")]
    public class VisBarnModel : PageModel
    {
        private IBørn børn;

        [BindProperty]

        public IEnumerable<Børn> børns { get; set; }

        public VisBarnModel(IBørn børn)
        {
            this.børn = børn;
        }

        public void OnGet()
        {
            børns = børn.GetBørn();
        }
    }
}
