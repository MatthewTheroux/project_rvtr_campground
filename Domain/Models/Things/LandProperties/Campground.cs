// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;

using Campgrounds.Domain.Abstracts.Land;
using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Abstracts.People.Owners;
using Campgrounds.Domain.Models.People;
using Campgrounds.Domain.Models.People.Owners;
using Campgrounds.Domain.Models.Land;
using Campgrounds.Domain.Models.Things.Money;

/// people who own things
namespace Campgrounds.Domain.Models.Land
{
  /// someone who ows a campground
  public class Campground : ALandProperty
  {
    //  B] Properties
    public string Name {get; protected set;}
    public new CampgroundOwner Owner {get; protected set;}
    public List<Campsite> Campsites {get; set;}

    public List<CampsiteRenter> Renters {get; set;}
    public new List<CampsiteTennant> Tennants {get; set;}

    public List<CampgroundTransaction> Transactions {get; set;}


    // [III]. FOOT
    public override string ToString()
    {
      //<...>
      return"";
    }

  }// /cla 'CampgroundOwner'
}// /ns '..Models..Owners'
// [EoF]