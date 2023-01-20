
namespace SampleEcommerce.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Telephone directory",
                     Description = "A telephone directory, commonly called a telephone book, telephone address book, phonebook, or the white and yellow pages, is a listing of telephone subscribers in a geographical area or subscribers to services provided by the organization that publishes the directory. Its purpose is to allow the telephone number of a subscriber identified by name and address to be found.",
                     Price = 9.99m,
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Unused_Phonebooks.JPG/330px-Unused_Phonebooks.JPG"
                 },
                  new Product
                  {
                      Id = 2,
                      Title = "Telephone directory",
                      Description = "A telephone directory, commonly called a telephone book, telephone address book, phonebook, or the white and yellow pages, is a listing of telephone subscribers in a geographical area or subscribers to services provided by the organization that publishes the directory. Its purpose is to allow the telephone number of a subscriber identified by name and address to be found.",
                      Price = 9.99m,
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Unused_Phonebooks.JPG/330px-Unused_Phonebooks.JPG"
                  }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
