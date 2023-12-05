using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.RegisterDto
{
    public class AddUserDto
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcıadı giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen mailinizi giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifre giriniz.")]
        public string Password{ get; set; }

        [Required(ErrorMessage = "Lütfen tekrar şifre giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor!")]
        public string ConfirmPassword { get; set; }





    }
}
