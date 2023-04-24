using GeekShoppingProduct.Data.ValueObjects;

namespace GeekShoppingProduct.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> FindAll();
        Task<ProductDto> FindById(long id);
        Task<ProductDto> Create(ProductDto dto);
        Task<ProductDto> Update(ProductDto dto);
        Task<bool> Delete(long id);
    }
}
