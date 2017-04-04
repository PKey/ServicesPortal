using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicesPortal.Models
{
    [MetadataType(typeof(ServiceProviderMetadata))]
    public class ServiceProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Newsletter { get; set; }
        public int UserId { get; set; }
    }

    public class ServiceProviderMetadata
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} jest wymagany")]
        [Display(Name = "Email")]
        //:TODO dopisac regex
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} jest wymagane")]
        [Display(Name = "Miasto")]
        [StringLength(40,ErrorMessage = "{0} może mieć maksymalnie 40 znaków")]
        public string City { get; set; }
        [Required(ErrorMessage = "{0} jest wymagany")]
        [Display(Name = "Kod pocztowy")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "{0} jest wymagana")]
        [Display(Name = "Ulica")]
        [StringLength(40, ErrorMessage = "{0} może mieć maksymalnie 40 znaków")]
        public string Street { get; set; }
        [Display(Name = "Numer telefonu")]
        //TODO: dopisac regex
        public string PhoneNumber { get; set; }
        [Display(Name = "Potwierdzony")]
        public bool IsConfirmed { get; set; }
        [Display(Name = "Data rejestracji")]
        [DataType(DataType.DateTime)]
        public DateTime RegistrationDate { get; set; }
        public bool Newsletter { get; set; }
        [ScaffoldColumn(false)]
        public int UserId { get; set; }
    }
}