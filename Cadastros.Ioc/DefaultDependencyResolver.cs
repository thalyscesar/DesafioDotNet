using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http.Dependencies;

namespace Cadastros.Ioc
{
    public class DefaultDependencyResolver : IDependencyResolver, IDisposable
    {
        protected IServiceProvider serviceProvider;

        public DefaultDependencyResolver(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IDependencyScope BeginScope()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public object GetService(Type serviceType)
        {
            if (HttpContext.Current?.Items[typeof(IServiceScope)] is IServiceScope scope)
            {
                return scope.ServiceProvider.GetService(serviceType);
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (HttpContext.Current?.Items[typeof(IServiceScope)] is IServiceScope scope)
            {
                return scope.ServiceProvider.GetServices(serviceType);
            }

            return null;
        }
    }
}
