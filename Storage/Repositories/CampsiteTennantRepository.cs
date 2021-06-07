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
  public class CampsiteTennantRepository : IRepositable<CampsiteTennant>
  {
    //  B] Properties
    public List<CampsiteTennant> CampsiteTennants { get; set; } //<...>

    private readonly CampgroundsContext _context;

    //  C]
    // a parameterless construcor is required.
    public CampsiteTennantRepository() : base() { }
    public CampsiteTennantRepository(CampgroundsContext context) { _context = context; }


    /// [II]. BODY: Use CRUD
    /// 1. Create
    public bool Insert(CampsiteTennant campsiteTennant)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      try
      {
        _context.CampsiteTennants.Add(campsiteTennant);
        didSucceed = true;
      }
      catch (Exception e) { e.ToString(); }
      //$"There was an issue with adding pizza customer {customer}";

      //  c) foot
      return didSucceed;
    }

    /// 2. Read
    public IEnumerable<CampsiteTennant> Select(Func<CampsiteTennant, bool> filter)
    {
      return _context.CampsiteTennants.Where(filter);
    }

    /// 3. Update
    public CampsiteTennant Update(CampsiteTennant campsiteTennant)
    { //<...>
      //  a) head


      //  b) body


      //  c)
      return campsiteTennant;
    }// /'Update'

    /// 4. Delete
    public bool Delete(CampsiteTennant campsiteTennant)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      _context.CampsiteTennants.Remove(campsiteTennant);

      //  c)
      return didSucceed = true;
    }

    // [III]. FOOT
    ///
    public override string ToString()
    {
      return "";//<!>
    }

    public List<CampsiteTennant> ToList() { return CampsiteTennants; }

    public void Save() { _context.SaveChanges(); }

  }// /cla 'CustomerRepository'
}// /ns '..Repositories'
 // [EoF]