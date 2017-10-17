using System;
using System.Collections.Generic;
using WorkSample.Domain.Entities;
using WorkSample.Domain.Services;

namespace WorkSample.Services
{
	public class PackageTypeAdvisorService : IPackageTypeAdvisorService
	{
		private readonly IEnumerable<BasePackageType> _packageTypes;

		public PackageTypeAdvisorService(IEnumerable<BasePackageType> packageTypes)
		{
			_packageTypes = packageTypes;
		}

		public BasePackageType AdvisePackageType(PackageTypeAdvisorCriteria criteria)
		{
			if (criteria == null)
				throw new ArgumentNullException(nameof(criteria));

			foreach (BasePackageType packageType in _packageTypes)
			{
				if (packageType.DoesPackageFit(criteria.LengthInMm, criteria.BreadthInMm, criteria.HeightInMm))
					return packageType;
			}

			return null;
		}
	}
}
