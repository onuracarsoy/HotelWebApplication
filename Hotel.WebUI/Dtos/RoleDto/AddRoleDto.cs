using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.RoleDto
{
    public class AddRoleDto
    {
        [Required(ErrorMessage = "Lütfen rol giriniz.")]
        public string  RoleName { get; set; }
    }
}
