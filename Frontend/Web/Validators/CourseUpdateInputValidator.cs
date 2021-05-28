using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Catalogs;

namespace Web.Validators
{
    public class CourseUpdateInputValidator : AbstractValidator<CourseUpdateInput>
    {
        public CourseUpdateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("username cannot be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("description cannot be empty");
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue).WithMessage("time cannot be empty");

            RuleFor(x => x.Price).NotEmpty().WithMessage("price cannot be empty").ScalePrecision(2, 6).WithMessage("incorrect price format");
        }
    }
}
