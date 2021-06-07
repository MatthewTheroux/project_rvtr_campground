// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;

using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Abstracts.Land;
using Campgrounds.Domain.Models.Locations;
using Campgrounds.Domain.Models.Money;

/// blueprints for types of people
namespace Campgrounds.Domain.Abstracts.People.Owners
{
  ///
  public abstract class ALandOwner : AnOwner
  {
    //  B] Properties
    //<...> Link to 'ThingThatIsOwned'
    public ALocation PlaceThatIsOwned { get; set; }



    // [II]. BODY

    //  A] Admit
    /// 
   public abstract void Admit(ATennant tennant, ALandProperty propertyToAdmitTo);

   //  B] Bill
  public abstract void Bill(ARenter renter, Price Amount);

    //  C] Evict
    /// Evict selected tennants from a given property
    //public abstract List<ATennant> Evict(ALandProperty propertyToEvictFrom, List<ATennant> tennantsToEvict);

   /// Evict the given tennants and figure out from where
   public abstract List<ATennant> Evict(List<ATennant> tennantsToEvict);

   /// Just evict *one* tennant.
   public abstract ATennant Evict(ATennant theTennantToEvict);

   
    /// Evict *all* tennants of the given property
    public abstract List<ATennant> Evict(ALandProperty propertyToEvictFrom);

    /// A Tennant leaves by choice
    public abstract bool Retire(ATennant tennant);


    // [III]. FOOT
    public abstract override string ToString();

  }// /cla 'ALandOwner'
}// /ns '..Abstacts.People'
 // [EoF]