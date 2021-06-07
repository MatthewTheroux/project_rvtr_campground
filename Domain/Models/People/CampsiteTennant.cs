// [I]. HEAD
//  A] Libraries
using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Models.Land;

/// people who use campgrounds
namespace Campgrounds.Domain.Models.People
{
  /// 
  public class CampsiteTennant : ATennant
  {
    //  B] Properties
    public Campsite Site {get; set;}


    // [III]. FOOT
    /// the string representation of a campsite tennant
    public override string ToString()
    {
      return $"{FullName} at {Site.ToString()}";
    }

  }// /cla 'CampsiteTennant'
}// /ns '..Models.People'
// [EoF]