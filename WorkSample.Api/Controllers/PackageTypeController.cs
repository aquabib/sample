using System.Web.Http;
using WorkSample.Api.Models;
using WorkSample.Domain.Entities;
using WorkSample.Domain.Services;

namespace WorkSample.Api.Controllers
{
	public class PackageTypeController : ApiController
    {
		private IPackageTypeAdvisorService _packageTypeAdvisorService;

		public PackageTypeController(IPackageTypeAdvisorService packageTypeAdvisorService)
		{
			_packageTypeAdvisorService = packageTypeAdvisorService;
		}

		public IHttpActionResult Get(int lengthInMm, int breadthInMm, int heightinMm, int weight)
		{
			if (lengthInMm < 1 || breadthInMm < 1 || heightinMm < 1)
				return BadRequest("Package dimensions must be greater than 1 mm");
			if (weight < 0)
				return BadRequest("Weight must be greater than 0 kg");

			var criteria = new PackageTypeAdvisorCriteria(lengthInMm, breadthInMm, heightinMm, weight);

			BasePackageType packageType = _packageTypeAdvisorService.AdvisePackageType(criteria);

			if (packageType == null)
				return Ok("This package size doesn't fit our current package offerings");

			return Ok(new GetPackageTypeModel
			{
				Id = packageType.Id,
				Name = packageType.Name,
				Cost = packageType.Cost
			});
		}
    }
}
