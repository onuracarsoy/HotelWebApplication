using Hotel.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IRoomService _roomService;
        private readonly ITestimonialService _testimonialService;
        private readonly IContactService _contactService;
        private readonly IBookingService _bookingService;

        public DashboardController(IStaffService staffService, IRoomService roomService, ITestimonialService testimonialService, IContactService contactService, IBookingService bookingService)
        {
            _staffService = staffService;
            _roomService = roomService;
            _testimonialService = testimonialService;
            _contactService = contactService;
            _bookingService = bookingService;
        }

        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);

        }

        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            var value = _roomService.TGetRoomCount();
            return Ok(value);

        }

        [HttpGet("TestimonialCount")]
        public IActionResult TestimonialCount()
        {
            var value = _testimonialService.TGetTestimonialCount();
            return Ok(value);

        }

        [HttpGet("ContactCount")]
        public IActionResult ContactCount()
        {
            var values = _contactService.TGetContactCount();

            return Ok(values);
        }
        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var values = _bookingService.TGetBookingCount();

            return Ok(values);
        }

        [HttpGet("ConfirmBookingCount")]
        public IActionResult ConfirmBookingCount()
        {
            var values = _bookingService.TConfirmBookingCount();

            return Ok(values);


        }

        [HttpGet("DeniedBookingCount")]
        public IActionResult DeniedBookingCount()
        {
            var values = _bookingService.TDeniedBookingCount();

            return Ok(values);
        }

        [HttpGet("WaitBookingCount")]
        public IActionResult WaitBookingCount()
        {
            var values = _bookingService.TWaitBookingCount();

            return Ok(values);
        }

    }
}
