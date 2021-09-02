using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PriceDiscount.Model
{
    //Model class for the data inoutted and calculated
    public class Price
    {
        [Required(ErrorMessage = "You must enter a total")] //Use the tag helpers from the view imports to declare a required field with a custom message
        [Range(0, 1000000, ErrorMessage = "You must enter a value within the range of 0 to 1,000,000")] //Use the tag helpers from the view imports to declare a range for the field with a custom message
        public double? subTotal { get; set; }
        [Required(ErrorMessage = "You must enter a discount")]
        [Range(0, 75, ErrorMessage = "You must enter a value between 0 and 75%")]
        public double? discountPercent { get; set; }
        public double? discountTotal { get; set; }
        public double? grandTotal { get; set; }

        //Declare a method to calculate the discount total
        public double? calculateDiscountTotal()
        {
            double total;
            double discount;
            discount = (double)discountPercent / 100;

            total = (double)subTotal * discount;

            return total;
        }

        //Declare a function to calculate the grand total
        public double? calculateGrandTotal()
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
