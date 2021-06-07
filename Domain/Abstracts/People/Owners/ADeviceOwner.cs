// [I]. HEAD
//  A] Libraries
using Campgrounds.Domain.Abstracts.Things;

///
namespace Campgrounds.Domain.Abstracts.People.Owners
{
  public abstract class ADeviceOwner : AnOwner
  {
    //  B] Properties
    public ADevice DeviceOwned { get; set; }

  }// /cla 'ADeviceOwner'
}// /ns '..Models.People'
 //[EoF]