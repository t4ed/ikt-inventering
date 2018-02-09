using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    [MetadataType(typeof(StaffMetaData))]
    public partial class Staff { }

    public partial class StaffMetaData
    {
        [Required(ErrorMessage = "Användarnamnet är blankt")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Användarnamnet måste vara mellan 3 och 25 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9\s]*$", ErrorMessage = "Användarnamnet kan inte ha speciella tecken")]
        [Display(Name = "Användarnamn")]
        public string Username;

        [Required(ErrorMessage = "Namnet är blankt")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Namnet måste vara mellan 3 och 25 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9\s-]*$", ErrorMessage = "Namnet kan inte ha speciella tecken")]
        [Display(Name = "Förnamn")]
        public string FirstName;

        [Required(ErrorMessage = "Namnet är blankt")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Namnet måste vara mellan 3 och 25 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9\s-]*$", ErrorMessage = "Namnet kan inte ha speciella tecken")]
        [Display(Name = "Efternamn")]
        public string LastName;
    }
}