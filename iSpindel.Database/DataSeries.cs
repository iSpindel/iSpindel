using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSpindel.Database
{
    public class DataSeries
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [InverseProperty("DataSeries")]
        public virtual ICollection<DataPoint> DataPoints { get; set; }
        public int? BeerCharacteristicsId { get; set; }
        [ForeignKey("BeerCharacteristicsId")]
        public virtual BeerCharacteristics BeerCharacteristics { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
