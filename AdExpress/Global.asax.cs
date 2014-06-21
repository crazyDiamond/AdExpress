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
            Mapper.CreateMap<Association, AssociationViewModel>();
            Mapper.CreateMap<AssociationViewModel, Association>();

        }
    }
}
