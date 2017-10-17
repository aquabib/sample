using FluentAssertions;
using System;
using System.Collections.Generic;
using WorkSample.Domain.Entities;
using WorkSample.Services;
using Xunit;

namespace WorkSample.UnitTests.PackageTypeAdvisor
{
	public class PackageTypeAdvisorServiceTest
	{
		private IEnumerable<BasePackageType> _packageTypes;

		public PackageTypeAdvisorServiceTest()
		{
			_packageTypes = new List<BasePackageType>
			{
				new SmallPackageType(),
				new MediumPackageType(),
				new LargePackageType()
			};
		}

		[Fact]
		public void Should_throw_null_exception_when_criteria_is_null()
		{
			var service = new PackageTypeAdvisorService(_packageTypes);
			Action act = () => service.AdvisePackageType(null);
			act.ShouldThrow<ArgumentNullException>();
		}

		[Theory]
		[InlineData(10, 10, 10, typeof(SmallPackageType))]
		[InlineData(210, 280, 130, typeof(SmallPackageType))]
		[InlineData(250, 300, 150, typeof(MediumPackageType))]
		[InlineData(280, 390, 180, typeof(MediumPackageType))]
		[InlineData(300, 400, 190, typeof(LargePackageType))]
		[InlineData(380, 550, 200, typeof(LargePackageType))]
		public void Should_return_correct_package_type(int length, int breadth, int height, Type expectedType)
		{
			var service = new PackageTypeAdvisorService(_packageTypes);
			PackageTypeAdvisorCriteria criteria = new PackageTypeAdvisorCriteria(length, breadth, height, 10);
			BasePackageType packageType = service.AdvisePackageType(criteria);
			packageType.Should().BeOfType(expectedType);
		}
	}
}
