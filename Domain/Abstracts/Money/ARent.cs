// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;

using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Abstracts.People.Owners;
using Campgrounds.Domain.Models.Money;


///
namespace Campgrounds.Domain.Abstracts.Money
{

  ///
  public abstract class ARent : ABill
  {
    //  B] Properties
    // $$$ in 'Bill'



    public ARenter Renter { get; set; }

    public List<ATennant> Tennants { get; set; }

    public ALandOwner Landlord { get; set; }


    // [II]. BODY


    // [III]. FOOT
    public override string ToString()
    {
      return $"Rent: $";
    }

  }// /cla 'ARent'
}// /ns '..Abstracts.Money'
 // [EoF]