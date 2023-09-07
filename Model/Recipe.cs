using Microsoft.EntityFrameworkCore;

public class RecipeDbContext : DbContext
{
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<UsageDate> UsageDates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the database connection string
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MypersonlRecipeBook");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure entity relationships and constraints here (e.g., foreign keys).
    }
}
