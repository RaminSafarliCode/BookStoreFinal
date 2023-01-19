﻿using BookStore.Domain.Models.Entities;
using BookStore.Domain.Models.Entities.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models.DataContexts
{
    public class BookStoreDbContext : IdentityDbContext<BookStoreUser, BookStoreRole, int, BookStoreUserClaim, BookStoreUserRole, BookStoreUserLogin, BookStoreRoleClaim, BookStoreUserToken>
    {
        public BookStoreDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ContactPost> ContactPosts { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(BookStoreDbContext).Assembly);
        }
    }
}
