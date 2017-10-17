using Autofac;

namespace WorkSample.Services.Setup
{
	public class ServicesModule : Module
    {
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);

			builder.RegisterType<PackageTypeAdvisorService>().AsImplementedInterfaces().InstancePerDependency();
		}
	}
}
