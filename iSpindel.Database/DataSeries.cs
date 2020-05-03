﻿using System;
using System.Linq;
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
		public DateTime? Start { get => DataPoints?.Min<DataPoint, DateTime?>(x => x.RecordTime); }
		public DateTime? End { get => DataPoints?.Max<DataPoint, DateTime?>(x => x.RecordTime); }
	}
}
