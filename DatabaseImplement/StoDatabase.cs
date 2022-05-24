using DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement
{
    public class StoDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StoDatabase3;Trusted_Connection=True");
            }
            base.OnConfiguring(optionsBuilder);

        }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<Payment> Payments { set; get; }
        public virtual DbSet<Repair> Repairs { set; get; }
        public virtual DbSet<Staff> Staffs { set; get; }
        public virtual DbSet<Work> Works { set; get; }
    }
}
