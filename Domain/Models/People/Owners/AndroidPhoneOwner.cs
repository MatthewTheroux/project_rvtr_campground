// [I]. HEAD
//  A] Libraries
using Campgrounds.Domain.Abstracts.People.Owners;
using Campgrounds.Domain.Models.Things.Devices.Phones;

///
namespace Campgrounds.Domain.Models.People.Owners
{
  ///
  public class AndroidPhoneOwner : APhoneOwner
  {
    //  B]
    public new AndroidPhone PhoneOwned { get; protected set; }

    // [III]. FOOT
    public override string ToString()
    {
      return base.ToString();
    }

  }// /cla 'AndroidPhoneOwner'
}// ns '..Models..Owners'
 // [EoF]