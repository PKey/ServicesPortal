using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ServicesPortal.Models
{
    [MetadataType(typeof(CustomerMetadata))]
    public class Customer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Newsletter { get; set; }
        public int UserId { get; set; }

    }

    public class CustomerMetadata
    {
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} jest wymagany")]
        //TODO: DOPISAĆ REGEX
        public string Email { get; set; }
        [Display(Name = "Miasto")]
        [Required(ErrorMessage = "{0} jest wymagane")]
        [StringLength(40,ErrorMessage = "{0} może mieć maksymalnie 40 znaków")]
        public string City { get; set; }
        [Display(Name = "Kod pocztowy")]
        [Required(ErrorMessage = "{0} jest wymagany")]
        //TODO: DOPISAĆ REGEX
        public string ZipCode { get; set; }
        [Display(Name = "Ulica")]
        [Required(ErrorMessage = "{0} jest wymagana")]
        [StringLength(40, ErrorMessage = "{0} może mieć maksymalnie 40 znaków")]
        public string Street { get; set; }
        [Display(Name = "Potwierdzony")]
        public bool IsConfirmed { get; set; }
        [Display(Name = "Data rejestracji")]
        public DateTime RegistrationDate { get; set; }
    }
}