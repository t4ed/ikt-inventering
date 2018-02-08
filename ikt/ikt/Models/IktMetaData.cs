using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ikt.Models
{
    [MetadataType(typeof(IktMetaData))]
    public partial class Ikt { }

    public partial class IktMetaData
    {
        [Required(ErrorMessage = "Namnet är blankt")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Namnet Måste vara mellan 3 och 100 tecken")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9\s'-'---]*$", ErrorMessage = "Namnet kan inte ha speciella tecken")]
        [Display(Name = "Namn")]
        public string Name;

        [Required(ErrorMessage = "Beskrivningen är blank")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Beskrivningen måste vara mellan 10 och 500 tecken")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[,.a-zåäöA-ZÅÄÖ0-9'-'---\s:;(-)/]*$", ErrorMessage = "Beskrivningen kan inte innehålla speciella tecken")]
        [Display(Name = "Beskrivning")]
        public string Description;

        [StringLength(500, MinimumLength = 5, ErrorMessage = "Kommentaren måste vara mellan 5 och 500 tecken")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[,.a-zåäöA-ZÅÄÖ0-9'-'---\s:;(-)/]*$", ErrorMessage = "Kommentaren kan inte innehålla speciella tecken")]
        [Display(Name = "Kommentar")]
        public string Comment;

        [Display(Name = "Länk")]
        public string Link;

    }
}