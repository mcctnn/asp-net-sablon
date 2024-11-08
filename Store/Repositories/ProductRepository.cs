using Entities.Models;
using Entities.RequestParameters;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.Extensions;

namespace Repositories
{
    public sealed class ProductRepository : RepositoryBase<Product>, IProductRepository //sealed sınıflar bir daha kalıtım yapılamaz
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneProduct(Product product)=>Create(product);

        public void DeleteOneProduct(Product product)=>Delete(product);

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

        public IQueryable<Product> GetAllProductsWithDetails(ProductRequestParameters productRequest)
        {
            return _context
                        .Products
                        .FilteredByCategoryId(productRequest.CategoryId)
                        .FilteredBySearchTerm(productRequest.SearchTerm)
                        .FilteredByPrice(productRequest.MinPrice,productRequest.MaxPrice,productRequest.IsValidPrice)
                        .ToPaginate(productRequest.PageNumber,productRequest.PageSize);
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FindByCondition(p=>p.ProductId.Equals(id),trackChanges);
        }

        public IQueryable<Product> GetShowcaseProducts(bool trackChanges)
        {
            return FindAll(trackChanges)
                .Where(p=>p.ShowCase.Equals(true));
        }

        public void UpdateOneProduct(Product entity)=>Update(entity);
    }
}