using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBook.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Is required")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        [Range(100, 10000)]
        public int PagesNumber { get; set; }
        public string Publisher { get; set; }

        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$")]
        public string PublicationDate { get; set; }
        public string Content { get; set; }
        
        public decimal Price { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Price")]
        public decimal PriceConfirm { get; set; }
    }
}