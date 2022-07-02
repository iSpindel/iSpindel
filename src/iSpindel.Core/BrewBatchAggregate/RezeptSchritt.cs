using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSpindel.SharedKernel;

namespace iSpindel.Core.BrewBatchAggregate;
public class RezeptSchritt : ValueObject
{
  public string RezeptName { get; set; }
  public string RezeptDescription { get; set; }
  public string BierStil { get; set; }
}
