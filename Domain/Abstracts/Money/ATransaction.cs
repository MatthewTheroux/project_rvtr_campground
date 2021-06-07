// [I]. HEAD
//  A] Libraries
using System;

using Campgrounds.Domain.Models.Money;

/// blueprints for items involving money
namespace Campgrounds.Domain.Abstracts.Money
{
  ///
  public abstract class ATransaction : AnEntity
  {
    //  B] Properties

    //[Unique] // link to ID
    public int TransactionNumber {get; set;}//protected
    public string Purpose {get; set;}

    public PaymentMethod paymentMethod {get; set;} = new PaymentMethod(PaymentMethod.Choice.CASH);
    public Price Amount {get; set;}


    // [III]. FOOT
    public override string ToString()
    {
      return $"#{TransactionNumber} ${Amount} {Purpose}";
    }

  }// /cla 'ATransaction'
}// /ns '..Abstracts,Money'
// [EoF]