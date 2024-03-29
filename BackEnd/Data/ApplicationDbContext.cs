﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
    {
    public class ApplicationDbContext : DbContext
        {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }

        public DbSet<Speaker> Speakers
            {
            get; set;
            }
        }
    }
