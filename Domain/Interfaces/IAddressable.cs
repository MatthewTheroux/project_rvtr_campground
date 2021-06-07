// [I]. HEAD

/// tools for other classes
namespace Campgrounds.Domain.Interfaces
{
  /// Encode and Decode 
  public interface IAddressable<T> where T : class
  {
    //<...>
    public T A(T item);
    public T B(T item);

  }// /ifc 'IAddressable'
}// /ns '..Interfaces'
 // [EoF]