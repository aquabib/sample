namespace WorkSample.Domain.Entities
{
	public class LargePackageType : BasePackageType
    {
		public LargePackageType()
		{
			_maxLengthInMm = 380;
			_maxBreadthInMm = 550;
			_maxHeightInMm = 200;

			Id = 3;
			Name = "Large Package";
			Cost = 8.5M;
		}
	}
}
