using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TokenAPI.Models;

namespace TokenAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfiMapper();
        }

        private void ConfiMapper()
        {
            //PM > Install - Package AutoMapper
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<UserIdentity, UserDTO>();
                cfg.CreateMap<Project, ProjectDTO>()
                    .ForMember(dest => dest.PM, opt => opt.MapFrom(src => $"{src.PM.FirstName} {src.PM.LastName}"))
                    .ForMember(dest => dest.PO, opt => opt.MapFrom(src => $"{src.PO.FirstName} {src.PO.LastName}"))
                    .ForMember(dest => dest.Members, opt => opt.MapFrom(src => src.Members.Select(member => member.FirstName)));
            });
        }
    }
}
