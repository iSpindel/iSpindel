using System;

namespace iSpindel.App.DTO
{
	public class DataPointDTO
	{
        public int Id { get; set; }
		public double Battery { get; set;}
        public double Gravity { get; set;}
        public double Temperature { get; set;}
        public DateTime RecordTime { get; set; }
    }
}
