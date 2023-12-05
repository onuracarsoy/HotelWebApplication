using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }

        [Required(ErrorMessage = "Lütfen Başlık 1 giriniz.")]
        [StringLength(50, ErrorMessage = "Lütfen en fazla 50 karakter giriniz.")]
        public string Title1 { get; set; }

        [Required(ErrorMessage = "Lütfen Başlık 2 giriniz.")]
        [StringLength(50, ErrorMessage = "Lütfen en fazla 500karakter giriniz.")]
        public string Title2 { get; set; }

        [Required(ErrorMessage = "Lütfen içerik giriniz.")]
        [StringLength(500, ErrorMessage = "Lütfen en fazla 500 karakter giriniz.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Lütfen oda sayısı giriniz.")]
        public int RoomCount { get; set; }

        [Required(ErrorMessage = "Lütfen personel sayısı giriniz.")]
        public int StaffCount { get; set; }

        [Required(ErrorMessage = "Lütfen müşteri sayısı giriniz.")]
        public int CustomerCount { get; set; }
    }
}
