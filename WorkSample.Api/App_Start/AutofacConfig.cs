using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using WorkSample.Domain.Setup;
using WorkSample.Services.Setup;

namespace WorkSample.Api.App_Start
{
	public static class AutofacConfig
	{
		public static void Register(HttpConfiguration config)
		{
			var builder = new ContainerBuilder();

			// Register your Web API controllers.
			builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

			// Register other modules
			builder.RegisterModule<DomainModule>();
			builder.RegisterModule<ServicesModule>();

			// Set the dependency resolver to be Autofac.
			IContainer container = builder.Build();
			config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
		}
	}
}