using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Catalogs
{
    public class FeatureViewModel
    {
        [Display(Name = "course time")]
        public int Duration { get; set; }
    }
}
