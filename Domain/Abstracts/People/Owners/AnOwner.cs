using Campgrounds.Domain.Abstracts.Things;

/// blueprints for people who own things
namespace Campgrounds.Domain.Abstracts.People.Owners
{

  /// someone who owns something
  public abstract class AnOwner : APerson
  {
    public AThing ThingThatIsOwned { get; set; }


    /// the string representation of AnOwner
    public override string ToString()
    {
      return $"{base.ToString()} owns {ThingThatIsOwned.ToString()}";
    }

  }// /cla 'AnOwner'
}// /ns '..Abstracts.People'
 // [EoF]