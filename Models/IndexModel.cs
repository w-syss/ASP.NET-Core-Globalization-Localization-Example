using System;
using System.ComponentModel.DataAnnotations;

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
