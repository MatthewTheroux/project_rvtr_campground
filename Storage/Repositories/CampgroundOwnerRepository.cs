// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Linq;

using Campgrounds.Domain.Interfaces;
using Campgrounds.Domain.Models.People;

///
namespace Campgrounds.Storage.Repositories
{
  ///
  public class CampgroundOwnerRepository : IRepository<CampgroundOwner>
  {
    public List<CampgroundOwner> CampgroundOwner { get; set; } //<...>

    private readonly CampgroundsContext _context;


    // a parameterless construcor is required.
    public CampgroundOwnerRepository() : base() { }
    public CampgroundOwnerRepository(CampgroundsContext context) { _context = context; }

    /// [II]. BODY: Use CRUD
    /// 1. Create
    public bool Insert(CampgroundOwner campgroundowner)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      try
      {
        _context.CampgroundOwners.Add(campgroundowner);
        didSucceed = true;
      }
      catch (Exception e) { e.ToString(); }
      //$"There was an issue with adding pizza customer {customer}";

      //  c) foot
      return didSucceed;
    }

    /// 2. Read
    public IEnumerable<CampgroundOwner> Select(Func<CampgroundOwner, bool> filter)
    {
      return _context.CampgroundOwners.Where(filter);
    }

    /// 3. Update
    public CampgroundOwner Update(CampgroundOwner campgroundowner)
    {
      //  a) head


      //  b) body


      //  c)
      return campgroundowner;
    }// /'Update'

    /// 4. Delete
    public bool Delete(CampgroundOwner campgroundowner)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body


      //  c)
      didSucceed = true;
      return didSucceed;
    }

    // [III]. FOOT
    ///
    public override string ToString()
    {
      return "";//<!>
    }

    public List<CampgroundOwner> ToList() { return CampgroundOwner; }

    public void Save() { _context.SaveChanges(); }

  }// /cla 'CustomerRepository'
}// /ns '..Repositories'
 // EoF