// [I]. HEAD
//  A] Libraries
using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Abstracts.People.Owners;
using Campgrounds.Domain.Models.People.Owners;
using Campgrounds.Domain.Models.Land;


/// 
namespace Campgrounds.Domain.Models.People
{
  public class CampsiteRenter : ARenter
  {
    /// Where | What is being rented?
    public Campsite Site {get; set;}

    /// Payment Info


  }// /cla 'CampsiteRenter'
}// /ns '..Models.People'
// [EoF]