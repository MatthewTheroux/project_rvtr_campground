// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;
using System.Linq;

using Campgrounds.Domain.Interfaces;
using Campgrounds.Domain.Models.Things.Money;
using Campgrounds.Storage;

///
namespace Campgrounds.Storage.Repositories
{
  ///
  public class CampgroundTransactionRepository : IRepositable<CampgroundTransaction>
  {
    //  B] Properties
    public List<CampgroundTransaction> CampgroundTransactions { get; set; } //<...>

    private readonly CampgroundsContext _context;

    //  C]
    // a parameterless construcor is required.
    public CampgroundTransactionRepository() : base() { }
    public CampgroundTransactionRepository(CampgroundsContext context) { _context = context; }


    /// [II]. BODY: Use CRUD
    /// 1. Create
    public bool Insert(CampgroundTransaction campgroundTransaction)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      try
      {
        _context.CampgroundTransactions.Add(campgroundTransaction);
        didSucceed = true;
      }
      catch (Exception e) { e.ToString(); }
      //$"There was an issue with adding pizza customer {customer}";

      //  c) foot
      return didSucceed;
    }

    /// 2. Read
    public IEnumerable<CampgroundTransaction> Select(Func<CampgroundTransaction, bool> filter)
    {
      return _context.CampgroundTransactions.Where(filter);
    }

    /// 3. Update
    public CampgroundTransaction Update(CampgroundTransaction campgroundTransaction)
    { //<...>
      //  a) head


      //  b) body


      //  c)
      return campgroundTransaction;
    }// /'Update'

    /// 4. Delete
    public bool Delete(CampgroundTransaction campgroundTransaction)
    {
      //  a) head
      bool didSucceed = false;

      //  b) body
      _context.CampgroundTransactions.Remove(campgroundTransaction);

      //  c)
      return didSucceed = true;
    }

    // [III]. FOOT
    ///
    public override string ToString()
    {
      return "";//<!>
    }

    public List<CampgroundTransaction> ToList() { return CampgroundTransactions; }

    public void Save() { _context.SaveChanges(); }

  }// /cla 'CustomerRepository'
}// /ns '..Repositories'
 // [EoF]