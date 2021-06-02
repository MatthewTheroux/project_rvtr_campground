// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Campgrounds.Domain.Abstracts;
using Campgrounds.Domain.Models;
using Campgrounds.Domain.Models.Campground;
using Campgrounds.Domain.Models.Campsite;
using Campgrounds.Domain.Models.CampgroundOwner;
using Campgrounds.Domain.Models.CampsiteRenter;
using Campgrounds.Domain.Models.CampsiteTennant;
using Campgrounds.Domain.Models.CampgroundTransaction;

///
namespace Campgrounds.Storage
{
  public class CampgroundsContext : DbContext
  {
    //  B] Properties
    private const int INDEX_FOR_UNSUPPORTED = -1;

  // [II]. BODY

    
  // [III]. FOOT
  public void Save()
  {

  }

  }// /cla 'CampgroundContext'
}// /ns '..Storage'
 // EoF