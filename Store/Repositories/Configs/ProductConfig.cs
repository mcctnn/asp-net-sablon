using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p=>p.ProductId); //PK
            builder.Property(p=>p.ProductName).IsRequired();
            builder.Property(p=>p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1,CategoryId=2,ImageUrl="/images/1.jpeg", ProductName = "Computer", Price = 17_002, ShowCase=false },
                new Product() { ProductId = 2,CategoryId=2,ImageUrl="/images/2.jpeg", ProductName = "Keyboard", Price = 502, ShowCase=false },
                new Product() { ProductId = 3,CategoryId=2,ImageUrl="/images/3.jpeg", ProductName = "Mouse", Price = 1_002, ShowCase=false },
                new Product() { ProductId = 4,CategoryId=2,ImageUrl="/images/4.jpeg", ProductName = "Monitor", Price = 7_002, ShowCase=false },
                new Product() { ProductId = 5,CategoryId=2,ImageUrl="/images/5.jpeg", ProductName= "Deck", Price = 12_002, ShowCase=false },
                new Product() { ProductId = 6,CategoryId=1,ImageUrl="/images/6.jpeg", ProductName= "History", Price = 250, ShowCase=false },
                new Product() { ProductId = 7,CategoryId=1,ImageUrl="/images/7.jpeg", ProductName= "NUTUK", Price = 500, ShowCase=false },
                new Product() { ProductId = 8,CategoryId=1,ImageUrl="/images/8.jpeg", ProductName= "Algorithm", Price = 570, ShowCase=true },
                new Product() { ProductId = 9,CategoryId=1,ImageUrl="/images/9.jpeg", ProductName= "Data Structers", Price = 500, ShowCase=true },
                new Product() { ProductId = 10,CategoryId=1,ImageUrl="/images/10.jpeg", ProductName= "HeadPhone", Price = 5500, ShowCase=true }
            );
        }
    }
}