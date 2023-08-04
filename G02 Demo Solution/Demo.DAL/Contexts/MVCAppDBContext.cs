﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.DAL.Contexts
{
	public class MVCAppDBContext:DbContext
	{
        public MVCAppDBContext(DbContextOptions<MVCAppDBContext> options):base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
      	//optionsBuilder.UseSqlServer("Server=.;Database=MVCG02DB;Trusted_Connection = true;");
		public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
	}
}
