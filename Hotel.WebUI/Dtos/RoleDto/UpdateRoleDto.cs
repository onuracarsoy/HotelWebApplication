using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.RoleDto
{
    public class UpdateRoleDto
    {
        public int RoleID { get; set; }

        [Required(ErrorMessage = "Lütfen rol giriniz.")]
        public string RoleName{ get; set; }
    }
}
