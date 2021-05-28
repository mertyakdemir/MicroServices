using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Orders
{
    public class CheckoutInfoInput
    {
        [Display(Name = "City")]
        public string Province { get; set; }

        [Display(Name = "District")]
        public string District { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }

        [Display(Name = "Postal code")]
        public string ZipCode { get; set; }

        [Display(Name = "Address")]
        public string Line { get; set; }

        [Display(Name = "Card name surname")]
        public string CardName { get; set; }

        [Display(Name = "Card number")]
        public string CardNumber { get; set; }

        [Display(Name = "expiration date (month / year)")]
        public string Expiration { get; set; }

        [Display(Name = "CVV no")]
        public string CVV { get; set; }
    }
}
