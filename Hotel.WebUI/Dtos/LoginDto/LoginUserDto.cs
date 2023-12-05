using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Lütfen bir kullanıcı adı giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen bir şifre giriniz.")]
        public string Password { get; set; }
    }
}
