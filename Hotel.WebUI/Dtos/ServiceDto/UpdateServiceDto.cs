using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Lütfen ikon giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Lütfen başlık giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karekter giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen başlık giriniz")]
        [StringLength(500, ErrorMessage = "Lütfen en fazla 500 karekter giriniz.")]
        public string Description { get; set; }
    }
}
