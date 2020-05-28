using System;
using System.Collections.Generic;

namespace iSpindel.App.DTO
{
    public class DataSeriesWithDataPointsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public IEnumerable<DataPointDTO> Datapoints { get; set; }
    }
}
