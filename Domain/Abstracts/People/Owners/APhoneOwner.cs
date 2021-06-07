using Campgrounds.Domain.Abstracts.Things;

/// 
namespace Campgrounds.Domain.Abstracts.People.Owners
{
  ///
  public class APhoneOwner : ADeviceOwner
  {
    //  B] Properties
    public APhone PhoneOwned { get; set; }

  }// /cla 'APhoneOwner'
}// /ns '..Models.People
 // [EoF]