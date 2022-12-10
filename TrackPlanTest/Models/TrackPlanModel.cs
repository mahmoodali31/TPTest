using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrackPlanTest.Models
{
    public class TrackPlanModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}