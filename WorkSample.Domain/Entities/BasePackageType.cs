namespace WorkSample.Domain.Entities
{
	public abstract class BasePackageType : BaseEntity
    {
		protected int _maxLengthInMm;
		protected int _maxBreadthInMm;
		protected int _maxHeightInMm;

		public decimal Cost { get; set; }

		public bool DoesPackageFit(int length, int breadth, int height)
		{
			return (length <= _maxLengthInMm && breadth <= _maxBreadthInMm && height <= _maxHeightInMm);
		}
	}
}
