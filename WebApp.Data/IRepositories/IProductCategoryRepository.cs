using System.Collections.Generic;
using WebApp.Data.Entities;
using WebApp.Infrastructure.Interfaces;

namespace WebApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> getByAlias(string alias);
    }
}