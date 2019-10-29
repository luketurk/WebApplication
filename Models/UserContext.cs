﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPPLICATION.Models
{
    public class UserContext : DbContext 
    {


        public DbSet<User> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {

        }
        
    }
}