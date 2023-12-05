using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.TestimonialDto
{
    public class AddTestimonialDto
    {
        [Required(ErrorMessage = "Lütfen ad giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Unvan giriniz")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karekter giriniz.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Lütfen resim giriniz")]
        public string Image { get; set; }
    }
}
