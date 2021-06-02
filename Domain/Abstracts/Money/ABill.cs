// [I]. HEAD
//  A] Libraries
using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Models.Money;


///
namespace Campgrounds.Domain.Abstracts.Money
{

  ///
  public class ABill : AnEntity
  {
    //  B] Properties
    public Price OriginalAmount {get; set;}

    public Price AmountPaid { get; set; }

    public Price AmountStillOwed { get; set; }

    public APerson Ower {get; set;}

    public APerson OneOwed {get; set;}


    // [III]. FOOT
    ///
    public override string ToString()
    {

      //  c) foot
      return "";
    }

  }// /cla 'ARent'
}// /ns '..Abstracts.Money'
 // [EoF]