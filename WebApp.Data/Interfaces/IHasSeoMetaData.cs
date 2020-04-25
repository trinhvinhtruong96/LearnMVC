namespace WebApp.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
         string SeoPageTitle {get;set;}
         string SeoAlias {get; set;}
         string SeoKeywords {get; set;}
         string SeoDescription {get; set;}
    }
}