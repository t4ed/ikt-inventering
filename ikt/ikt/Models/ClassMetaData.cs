using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ikt.Models
{
    [MetadataType(typeof(ClassMetaData))]
    public partial class Class{ }

    public partial class ClassMetaData
    {
        [Required(ErrorMessage = "Klassnamnet kan inte vara tomt.")]
        [StringLength(14, MinimumLength = 2, ErrorMessage = "Klassnamnet måste vara mellan 2 och 14 tecken.")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9:]*$", ErrorMessage = "Klassnamnet får bara bestå bokstäver och siffror.")]
        [Display(Name = "Klass")]
        public string Name;
    }
}