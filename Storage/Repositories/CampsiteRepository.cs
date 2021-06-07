// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Linq;

using Campgrounds.Domain.Interfaces;
using Campgrounds.Domain.Models.Land;
using Campgrounds.Storage;

///
namespace Campgrounds.Storage.Repositories
{
  ///
  public class CampsiteRepository : IRepositable<Campsite>
  {
    //  B] Properties
    public List<Campsite> Campsites { get; set; } //<...>

    private readonly CampgroundsContext _context;

    //  C]
    // a parameterless construcor is required.
    public CampsiteRepository() : base() { }
    public CampsiteRepository(CampgroundsContext context) { _context = context; }


    /// [II]. BODY: Use CRUD
    /// 1. Create
    public bool Insert(Campsite campsite)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      try
      {
        _context.Campsites.Add(campsite);
        didSucceed = true;
      }
      catch (Exception e) { e.ToString(); }
      //$"There was an issue with adding pizza customer {customer}";

      //  c) foot
      return didSucceed;
    }

    /// 2. Read
    public IEnumerable<Campsite> Select(Func<Campsite, bool> filter)
    {
      return _context.Campsites.Where(filter);
    }

    /// 3. Update
    public Campsite Update(Campsite campsite)
    { //<...>
      //  a) head


      //  b) body


      //  c)
      return campsite;
    }// /'Update'

    /// 4. Delete
    public bool Delete(Campsite campsite)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      _context.Campsites.Remove(campsite);

      //  c)
      return didSucceed = true;
    }

    // [III]. FOOT
    ///
    public override string ToString()
    {
      return "";//<!>
    }

    public List<Campsite> ToList() { return Campsites; }

    public void Save() { _context.SaveChanges(); }

  }// /cla 'CustomerRepository'
}// /ns '..Repositories'
 // EoF