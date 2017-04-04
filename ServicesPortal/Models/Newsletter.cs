using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicesPortal.Models
{
    public class Newsletter
    {
        [Display(Name = "Temat")]
        [Required(ErrorMessage = "{0} jest wymagany")]
        [StringLength(20,ErrorMessage = "{0} może mieć maksymalnie 20 znaków")]
        public string Subject { get; set; }

        [Display(Name = "Treść")]
        [Required(ErrorMessage = "{0} jest wymagana")]
        [StringLength(200, ErrorMessage = "{0} może mieć maksymalnie 200 znaków")]
        public string Content { get; set; }
    }
}