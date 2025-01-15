using MI.Eccad.Models.DTO.DominicalSchool;
using MI.Eccad.Models.DTO.Orders;
using MI.Eccad.Models.DTO.Products;
using Microsoft.EntityFrameworkCore;

namespace MI.Eccad.Core.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    // orders
    public DbSet<Client> Clients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Shipment> Shipment { get; set; }

    // products
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<DominicalSchoolProduct> DominicalSchoolProducts { get; set; }
    public DbSet<Generation> Generations { get; set; }
    public DbSet<Semester> Semesters { get; set; }
}
