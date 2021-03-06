﻿using Microsoft.EntityFrameworkCore;
using Store.Core.EntityLayer.Sales;

namespace Store.Core.DataLayer.Mapping.Sales
{
    public class CustomerMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Customer>();

            entity.ToTable("Customer", "Sales");

            entity.HasKey(p => p.CustomerID);

            entity.Property(p => p.CustomerID).UseSqlServerIdentityColumn();
        }
    }
}
