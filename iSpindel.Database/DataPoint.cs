using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace iSpindel.Database
{
    public class DataPoint
    {
        [Key]
        public int Id { get; set; }
        [JsonIgnore]
        public int? DataSeriesId { get; set; }

        [ForeignKey("DataSeriesId"), JsonIgnore]
        public virtual DataSeries DataSeries { get; set; }
        public double Temperature { get; set; }
        public double Battery { get; set; }
        public double Gravity { get; set; }
        public DateTime RecordTime { get; set; }
    }
}
