namespace Notes {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NotesEntities : DbContext {
        public NotesEntities()
            : base("name=NotesEntities") {
        }

        public virtual DbSet<Notes> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Notes>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Notes>()
                .Property(e => e.text)
                .IsUnicode(false);
        }
    }
}
