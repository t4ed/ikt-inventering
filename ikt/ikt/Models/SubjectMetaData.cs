using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ikt.Models
{
    [MetadataType(typeof(SubjectMetaData))]
    public partial class Subject { }

    public partial class SubjectMetaData
    {
        [Required(ErrorMessage = "Namnet är blankt")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Namnet Måste vara mellan 3 och 25 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9\s]*$", ErrorMessage = "Produkten kan inte ha speciella tecken")]
        [Display(Name = "Ämne")]
        public string Name;
    }
}