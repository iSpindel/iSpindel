namespace iSpindel.App.DTO {
    public class BeerCharacteristicsDTO {
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