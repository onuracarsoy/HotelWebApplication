using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebUI.Controllers
{
    public class ContactCategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactCategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
