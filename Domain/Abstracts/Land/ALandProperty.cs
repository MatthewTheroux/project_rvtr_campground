// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;
using System.Text;

using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Abstracts.People.Owners;

/// blueprints for things
namespace Campgrounds.Domain.Abstracts.Land
{
  /// a blueprint for land that can be owned
  public abstract class ALandProperty : AnEntity
  {
    //  B] Properties
    public ALandOwner Owner { get; protected set; }
    public ALocation Location { get; protected set; }

    public int MaxiumumOccupancy {get; protected set;} = 0;

    public List<ATennant> Tennants { get; set; }

    public List<ATennant> EvictedTennants {get; set;} = new List<ATennant>();

    public bool IsRentable { get; protected set; }
    public bool HasElectricity { get; protected set; }
    public bool HasGas { get; protected set; }
    public bool HasBasement { get; protected set; }


    // [III]. FOOT
    public override string ToString()
    {
      //  a) head
      StringBuilder sb = new StringBuilder();

      //  b) body
      sb.AppendLine(Owner.ToString());
      sb.AppendLine(Location.ToString());
      if (!IsRentable) sb.Append("NOT ");
      sb.AppendLine("Available for rent.");

      //  c) foot
      return sb.ToString();
    }// /'ToString'

  }// /cla 'ALandProperty'
}// /ns '..Abstracts.Things.Land'
 // [EoF]