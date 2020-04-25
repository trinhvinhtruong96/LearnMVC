using System.Collections.Generic;
using System.Linq;
using WebApp.Data.Entities;
using WebApp.Data.IRepositories;

namespace WebApp.Data.EF.Repositories
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        private AppDbContext _context;
        public ProductCategoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<ProductCategory> getByAlias(string alias)
        {
            return _context.ProductCategories.Where(c => c.SeoAlias == alias).ToList();
        }
    }
}