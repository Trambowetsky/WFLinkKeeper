namespace WFShortcutKeeper
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WFShortcutKeeper.Entities;

    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("name=EfDbConnection")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Shortcut> Shortcuts { get; set; }
    }

}