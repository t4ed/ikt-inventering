using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    [MetadataType(typeof(SubjectMetaData))]
    public partial class Subject { }

    public class SubjectMetaData
    {
        [Required(ErrorMessage = "Namnet är blankt")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Namnet Måste vara mellan 3 och 25 bokstäver")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9\s]*$", ErrorMessage = "Produkten kan inte ha speciella tecken")]
        [Display(Name = "Subject Name")]
        public string Name;
    }
}