using Hotel.EntityLayer.Concrete;
using Hotel.WebUI.Dtos.AboutDto;
using Hotel.WebUI.Dtos.BookingDto;

using Hotel.WebUI.Dtos.ContactDto;
using Hotel.WebUI.Dtos.StaffDto;
using Hotel.WebUI.Dtos.SubscribeDto;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MimeKit;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Hotel.WebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _SubscribePartial(AddSubscribeDto model)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:35777/api/Subscribe", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }


            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Services()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Rooms()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Booking(AddBookingDto model)
        {

            model.Description = "Default";
            model.Status = "Onay Bekliyor";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:35777/api/Booking", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                MimeMessage mimeMessage = new MimeMessage();
                //kimden
                MailboxAddress mailboxAddressFrom = new MailboxAddress("Hotelier", "easycashdogrulama@gmail.com");
                mimeMessage.From.Add(mailboxAddressFrom);
                //kime
                MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.Mail);
                mimeMessage.To.Add(mailboxAddressTo);
                //mesaj
                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Rezervasyonunuz alındı!" +
                    " Bizi tercih ettiğiniz teşekkür ederiz." +
                    " En kısa zamanda size geri dönüş yapacağız.";
                mimeMessage.Body = bodyBuilder.ToMessageBody();
                //konu
                mimeMessage.Subject = "Rezervasyon";

                SmtpClient clients = new SmtpClient();
                clients.Connect("smtp.gmail.com", 587, false);
                clients.Authenticate("easycashdogrulama@gmail.com", "bodlygsdcguqcbbm");
                clients.Send(mimeMessage);
                clients.Disconnect(true);

                return RedirectToAction("Index", "Default");
            }


            return View();
        }

        [HttpGet]
        public IActionResult Testimonials()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
          
            return View();


        }

        [HttpPost]
        public async Task<IActionResult> Contact(AddContactDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:35777/api/Contact", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }


            return View();
        }





    }
}
