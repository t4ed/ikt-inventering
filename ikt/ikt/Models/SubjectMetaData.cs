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
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Namnet Måste vara mellan 3 och 100 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9\s---]*$", ErrorMessage = "Namnet kan inte ha speciella tecken")]
        [Display(Name = "Ämne")]
        public string Name;
    }
}