using NHibernateDemo.BLL.Services;
using NHibernateDemo.Core.Services;
using NHibernateDemo.DAL.Repositories;
using NHibernateDemo.Domain.Repositories;
using Ninject;

using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace NHibernateDemo.IoC
{
    public class NinjectConfig
    {
        private static IKernel _ninjectKernel;
        public class NinjectDependencyResolver : DefaultControllerFactory
        {
            public NinjectDependencyResolver()
            {
                _ninjectKernel = new StandardKernel();
                ConfigurDepndency();
            }
            protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
            {
                return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
            }
        }
        private static void ConfigurDepndency()
        {
            _ninjectKernel.Bind<IProductRepository>().To<ProductRepository>();
            _ninjectKernel.Bind<IProductService>().To<ProductService>();
        }
    }
}