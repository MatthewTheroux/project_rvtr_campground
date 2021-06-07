// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;

///
namespace Campgrounds.Domain.Interfaces
{
  /// Use C.R.U.D.
  public interface IRepositable<T> where T : class
  {
    // [II]. BODY

    /// C reate.
    public bool Insert(T item);

    /// R ead.
    public IEnumerable<T> Select(Func<T, bool> filter);

    /// U pdate.
    public T Update(T item);

    /// D elete.
    public bool Delete(T item);

  }// /ifc 'IReposiable'
}// /ns '..Interfaces'
 // [EoF]