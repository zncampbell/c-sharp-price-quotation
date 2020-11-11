using System;
using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a value for the sales price.")]
        [Range(0, 5000, ErrorMessage = "The sales price must be a number between 0 and 5000.")]
        public decimal? subTotal { get; set; }

        [Required(ErrorMessage = "Please enter a value for the discount percentage.")]
        [Range(0, 100, ErrorMessage = "The percent must be between 0 and 100.")]
        public decimal? percent { get; set; }
        public decimal? CalculateDiscount ()
        {
            decimal? discount = (percent / 100) * subTotal;
            return discount;
        }
        public decimal? CalculateTotal ()
        {
            decimal? total = subTotal - ((percent / 100) * subTotal);
            return total;
        }


    }
}
