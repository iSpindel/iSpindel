using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace iSpindel.Database {
    public class BeerCharacteristics {
        public int Id {get; set;}

        [ForeignKey("DataSeriesId")]
        public virtual DataSeries DataSeries { get; set; }
        public int DataSeriesId {get; set;}
        public double? EVG { get; set; }
        public int? Bitterness { get; set; }
        public double? ColorScale { get; set; }
        public double? BrewhouseEfficency { get; set; }
        public double? AmountOfWort { get; set; }
        public double? TargetCarbonation { get; set; }
        public double? AddedSugar { get; set; }
        public double? AdjustedAlcoholLevel { get; set; }
        #nullable enable
        public string? YeastType { get; set; }
        public string? Notes {get; set;}
        public string? BeerStyle {get; set;}
        #nullable restore

    }
}