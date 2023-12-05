using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebUI.ViewComponents.Default
{
    public class _RezervationPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
