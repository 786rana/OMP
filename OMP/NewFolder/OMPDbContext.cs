namespace OMP.NewFolder
{
    public class OMPDbContext:DbContext
    {
        public OMPDbContext(DbContextOptions<OMPDbContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Services> services { get; set; }
        public DbSet<User> Users {  get; set; }


    }
}
