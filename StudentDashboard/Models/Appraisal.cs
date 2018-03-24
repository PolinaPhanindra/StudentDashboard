using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Appraisal
    {
        [Editable(false)]
        [Required]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Enter appraiser name !!")]
        [Display(Name ="Appraiser Name")]
        public string Appraiser { get; set; }
        [Display(Name ="Appraisee Name")]
        [RegularExpression(@"^\d")]
        public string Appraisee { get; set; }
        [Range(1,5)]
        public int? Rating { get; set; }
        public bool Applicable { get; set; }
    }
}