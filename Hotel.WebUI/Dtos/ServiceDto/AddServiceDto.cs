using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.ServiceDto
{
    public class AddServiceDto
    {

        [Required(ErrorMessage="Lütfen ikon giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage ="Lütfen başlık giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama giriniz")]
        [StringLength(500, ErrorMessage = "Lütfen en fazla 500 karakter giriniz.")]
        public string Description { get; set; }
    }
}
