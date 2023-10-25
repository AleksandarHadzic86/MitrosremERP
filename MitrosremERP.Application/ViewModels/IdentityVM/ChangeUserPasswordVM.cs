using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.IdentityVM
{
    public class ChangeUserPasswordVM
    {
        [Required(ErrorMessage = "Lozinka obavezna")]
        [StringLength(100, ErrorMessage = "{0} mora da bude {2} i maksimalno {1} karaktera.", MinimumLength = 6)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[^a-zA-Z\d]).+$", ErrorMessage = "Lozinka mora da sadrži bar jedno veliko slovo i jedan znak (!?.,#%@)")]
        [Display(Name = "Nova lozinka")]
        public string NewPassword { get; set; }

        [Display(Name = "Potvrdi Lozinku")]
        [Compare("NewPassword", ErrorMessage = "Lozinke se ne podudaraju")]
        public string ConfirmPassword { get; set; }
    }
}
