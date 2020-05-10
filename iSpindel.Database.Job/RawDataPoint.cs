using System;

namespace iSpindel.Database.Job

{

    public class RawDataPoint
    {
        public double? Temperature { get; set; }
        public double? Battery { get; set; }
        public double? Gravity { get; set; }
        public DateTime FirstRecordTime { get; set; }
        public DateTime LastRecordTime { get; set; }

        public RawDataPoint()
        {
            FirstRecordTime = DateTime.Now;
        }
    }

}