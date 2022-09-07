

using Product.Api.Data;

namespace Product.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly DbContextClass _dbContext;

        public ProductService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.Product> GetProductList()
        {
            return _dbContext.Products.ToList();
        }
        public Models.Product GetProductById(int id)
        {
            return _dbContext.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public Models.Product AddProduct(Models.Product product)
        {
            var result = _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Models.Product UpdateProduct(Models.Product product)
        {
            var result = _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return result.Entity;
        }
        public bool DeleteProduct(int Id)
        {
            var filteredData = _dbContext.Products.Where(x => x.Id == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
}
