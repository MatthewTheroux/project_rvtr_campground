// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;

using Campgrounds.Domain.Abstracts.Land;
using Campgrounds.Domain.Models.People;
using Campgrounds.Domain.Models.People.Owners;
using Campgrounds.Domain.Models.Things.Money;

/// people who own things
namespace Campgrounds.Domain.Models.Land
{
  /// a place to camp
  public class Campsite : ALandProperty
  {
    //  B] Properties

    //[Unique]
    public int LotNumber { get; protected set; }
    public string Name { get; protected set; }

    public new CampgroundOwner Owner { get; protected set; }
    public Campground Campground { get; }
    public CampsiteCluster CampsiteCluster { get; private set; }
    public CampsiteRenter Renter { get; set; }
    public new List<CampsiteTennant> Tennants { get; set; }

    public List<CampgroundTransaction> Transactions { get; set; }


    // [III]. FOOT
    public override string ToString()
    {
      return $"#{LotNumber} {Name}";
    }

  }// /cla 'CampgroundOwner'
}// /ns '..Models..Owners'
 // [EoF]