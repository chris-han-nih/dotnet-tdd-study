namespace Orders;

using Microsoft.EntityFrameworkCore;

public sealed class OrdersDbContext: DbContext
{
    public OrdersDbContext(DbContextOptions<OrdersDbContext> options): base(options)
    {
    }
    
    public DbSet<Order> Orders { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var order = modelBuilder.Entity<Order>();
        order.HasKey(o => o.Sequence);
        order.Property(x=>x.Sequence).ValueGeneratedOnAdd();
        order.HasIndex(o => o.Id).IsUnique();
        order.HasIndex(o => o.UserId);
        // order.HasIndex(o => new { o.UserId, o.ShopId });
        order.HasIndex(o => o.ShopId);
        order.Property(o => o.Status).HasConversion<string>();
        order.HasIndex(o => o.Status);
    }
}