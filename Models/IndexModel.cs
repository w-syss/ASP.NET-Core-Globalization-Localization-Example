using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreGlobalizationExample.Models
{
    public class IndexModel
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateInput { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal CurrencyInput { get; set; }
    }
}
