using AutoMapper;
using Hotel.EntityLayer.Concrete;
using Hotel.WebUI.Dtos.AboutDto;
using Hotel.WebUI.Dtos.BookingDto;

using Hotel.WebUI.Dtos.ContactDto;
using Hotel.WebUI.Dtos.LoginDto;
using Hotel.WebUI.Dtos.RegisterDto;
using Hotel.WebUI.Dtos.RoomDto;
using Hotel.WebUI.Dtos.ServiceDto;
using Hotel.WebUI.Dtos.StaffDto;
using Hotel.WebUI.Dtos.SubscribeDto;
using Hotel.WebUI.Dtos.TestimonialDto;
using Hotel.WebUI.Models;
using System.Diagnostics.Contracts;

namespace Hotel.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {

        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<AddServiceDto, Service>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
            CreateMap<AddStaffDto, Staff>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<AddTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<AddRoomDto, Room>().ReverseMap();


            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();


            CreateMap<ResultBookingDto,Booking>().ReverseMap();
            CreateMap<AddBookingDto, Booking>().ReverseMap();
            CreateMap<UpdateBookingDto, Booking>().ReverseMap();

            CreateMap<ResultContactDto, Contact>().ReverseMap();
            CreateMap<AddContactDto, Contact>().ReverseMap();



            CreateMap<AddUserDto, AppUser>().ReverseMap();

            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<AddSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<AdminMailViewModel, Contact>().ReverseMap();
        }
    }
}
