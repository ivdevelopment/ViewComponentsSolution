using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ViewComponents.ViewComponents
{
    public class Reclame : ViewComponent
    {
        static string[] powerbars = { "mars", "bounty", "snickers", "twix" };
        public IViewComponentResult Invoke(string tekst, bool html)
        {
            if (html)
                return new HtmlContentViewComponentResult(new HtmlString(tekst));
            else
                return Content(tekst);

            /*return new HtmlContentViewComponentResult(new HtmlString("Deze tekst zal <letterlijk> worden weergegeven."));*/

            /*return Content("Deze tekst zal <letterlijk> worden weergegeven.");*/

            /*Random random = new();
            int randomNummer = random.Next(0, 4);
            return View((object)powerbars[randomNummer]);*/
        }
    }
}
