using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iSpindel.Database
{
    public class DataSeries
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<DataPoint> DataPoints { get; set; }
        //public DateTime Start { get => DataPoints; }
        //public DateTime End { get => DataPoints; }
    }
}
