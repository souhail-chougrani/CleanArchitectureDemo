﻿using CleanArch.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
   public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions options ):base(options)
        {

        }
        DbSet<Course> courses { get; set; } 
    }
}
