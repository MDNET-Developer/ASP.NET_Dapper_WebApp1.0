using System.ComponentModel.DataAnnotations;

namespace Dapper.WebAppCV.Areas.Admin.Models
{
    public class AppUserLoginModel
    {
        [Required(ErrorMessage ="İstifadəçi adını daxil edin !!!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifrəni daxil edin !!!")]
        public string Password { get; set; }
        public   bool RememberMe { get; set; }
    }
}
