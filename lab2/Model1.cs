namespace lab2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Students>()
                .Property(e => e.Gruppa)
                .IsFixedLength();

            modelBuilder.Entity<Students>()
                .Property(e => e.Vozrast)
                .IsFixedLength();
        }
    }
}
