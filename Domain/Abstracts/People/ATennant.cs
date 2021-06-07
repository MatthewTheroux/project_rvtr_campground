// [I]. HEAD
//  A] Libraries
using System; // for enum
using System.Collections.Generic;

using Campgrounds.Domain.Abstracts.Land;

///
namespace Campgrounds.Domain.Abstracts.People
{
  //  B] Properties
  ///
  public abstract class ATennant : APerson
  {

    public ALocation PlaceToOccupy{get; set;}

    //<?>
    public List<ATennant> FellowTennants {get; set;}

    //   2.
    public enum Status
    {
      UNKNOWN = 0,
      RESERVED,
      STAYING_CURRENTLY,
      RESIDING,
      RETIRED,
      EVICTED
    }
    public Status CurrentStatus {get; set;} = Status.UNKNOWN;


    // [III].  FOOT
    public override string ToString()
    {
      return $"{FullName}: {CurrentStatus.ToString()} @{PlaceToOccupy.ToString()}";
    }

  }// /cla 'ATennant'
}// /ns '..Abstracts.People
// [EoF]