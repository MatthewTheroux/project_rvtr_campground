// [I]. HEAD
//  A] Libraries
using ClerkTracker.Storage.Repositories;

///
namespace ClerkTracker.Storage
{
  /// leverages the repositories, and more
   public class UnitOfWork
  {
    private readonly CampgroundsContext _campgroundsContext;

    public CampgroundRepository Campgrounds {get;}

    public CampgroundOwnerRepository CampgroundOwners {get;}

    public CampsiteRepository CampsiteRepositories {get;}

    public CampsiteRenterRepository CampsiteRenters {get;}

    public CampsiteTennantRepository CampsiteTennants {get;}

    public CampgroundTranactionRepository CampgroundTranasactions {get;}


  }// /cla 'UoW'
}// /ns '..Storage'
// [EoF]