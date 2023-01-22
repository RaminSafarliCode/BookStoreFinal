﻿using BookStore.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models.DataContexts.Configurations
{
    public class FaqEntityTypeConfiguration : IEntityTypeConfiguration<Faq>
    {
        public void Configure(EntityTypeBuilder<Faq> builder)
        {
            builder.HasKey(entity => entity.Id);

            builder.Property(entity => entity.Id)
                .UseIdentityColumn();

            builder.Property(entity => entity.Question)
                .IsRequired();

            builder.Property(entity => entity.Answer)
                .IsRequired();
        }
    }
}
