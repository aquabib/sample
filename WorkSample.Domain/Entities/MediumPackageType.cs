namespace WorkSample.Domain.Entities
{
	public class MediumPackageType : BasePackageType
    {
		public MediumPackageType()
		{
			_maxLengthInMm = 280;
			_maxBreadthInMm = 390;
			_maxHeightInMm = 180;

			Id = 2;
			Name = "Medium Package";
			Cost = 7.5M;
		}
	}
}
