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
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Namnet Måste vara mellan 3 och 50 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9\s]*$", ErrorMessage = "Namnet kan inte ha speciella tecken")]
        [Display(Name = "Ikt Namn")]
        public string Name;

        [Required(ErrorMessage = "Beskrivningen är blank")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "Beskrivningen Måste vara mellan 10 och 250 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[,.a-zåäöA-ZÅÄÖ0-9'-'---\s]*$", ErrorMessage = "Beskrivningen kan inte innehålla speciela bokstäver")]
        [Display(Name = "Ikt Beskrivning")]
        public string Description;

        [Required(ErrorMessage = "Tips är blankt")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "Beskrivningen Måste vara mellan 10 och 250 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[,.a-zåäöA-ZÅÄÖ0-9'-'---\s]*$", ErrorMessage = "Beskrivningen kan inte innehålla speciela bokstäver")]
        [Display(Name = "Ikt Tips")]
        public string Tips;

        [Display(Name = "Länk")]
        public string Link;

    }
}