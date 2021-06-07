// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Campgrounds.Domain.Abstracts;
using Campgrounds.Domain.Models;
using Campgrounds.Domain.Models.People;
using Campgrounds.Domain.Models.People.Owners;
using Campgrounds.Domain.Models.Land;
using Campgrounds.Domain.Models.Things.Money;


///
namespace Campgrounds.Storage
{
  public class CampgroundsContext : DbContext
  {
    //  B] Properties
    private const int INDEX_FOR_UNSUPPORTED = -1;

    public List<Campground> Campgrounds { get; private set; }
    public List<CampgroundOwner> CampgroundOwners { get; private set; }
    public List<Campsite> Campsites { get; private set; }
    public List<CampsiteRenter> CampsiteRenters { get; private set; }
    public List<CampsiteTennant> CampsiteTennants { get; private set; }
    public List<CampgroundTransaction> CampgroundTransactions { get; private set; }


    // [II]. BODY


    // [III]. FOOT
    public void Save()
    {

    }

  }// /cla 'CampgroundContext'
}// /ns '..Storage'
 // EoF