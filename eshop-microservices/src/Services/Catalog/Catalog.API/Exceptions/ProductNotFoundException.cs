namespace Catalog.API.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        private const string ProductNotFoundMessage = "Product not found!";
        public ProductNotFoundException() : base(ProductNotFoundMessage)
        {  
        }
    }
}
