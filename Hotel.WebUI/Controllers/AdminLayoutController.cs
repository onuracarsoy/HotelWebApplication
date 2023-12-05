using Hotel.WebUI.Dtos.ServiceDto;
using Hotel.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace Hotel.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminLayoutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public ActionResult _AdminLayout()
        {
            return View();
           

        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult ProloaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavheaderPartial()
        {
            return PartialView();
        }


        public PartialViewResult HeaderPartial()
        {


            return PartialView();
        }

        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }


        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
