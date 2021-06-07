// [I]. HEAD

/// tools for other classes
namespace Campgrounds.Domain.Interfaces
{
  /// Encode and Decode 
  public interface IEncryptable<T> where T : class
  {
    public T Encrpyt(T item);
    public T Decrypt(T item);

  }// /ifc 'IEncryptable'
}// /ns '..Interfaces'
 // [EoF]