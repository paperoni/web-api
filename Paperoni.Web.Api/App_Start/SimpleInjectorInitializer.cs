//[assembly: WebActivator.PostApplicationStartMethod(typeof(Paperoni.Web.Api.App_Start.SimpleInjectorInitializer), "Initialize")]

using System.Reflection;
using System.Web.Mvc;

using SimpleInjector;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using Paperoni.Data.Common;
using Paperoni.Data.Access;
using Paperoni.Services.Interfaces;
using Paperoni.Services;

namespace Paperoni.Web.Api
{
    public static class SimpleInjectorConfig
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            SetupDataContext(container);
            SetupServices(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void SetupDataContext(Container container)
        {
            container.Register<ILibraryContext, LibraryContext>(Lifestyle.Singleton);
            container.Register<IBookRepository, BookRepository>(Lifestyle.Scoped);
            container.Register<IAuthorRepository, AuthorRepository>(Lifestyle.Scoped);
            container.Register<IBookAuthorRepository, BookAuthorRepository>(Lifestyle.Scoped);
        }

        private static void SetupServices(Container container)
        {
            container.Register<IBookManager, BookManager>(Lifestyle.Scoped);
        }
    }
}