using Cadastros.Domain.Interfaces;
using Cadastros.Domain.Services;
using Cadastros.Infra.Conexao;
using Cadastros.Infra.Data.Repositories;
using CadastrosProdutos.Interfaces;
using CadastrosProdutos.Services;
using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace Cadastros.Ioc
{
    public static class InjectorBootStrapper
    {
        public static void AddConfigurationsContainer(this HttpConfiguration config)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new ExecutionContextScopeLifestyle();

            AddServices(container);
            AddRepositories(container);
            AddAcessoADados(container);

            container.Verify();

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }


        private static void AddServices(Container container)
        {
            container.Register<IProductService, ProductService>(Lifestyle.Scoped);
            container.Register<IProductAppService, ProductAppService>(Lifestyle.Scoped);
        }

        private static void AddRepositories(Container container)
        {
            container.Register<IProductRepository, ProductRepository>(Lifestyle.Scoped);
        }

        private static void AddAcessoADados(Container container)
        {
            container.Register<IAcessoADados, AcessoADados>(Lifestyle.Scoped);
        }
    }
}
