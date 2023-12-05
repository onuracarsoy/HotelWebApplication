using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Models
{
    public class AdminMailViewModel
    {

        public int ContactID { get; set; }

        [Required(ErrorMessage = "Lütfen alıcı mail giriniz.")]
        public string Mail { get; set; }



        public string Name { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Lütfen konu giriniz.")]
        public string ASubject { get; set; }

        [Required(ErrorMessage = "Lütfen mesaj giriniz.")]
        public string Body { get; set; }
    }
}
