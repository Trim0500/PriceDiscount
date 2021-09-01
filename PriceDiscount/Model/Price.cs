using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PriceDiscount.Model
{
    public class Price
    {
        [Required(ErrorMessage = "You must enter a total")]
        [Range(0, 1000000, ErrorMessage = "You must enter a value within the range of 0 to 1,000,000")]
        public double? subTotal { get; set; }
        [Required(ErrorMessage = "You must enter a discount")]
        [Range(0, 75, ErrorMessage = "You must enter a value between 0 and 75%")]
        public double? discountPercent { get; set; }
        public double? discountTotal { get; set; }
        public double? grandTotal { get; set; }
        public double calculateDiscountTotal()
        {
            double total;
            double discount;
            discount = (double)discountPercent / 100;

            total = (double)subTotal * discount;

            return total;
        }

        public double calculateGrandTotal()
        {
            double discount;
            double totalDiscount;
            double grandTotal;
            discount = (double)discountPercent / 100;

            totalDiscount = (double)subTotal * discount;

            grandTotal = (double)subTotal - totalDiscount;

            return grandTotal;
        }
    }
}
