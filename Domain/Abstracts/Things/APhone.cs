// [I.] HEAD
//  A] Libraries

using Campgrounds.Domain.Abstracts.Things;
using Campgrounds.Domain.Models.People.Owners;
using Campgrounds.Domain.Models.Contact;

/// phone devices
namespace Campgrounds.Domain.Abstracts.Things
{
  ///
  public abstract class APhone : ADevice
  {
    //  B] Properties

    public PhoneNumber PhoneNumber {get; protected set;}


    // [III]. FOOT
    public override string ToString()
    {
      return base.ToString()+'\n'+PhoneNumber.ToString();
    }


  }// /cla 'Phone'
}// /ns '..Phones'
 // [EoF]