using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicesPortal.Models
{
    [MetadataType(typeof(ServiceMetadata))]
    public class ServiceModel
    {
        public ServiceModel()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string IPAdress { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Categories { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }

    public class ServiceMetadata
    {
        [Required(ErrorMessage = "{0} jest wymagana")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} jest wymagana")]
        [Display(Name = "Treść usługi")]
        public string Content { get; set; }
        [Required(ErrorMessage = "{0} jest wymagana")]
        [Display(Name = "Kategoria")]
        [ScaffoldColumn(false)]
        public int CategoryId { get; set; }
        [Display(Name = "Data umieszczenia")]
        [Required(ErrorMessage = "{0} jest wymagana")]
        [DataType(DataType.DateTime)]
        public DateTime PostedDate { get; set; }
        [Display(Name = "Data wygaśnięcia")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "{0} jest wymagana")]
        public DateTime ExpirationDate { get; set; }
    }
}