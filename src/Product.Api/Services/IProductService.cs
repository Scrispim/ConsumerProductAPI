namespace Product.Api.Services
{
    public interface IProductService
    {
        public IEnumerable<Models.Product> GetProductList();
        public Models.Product GetProductById(int id);
        public Models.Product AddProduct(Models.Product product);
        public Models.Product UpdateProduct(Models.Product product);
        public bool DeleteProduct(int Id);
    }
}
