﻿using BookStore.Domain.Models.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Validators.BlogPostValidators
{
    public class BlogPostCategoryValidator : AbstractValidator<BlogPostCategory>
    {
        public BlogPostCategoryValidator()
        {
            RuleFor(entity => entity.Name)
                .NotEmpty()
                .WithMessage("This field is required to be filled in!");
        }
    }
}
