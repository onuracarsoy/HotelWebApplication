using Hotel.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.ContactDto
{
    public class AddContactDto
    {
        [Required(ErrorMessage = "Lütfen ad soyad giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen konu giriniz.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Lütfen mesaj giriniz.")]
        [StringLength(500, ErrorMessage = "Lütfen en fazla 500 karakter giriniz.")]
        public string Message { get; set; }

    




    }
}
