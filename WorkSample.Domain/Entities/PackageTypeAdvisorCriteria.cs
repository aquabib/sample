namespace WorkSample.Domain.Entities
{
	public class PackageTypeAdvisorCriteria
    {
		public int LengthInMm { get; set; }

		public int BreadthInMm { get; set; }

		public int HeightInMm { get; set; }

		public double WeightInKg { get; set; }

		public PackageTypeAdvisorCriteria(int length, int breadth, int height, double weight)
		{
			LengthInMm = length;
			BreadthInMm = breadth;
			HeightInMm = height;
			WeightInKg = weight;
		}
	}
}
