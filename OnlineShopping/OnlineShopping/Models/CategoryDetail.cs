using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required (ErrorMessage ="Category Name Requird")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Minimum 5 and Maximum 100 charaters are allwed", MinimumLength = 3 )]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }

    }

    public class ProductDetail
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Category Name Requird")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Minimum 5 and Maximum 100 charaters are allwed", MinimumLength = 3)]
        public string ProductName { get; set; }
        [Required]
        [Range(1,50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CategoryDate { get; set; }
        public Nullable<System.DateTime> ModifieDate { get; set; }
        public Nullable<System.DateTime> Description { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        [Required]
        [Range(typeof(int) , "1","500" ,ErrorMessage = "Invalid Quantity")]
        public Nullable<int> Quantitya { get; set; }
        [Required]
        [Range(typeof(int), "1", "200000000", ErrorMessage = "Invalid Price")]
        public Nullable<decimal> Price { get; set; }

        public SelectList Categories { get; set; }
            
    }


}