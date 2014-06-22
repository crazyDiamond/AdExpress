using System.Runtime.CompilerServices;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AdExpress.AdExpressWcfService;
using AdExpress.Models;
using AutoMapper;

namespace AdExpress
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperMvcConfiguration.Configure();
        }
    }

    public static class AutoMapperMvcConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Ad, AdViewModel>();
            Mapper.CreateMap<AdViewModel, Ad>();
            Mapper.CreateMap<Newspaper, NewspaperViewModel>();
            Mapper.CreateMap<NewspaperViewModel, Newspaper>();
            Mapper.CreateMap<Association, AssociationViewModel>()
                .ForMember(x => x.AdTitle, opt => opt.MapFrom(src => src.Ad.Title))
                .ForMember(x=>x.NewspaperName, opt => opt.MapFrom(src => src.Newspaper.Name))
                .ForMember(x => x.ID, opt => opt.MapFrom(src => src.ID));
            Mapper.CreateMap<AssociationViewModel, Association>(); /*
                .ForMember(x => x.Ad.Title, opt => opt.MapFrom(src => src.AdTitle))
                .ForMember(x => x.Newspaper.Name, opt => opt.MapFrom(src => src.NewspaperName))
                .ForMember(x => x.ID, opt => opt.MapFrom(src => src.ID));*/

        }
    }
}
