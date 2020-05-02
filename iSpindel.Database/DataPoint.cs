using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSpindel.Database
{
    public class DataPoint
    {
        [Key]
        public int Id { get; set; }
        public int? DataSeriesId { get; set; }

        [ForeignKey("DataSeriesId")]
        public virtual DataSeries DataSeries { get; set; }
        public double Temperature { get; set; }
        public double Battery { get; set; }
        public double Gravity { get; set; }
        [Column(TypeName="DateTime2")]
        public DateTime RecordTime { get; set; }
    }
}
