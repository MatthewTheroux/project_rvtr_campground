// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Linq;

using Campgrounds.Domain.Interfaces;
using Campgrounds.Domain.Models.People;
using Campgrounds.Domain.Models.People.Owners;

///
namespace Campgrounds.Storage.Repositories
{
  ///
  public class CampgroundOwnerRepository : IRepositable<CampgroundOwner>
  {
    public List<CampgroundOwner> CampgroundOwner { get; set; } //<...>

    private readonly CampgroundsContext _context;


    // a parameterless construcor is required.
    public CampgroundOwnerRepository() : base() { }
    public CampgroundOwnerRepository(CampgroundsContext context) { _context = context; }

    /// [II]. BODY: Use CRUD
    /// 1. Create
    public bool Insert(CampgroundOwner campgroundOwner)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      try
      {
        _context.CampgroundOwners.Add(campgroundOwner);
        didSucceed = true;
      }
      catch (Exception e) { e.ToString(); }

      //  c) foot
      return didSucceed;
    }

    /// 2. Read
    public IEnumerable<CampgroundOwner> Select(Func<CampgroundOwner, bool> filter)
    {
      return _context.CampgroundOwners.Where(filter);
    }

    /// 3. Update
    public CampgroundOwner Update(CampgroundOwner campgroundOwner)
    {
      //  a) head


      //  b) body
      //<...>

      //  c)
      return campgroundOwner;
    }// /'Update'

    /// 4. Delete
    public bool Delete(CampgroundOwner campgroundOwner)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      _context.CampgroundOwners.Remove(campgroundOwner);

      //  c)
      return didSucceed = true;
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
 // [EoF]