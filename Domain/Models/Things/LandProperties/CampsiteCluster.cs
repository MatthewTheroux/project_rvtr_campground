// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;
using System.Text;

using Campgrounds.Domain.Abstracts.Land;

///
namespace Campgrounds.Domain.Models.Land
{
  ///
  public class CampsiteCluster : ANeighborhood
  {
    public string Name { get; protected set; }
    public List<Campsite> Campsites { get; internal set; }


    // [III]. FOOT
    /// the string representation of a campsite grouping
    public override string ToString()
    {
      //  a) head
      StringBuilder sb = new StringBuilder();

      //  b) body
      sb.AppendLine($"{Name}");
      foreach (Campsite campsite in Campsites)
      {
        sb.AppendLine(campsite.ToString());
      }

      //  c) foot
      return sb.ToString();
    }

  }// /cla 'CampsiteCluster'
}// /ns '..Models..Land
 // [EoF]