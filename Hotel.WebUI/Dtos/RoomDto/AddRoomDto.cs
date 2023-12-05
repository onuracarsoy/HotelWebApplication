using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.RoomDto
{
    public class AddRoomDto
    {

        [Required(ErrorMessage = "Lütfen oda numarası giriniz.")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda resmi giriniz.")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen bir fiyat giriniz.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen bir başlık giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz.")]
        public string BathCount { get; set; }

        [Required(ErrorMessage = "Lütfen wifi bilgisi giriniz.")]
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen bir açıklama giriniz.")]
        [StringLength(500, ErrorMessage = "Lütfen en fazla 500 karakter giriniz.")]
        public string Descripton { get; set; }
    }
}
