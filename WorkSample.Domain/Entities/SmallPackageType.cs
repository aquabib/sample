namespace WorkSample.Domain.Entities
{
	public class SmallPackageType : BasePackageType
	{
		public SmallPackageType()
		{
			_maxLengthInMm = 210;
			_maxBreadthInMm = 280;
			_maxHeightInMm = 130;

			Id = 1;
			Name = "Small Package";
			Cost = 5;
		}
	}
}
