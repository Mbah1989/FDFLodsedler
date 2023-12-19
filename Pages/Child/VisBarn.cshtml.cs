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
        private IB�rn b�rn;

        [BindProperty]

        public IEnumerable<B�rn> b�rns { get; set; }

        public VisBarnModel(IB�rn b�rn)
        {
            this.b�rn = b�rn;
        }

        public void OnGet()
        {
            b�rns = b�rn.GetB�rn();
        }
    }
}
