using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicesPortal.Models
{
    [MetadataType(typeof(CommentCategoryMetadata))]
    public class CommentCategory
    {
        public CommentCategory()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }

    public class CommentCategoryMetadata
    {
        [Required(ErrorMessage = "{0} jest wymagana")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
    }
}