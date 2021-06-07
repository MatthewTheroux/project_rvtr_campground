// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;

using Campgrounds.Domain.Abstracts.Land;
using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Abstracts.People.Owners;
using Campgrounds.Domain.Models.People;
using Campgrounds.Domain.Models.Land;
using Campgrounds.Domain.Models.Money;

/// people who own things
namespace Campgrounds.Domain.Models.People.Owners
{
  /// a person who owns campgrounds
  public class CampgroundOwner : ALandOwner
  {
    //  B] Properties
    public List<Campground> CampgroundsOwned { get; protected set; }



    // [II]. BODY
    //  A] Admit
    public override bool Admit(List<ATennant> tennantsToAdmit, ALandProperty propertyToAdmitTo)
    {
      //  a) head: convert to Campsite
      Campsite campsiteToAdmitTo = (Campsite)propertyToAdmitTo;
      int numberOfCampsiteTennantsAtCampsite = campsiteToAdmitTo.Tennants.Count;
      int maximumNumberOfCampsiteTennantsAtCampsite = campsiteToAdmitTo.MaxiumumOccupancy;
      List<CampsiteTennant> campsiteTennantsToAdmit = new List<CampsiteTennant>();

      //  b) body: contiue converting, then admit, if possible
      foreach (ATennant tennantToAdmit in tennantsToAdmit)
      {
        // Verify the number of people that want to stay does not exceed the number of people who can fit there.
        if (numberOfCampsiteTennantsAtCampsite >= maximumNumberOfCampsiteTennantsAtCampsite)
        {
          // Not everyone fits to be admitted.  {:-(
          return false;
        }

        // Otherwise, add him/r.
        numberOfCampsiteTennantsAtCampsite++;
        CampsiteTennant campsiteTennantToAdmit = (CampsiteTennant)tennantToAdmit;

        campsiteTennantToAdmit.CurrentStatus = ATennant.Status.STAYING_CURRENTLY;
        campsiteTennantsToAdmit.Add(campsiteTennantToAdmit);
        campsiteToAdmitTo.Tennants.Add(campsiteTennantToAdmit);
        // <...>?
      }

      //  c) foot
      // Everyone was admitted to the campsite. {:-)
      return true;
    }

    //  B]
    /// Bill the renter
    public override void Bill(ARenter renter, Price Amount)
    {
      CampsiteRenter campsiteRenter = (CampsiteRenter)renter;
      // <...>
    }

    //  C]
    /// Evict given tennents
    public override List<ATennant> Evict(List<ATennant> tennantsToEvict)
    {
      //  a) head: 
      Campsite campsiteToEvictFrom;
      List<CampsiteTennant> campsiteTennantsEvictedSuccessfully = new List<CampsiteTennant>();

      //  b) body: convert, search, remove
      List<CampsiteTennant> campsiteTennantsToEvict = new List<CampsiteTennant>();
      foreach (ATennant tennantToEvict in tennantsToEvict)
      {
        CampsiteTennant campsiteTennantToEvict = (CampsiteTennant)tennantToEvict;
        campsiteTennantsToEvict.Add(campsiteTennantToEvict);

        // Find which campground s/he is listed in.
        foreach (Campground campgroundToSearch in CampgroundsOwned)
        {
          if (campgroundToSearch.Tennants.Contains(campsiteTennantToEvict))
          {
            // Find which campsite s/he is listed in.
            foreach (Campsite campsiteToSearch in campgroundToSearch.Campsites)
            {
              if (campsiteToSearch.Tennants.Contains(campsiteTennantToEvict))
              {
                campsiteToSearch.Tennants.Remove(campsiteTennantToEvict);
                campgroundToSearch.Tennants.Remove(campsiteTennantToEvict);
                campsiteTennantToEvict.CurrentStatus = ATennant.Status.EVICTED;
                campgroundToSearch.Tennants.Remove(campsiteTennantToEvict);

              }
              else
              {
                // <!> not found among campsites on campground
              }
            }
          }
          else
          {
            // <!> not found among campgrounds
          }
        }
      }

      //  c) foot
      //<!>
      return tennantsToEvict;
    }// /fx

    public override List<ATennant> Evict(ALandProperty siteToEvict) //<!>
    {
      //  a) head
      Campsite campsiteToEvict = (Campsite)siteToEvict;
      List<CampsiteTennant> campsiteTennants = campsiteToEvict.Tennants;

      //  b) body

      //  c) foot
      //   i)
      List<ATennant> tennants = new List<ATennant>();

      //   ii)
      foreach (CampsiteTennant campsiteTennant in campsiteTennants)
      {
        ATennant tennant = (ATennant)campsiteTennant;
        tennants.Add(tennant);
      }

      //   iii)
      return tennants;
    }// /fx


    // [III]. FOOT
    public override string ToString()
    {
      //<...>
      return "";
    }


  }// /cla 'CampgroundOwner'
}// /ns '..Models..Owners'
 // [EoF]