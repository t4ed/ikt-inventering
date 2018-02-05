using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    [MetadataType(typeof(IktPersonalMetaData))]
    public partial class IktPersonal { }

    public partial class IktPersonalMetaData
    {
        [Required(ErrorMessage = "Kan inte vara blankt")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Måste Innehålla 5 tecken")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ]+[a-zåäöA-ZÅÄÖ]*$", ErrorMessage = "Kan inte innehålla speciella tecken")]
        [Display(Name = "Ikt Personal")]
        public string Personal;
    }
}