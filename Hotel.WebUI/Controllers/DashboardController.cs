using Hotel.BussinesLayer.Abstract;
using Hotel.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;
using MimeKit.Cryptography;
using Newtonsoft.Json;

namespace Hotel.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public  async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            //Oda Consume
            var responseMessage = await client.GetAsync("http://localhost:35777/api/Dashboard/RoomCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                ViewBag.RoomCount = jsonData;
            }



            //Personel Consume
            var responseMessage2 = await client.GetAsync("http://localhost:35777/api/Dashboard/StaffCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();

                ViewBag.StaffCount = jsonData2;
            }

            //Referans Consume
            var responseMessage3 = await client.GetAsync("http://localhost:35777/api/Dashboard/TestimonialCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();

                ViewBag.TestimonialCount = jsonData3;
            }

            //İletişim Consume
            var responseMessage4 = await client.GetAsync("http://localhost:35777/api/Dashboard/ContactCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();

                ViewBag.ContactCount = jsonData4;
            }

            //Rezervasyon Consume
            var responseMessage8 = await client.GetAsync("http://localhost:35777/api/Dashboard/BookingCount");
            if (responseMessage8.IsSuccessStatusCode)
            {
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();

                ViewBag.BookingCount = jsonData8;
            }

            //Rezervasyon Onaylandı Consume
            var responseMessage5 = await client.GetAsync("http://localhost:35777/api/Dashboard/ConfirmBookingCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                var jsonData5 = await responseMessage4.Content.ReadAsStringAsync();

                ViewBag.ConfirmBookingCount = jsonData5;
            }

            //Rezervasyon Onaylanmadı Consume
            var responseMessage6 = await client.GetAsync("http://localhost:35777/api/Dashboard/DeniedBookingCount");
            if (responseMessage6.IsSuccessStatusCode)
            {
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();

                ViewBag.DeniedBookingCount = jsonData6;
            }

            //Rezervasyon Onay Bekliyor Consume
            var responseMessage7 = await client.GetAsync("http://localhost:35777/api/Dashboard/WaitBookingCount");
            if (responseMessage7.IsSuccessStatusCode)
            {
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();

                ViewBag.WaitBookingCount = jsonData7;
            }



            return View();
        }

      
    }
}
