using AutoMapper;
using GeekShoppingProduct.Data.ValueObjects;
using GeekShoppingProduct.Model;
using GeekShoppingProduct.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShoppingProduct.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _sqlContext;
        private IMapper _mapper;

        public ProductRepository(MySQLContext sqlContext, IMapper mapper)
        {
            _sqlContext = sqlContext;
            _mapper = mapper;

        }
        public async Task<IEnumerable<ProductDto>> FindAll()
        {
            List<Product> products = await  _sqlContext.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(products);
        }
        public async Task<ProductDto> FindById(long id)
        {
            Product product = await _sqlContext.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);
        }
        public async Task<ProductDto> Create(ProductDto dto)
        {
            Product product = _mapper.Map<Product>(dto);
            _sqlContext.Products.Add(product);
            await _sqlContext.SaveChangesAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> Update(ProductDto dto)
        {
            Product product = _mapper.Map<Product>(dto);
            _sqlContext.Products.Update(product);
            await _sqlContext.SaveChangesAsync();
            return _mapper.Map<ProductDto>(product);
        }
        public async Task<bool> Delete(long id)
        {
            try
            {
                Product product = await _sqlContext.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (product != null) return false;
                _sqlContext.Products.Remove(product);
                await _sqlContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



    }
}
