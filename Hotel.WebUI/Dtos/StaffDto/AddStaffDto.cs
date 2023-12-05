using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.StaffDto
{
    public class AddStaffDto
    {


        [Required(ErrorMessage = "Lütfen ad giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen unvan giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karekter giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen sosyal medya 1 giriniz")]
        public string SocaialMedia1 { get; set; }

        [Required(ErrorMessage = "Lütfen sosyal medya 2 giriniz")]
        public string SocaialMedia2 { get; set; }

        [Required(ErrorMessage = "Lütfen sosyal medya 3 giriniz")]
        public string SocaialMedia3 { get; set; }
    }
}
