namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TDModel : DbContext
    {
        public TDModel()
            : base("name=TDModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<TodoTask> TodoTasks { get; set; }
        public virtual DbSet<UserActivity> UserActivities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.TodoTasks)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Priority>()
                .HasMany(e => e.TodoTasks)
                .WithRequired(e => e.Priority)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<State>()
                .Property(e => e.StateName)
                .IsFixedLength();

            modelBuilder.Entity<State>()
                .HasMany(e => e.TodoTasks)
                .WithRequired(e => e.State)
                .WillCascadeOnDelete(false);
        }
    }
}
