using Campgrounds.Domain.Models.Locations;

///
namespace Campgrounds.Domain.Abstracts.Land
{
  ///
  public abstract class ALocation : AnEntity
  {
    public string Name {get; set;}
    public Address Address {get; set;}

  }// /cla 'ALocation'
}// /ns '..Abstracts.Land'
// [EoF]