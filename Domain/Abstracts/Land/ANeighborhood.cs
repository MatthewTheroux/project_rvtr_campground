using System.Collections.Generic;

/// blueprints for land spaces
namespace Campgrounds.Domain.Abstracts.Land
{
  /// a group of land properties
  public abstract class ANeighborhood
  {
    public List<ALandProperty> Grouping {get; protected set;}


  }// /cla 'ANeighborhood'
}// /ns '..Abstracts.Things.Land'
// [EoF]