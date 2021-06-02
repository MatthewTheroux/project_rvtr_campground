// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Linq;

using Campgrounds.Domain.Interfaces;
using Campgrounds.Domain.Models.Locations;

///
namespace Campgrounds.Storage.Repositories
{
  ///
  public class CampgroundRepository : IRepository<Campground>
  {
    public List<Campground> Campground { get; set; } //<...>

    private readonly CampgroundsContext _context;


    // a parameterless construcor is required.
    public CampgroundRepository() : base() { }
    public CampgroundRepository(CampgroundsContext context) { _context = context; }

    /// [II]. BODY: Use CRUD
    /// 1. Create
    public bool Insert(Campground campgroundowner)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      try
      {
        _context.Campgrounds.Add(campgroundowner);
        didSucceed = true;
      }
      catch (Exception e) { e.ToString(); }
      //$"There was an issue with adding pizza customer {customer}";

      //  c) foot
      return didSucceed;
    }

    /// 2. Read
    public IEnumerable<Campground> Select(Func<Campground, bool> filter)
    {
      return _context.Campgrounds.Where(filter);
    }

    /// 3. Update
    public Campground Update(Campground campgroundowner)
    {
      //  a) head


      //  b) body


      //  c)
      return campgroundowner;
    }// /'Update'

    /// 4. Delete
    public bool Delete(Campground campgroundowner)
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

    public List<Campground> ToList() { return Campground; }

    public void Save() { _context.SaveChanges(); }

  }// /cla 'CustomerRepository'
}// /ns '..Repositories'
 // EoF