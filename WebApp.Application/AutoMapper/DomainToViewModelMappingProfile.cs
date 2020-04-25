using AutoMapper;
using WebApp.Application.ViewModels;
using WebApp.Data.Entities;

namespace WebApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}