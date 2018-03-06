using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ikt.Models
{
    public class SearchItem
    {
        public int ItemID { get; set; }
        public string Type { get; set; }
        [Display(Name = "Namn")]
        public string Name { get; set; }
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }
        [Display(Name = "Kommentar")]
        public string Comment { get; set; }
        [Display(Name = "Ämne")]
        public string Subject { get; set; }
        [Display(Name = "Årskurs")]
        public int Grade { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}