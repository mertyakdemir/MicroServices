using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Catalogs
{
    public class CourseCreateInput
    {
        [Display(Name = "Course Name")]
        public string Name { get; set; }

        [Display(Name = "Course Description")]
        public string Description { get; set; }

        [Display(Name = "Course Price")]
        public decimal Price { get; set; }

        public string Picture { get; set; }

        public string UserId { get; set; }

        public FeatureViewModel Feature { get; set; }

        [Display(Name = "Course Category")]
        public string CategoryId { get; set; }

        [Display(Name = "Course Image")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
