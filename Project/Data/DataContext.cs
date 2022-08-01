

namespace Project.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer()
                .UseSqlServer("Server=192.168.1.8,1433;Database=project;User Id=newproject;Password=1234;");
        }
         
        public DbSet<User2> Users2 => Set<User2>();
       
    }

}
