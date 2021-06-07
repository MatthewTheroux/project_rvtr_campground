namespace Campgrounds.Domain.Abstracts
{
  public abstract class AnEntity
  {
    //[Unique]
    public int EntityId { get; set; }//protected
    public string EntityName { get; set; }//protected


    public abstract override string ToString();

  }// /cla 'AnEntity'
}// /ns '..Abstracts
 // [EoF]