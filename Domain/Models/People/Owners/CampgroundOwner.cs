// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;

using Campgrounds.Domain.Abstracts.Land;
using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Abstracts.People.Owners;
using Campgrounds.Domain.Models.People;
using Campgrounds.Domain.Models.Land;

/// people who own things
namespace Campgrounds.Domain.Models.People.Owners
{
  /// a person who owns campgrounds
  public class CampgroundOwner : ALandOwner
  {
    //  B] Properties
    public List<Campground> CampgroundsOwned {get; protected set;}



    // [II]. BODY

    public override List<ATennant> Evict (List<ATennant> tennantsToEvict)
    {
      //  a) head
      List<CampsiteTennant> campsiteTennantsToEvict = new List<CampsiteTennant>();
      foreach(ATennant tennantToEvict in tennantsToEvict)
      {
        CampsiteTennant campsiteTennantToEvict = (CampsiteTennant) tennantToEvict;
        campsiteTennantsToEvict.Add(campsiteTennantToEvict);

        foreach(Campground campground in CampgroundsOwned)
        {
          if(campground.Tennants.Contains(campsiteTennantToEvict))
          {
            //<...>
          }
          else
          {
            //<...>err
          }
        }

      return tennantsToEvict;
    }

    public override List<ATennant> Evict (ALandProperty siteToEvict)
    {
      //  a) head
      Campsite campsiteToEvict = (Campsite) siteToEvict;

      foreach(CampsiteTennant campsiteTennant in campsiteToEvict.Tennants)
      {
        campsiteToEvict.Tennants.
      }
    }

    
    // [III]. FOOT
    public override string ToString()
    {
      //<...>
      return "";
    }


  }// /cla 'CampgroundOwner'
}// /ns '..Models..Owners'
// [EoF]