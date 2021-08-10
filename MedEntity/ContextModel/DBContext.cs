using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MedEntity.ContextModel
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Medicine> Medicine { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.MedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MedcineId)
                    .HasColumnName("MedcineID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
