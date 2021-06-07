using System.Text;

///
namespace Campgrounds.Domain.Abstracts.Things
{
  public abstract class ADevice : AThing
  {
    //  Properties
    public string Make { get; private set; }

    public string Model { get; private set; }

    // [Unique] // Link to EntityId
    public string SerialNumber { get; private set; }


    // [III]. FOOT
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine($"Name: {Name}");
      sb.AppendLine($"Make: {Make}");
      sb.AppendLine($"Model: {Model}");
      sb.AppendLine($"#{SerialNumber}");
      sb.AppendLine($"Owned by {Owner}");
      return sb.ToString();
    }

  }// /cla 'ADevice'
}// /ns '..Abstracts.Things'
 // [EoF]