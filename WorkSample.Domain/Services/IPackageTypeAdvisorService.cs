using WorkSample.Domain.Entities;

namespace WorkSample.Domain.Services
{
	public interface IPackageTypeAdvisorService
    {
		BasePackageType AdvisePackageType(PackageTypeAdvisorCriteria criteria);
	}
}
