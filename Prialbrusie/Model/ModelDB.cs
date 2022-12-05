using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Prialbrusie.Model
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UslugaZakaz> UslugaZakaz { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Zakaz)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.id_client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.id_role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.UslugaZakaz)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.id_usluga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Zakaz)
                .WithRequired(e => e.Status)
                .HasForeignKey(e => e.id_status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zakaz>()
                .HasMany(e => e.UslugaZakaz)
                .WithRequired(e => e.Zakaz)
                .HasForeignKey(e => e.id_zakaz)
                .WillCascadeOnDelete(false);
        }
    }
}
