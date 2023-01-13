using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace infrastucture.context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions option) : base(option) { } 

        protected override void OnModelCreating (ModelBuilder modelBuilder) {

            modelBuilder.Entity<Domain.domain.Property>()
                .Property(it => it.id); 

            modelBuilder.Entity<Room>()
                .Property(it => it.id);       
            
            modelBuilder.Entity<TypeProperty>()
                .Property(it => it.id);             
            
            modelBuilder.Entity<TypeRoom>()
                .Property(it => it.id);    
        }
        public DbSet<Domain.domain.Property> property { get; set; }
        public DbSet<Room> room { get; set; }
        public DbSet<TypeProperty> typeProperty { get; set; }
        public DbSet<TypeRoom> typeRoom { get; set; }
      
    }
}
