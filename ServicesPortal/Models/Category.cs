using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicesPortal.Models
{
    [MetadataType(typeof(CategoryMetadata))]
    public class Category
    {
        public Category()
        {
            this.Services = new HashSet<Service>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }

    public class CategoryMetadata
    {
        [Required(ErrorMessage = "{0} jest wymagana")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
    }
}