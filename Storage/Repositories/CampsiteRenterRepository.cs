// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Linq;

using Campgrounds.Domain.Interfaces;
using Campgrounds.Domain.Models.People;
using Campgrounds.Storage;

///
namespace Campgrounds.Storage.Repositories
{
  ///
  public class CampsiteRenterRepository : IRepositable<CampsiteRenter>
  {
    //  B] Properties
    public List<CampsiteRenter> CampsiteRenters { get; set; } //<...>

    private readonly CampgroundsContext _context;

    //  C]
    // a parameterless construcor is required.
    public CampsiteRenterRepository() : base() { }
    public CampsiteRenterRepository(CampgroundsContext context) { _context = context; }

    /// [II]. BODY: Use CRUD
    /// 1. Create
    public bool Insert(CampsiteRenter campgroundRenter)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      try
      {
        _context.CampsiteRenters.Add(campgroundRenter);
        didSucceed = true;
      }
      catch (Exception e) { e.ToString(); }

      //  c) foot
      return didSucceed;
    }

    /// 2. Read
    public IEnumerable<CampsiteRenter> Select(Func<CampsiteRenter, bool> filter)
    {
      return _context.CampsiteRenters.Where(filter);
    }

    /// 3. Update
    public CampsiteRenter Update(CampsiteRenter campgroundRenter)
    { //<...>
      //  a) head


      //  b) body


      //  c)
      return campgroundRenter;
    }// /'Update'

    /// 4. Delete
    public bool Delete(CampsiteRenter campgroundRenter)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      _context.CampsiteRenters.Remove(campgroundRenter);

      //  c)
      return didSucceed = true;
    }

    // [III]. FOOT
    ///
    public override string ToString()
    {
      return "";//<!>
    }

    public List<CampsiteRenter> ToList() { return CampsiteRenters; }

    public void Save() { _context.SaveChanges(); }

  }// /cla 'CustomerRepository'
}// /ns '..Repositories'
 // [EoF]