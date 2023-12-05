using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.BookingDto
{
    public class UpdateBookingDto
    {

        public int BookingID { get; set; }

        [Required(ErrorMessage = "Lütfen ad soyad giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen giriş tarihi giriniz.")]
        public DateTime CheckIn { get; set; }

        [Required(ErrorMessage = "Lütfen çıkış tarihi giriniz.")]
        public DateTime CheckOut { get; set; }

        [Required(ErrorMessage = "Lütfen yetişkin sayısı giriniz.")]
        public string AdultCount { get; set; }

        [Required(ErrorMessage = "Lütfen çocuk sayısı giriniz.")]
        public string ChildCount { get; set; }

        [Required(ErrorMessage = "Lütfen oda sayısı giriniz.")]
        public string RoomCount { get; set; }

      
        public string? SpecialRequest { get; set; }

        [Required(ErrorMessage = "Lütfen Açıklama giriniz.")]
        public string Description { get; set; }


        public string Status { get; set; }
    }
}
