using System.Collections.Generic;

///
namespace Campgrounds.Domain.Abstracts.Things
{
  ///
  public abstract class ASmartphone : APhone
  {
    public List<AnApp> Apps { get; protected set; }

    // [III]. FOOT
    public override string ToString()
    {
      return base.ToString();
    }

  } // /cla 'ASmartphone'
}// /ns '..Abstacts..Devices
 // [EoF]