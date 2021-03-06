using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ImagesValidator : AbstractValidator<Images>
    {
        public ImagesValidator()
        {
            RuleFor(c => c.FilmId).NotNull();
        }
    }
}
