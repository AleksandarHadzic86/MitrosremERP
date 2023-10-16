using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Enum
{
   public enum TipUgovora
    {
        [Display(Name = "Odredjeno")]
        [EnumDataType(typeof(TipUgovora), ErrorMessage = "Nije odgovarajuca vrednost ugovora")]
        Odredjeno,

        [Display(Name = "Neodredjeno")]
        [EnumDataType(typeof(TipUgovora), ErrorMessage = "Nije odgovarajuca vrednost ugovora")]
        Neodredjeno
    }
}
