using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicesPortal.Models
{
    [MetadataType(typeof(CommentMetadata))]
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string IPAddress { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public int CommentCategoryId { get; set; }
        public virtual Service Services { get; set; }
        public virtual CommentCategory CommentCategory { get; set; }

    }

    public class CommentMetadata
    {
        [Display(Name = "Treść komentarza")]
        [StringLength(200, ErrorMessage = "{0} może mieć maksymalnie 200 znaków")]
        public string Content { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Data dodania")]
        public DateTime Date { get; set; }
        [Display(Name = "Kategoria")]
        public string CommentCategory { get; set; }
    }
}