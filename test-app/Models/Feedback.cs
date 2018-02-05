using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcDataViews.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "The ID is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is required.")]
        public string Name { get; set; }

        
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The comment is required.")]
        public string Comment { get; set; }

    }
}