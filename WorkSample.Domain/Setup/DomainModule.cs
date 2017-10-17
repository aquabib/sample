using Autofac;
using WorkSample.Domain.Entities;

namespace WorkSample.Domain.Setup
{
	public class DomainModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			base.Load(builder);

			builder.RegisterType<SmallPackageType>().As<BasePackageType>().InstancePerDependency();
			builder.RegisterType<MediumPackageType>().As<BasePackageType>().InstancePerDependency();
			builder.RegisterType<LargePackageType>().As<BasePackageType>().InstancePerDependency();
		}
	}
}
