
using Campgrounds.Domain.Models.Money;

namespace Campgrounds.Domain.Interfaces
{
  public interface IBillable<T> where T : class
  {
    //  B] Properties
    public abstract Price AmountOwed { get; set; }


    // [II]. BODY
    public T AddCharge(T item);

    public T CollectPayment(T item);

    
    // [III]. FOOT
    public string ToString();

  }// /ifc 'IBillable'
}// /ns '..Interfaces'
 // [EoF]