using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ikt.Models
{
    public partial class Project { }
    public partial class ProjectMetaData
    {
        [Required(ErrorMessage = "Namnet på projektet kan inte vara tomt.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Namnet måste vara mellan 3 och 50 tecken långt.")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9'-'---\s]*$", ErrorMessage = "Namnet får inte innehålla några specialtecken.")]
        [Display(Name = "Projektnamn")]
        public string Name;

        [Required(ErrorMessage = "Årskursen kan inte vara tom.")]
        [Range(1, 4, ErrorMessage = "Årskursen måste vara mellan 1-4")]
        [Display(Name = "Årskurs")]
        public int Grade;

        [Required(ErrorMessage = "Beskrivningen av projektet kan inte vara tom.")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Namnet måste vara mellan 3 och 250 tecken långt.")]
        [RegularExpression(@"^[a-zåäöA-ZÅÄÖ0-9]+[a-zåäöA-ZÅÄÖ0-9'-'---\s(-).,;:]*$", ErrorMessage = "Beskrivningen får inte innehålla några specialtecken.")]
        [Display(Name = "Beskrivning")]
        public string Description;

        [Required(ErrorMessage = "Datumet kan inte vara tomt.")]
        [RegularExpression(@"^[0-9]+[0-9---\s]*$", ErrorMessage = "Datumet ska skrivas i format DD-MM-ÅÅÅÅ.")]
        [Display(Name = "Datum för utförande")]
        public string Date;
    }
}