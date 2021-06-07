// [I]. HEAD
//  A] Libraries
using System; // for enum

using Campgrounds.Domain.Abstracts;

/// items involving money
namespace Campgrounds.Domain.Models.Money
{
  ///
  public class PaymentMethod : AnEntity
  {
    //  B] Properties
    public enum Choice
    {
      UNDECIDED = 0,
      CASH,
      CHECK,
      CREDIT_CARD,
      E_PAY,
      CRYPTO_CURRENCY
    }

    public Choice Selection { get; set; } = Choice.UNDECIDED;


    // [II]. BODY: Constructors

    /// direct constructor with choice
    public PaymentMethod(Choice choice)
    {
      Selection = choice;
    }

    /// convert from string constructor
    public PaymentMethod(string choiceAsString)
    {
      //  a) head 
      Choice selection = Choice.UNDECIDED;

      //  b) body
      Enum.TryParse(choiceAsString, true, out selection);

      //  c) foot
      Selection = selection;
    }

    /// parameterless constructor. default = UNDECIDED
    public PaymentMethod() : this(Choice.UNDECIDED) { }


    // [III]. FOOT
    /// the string representation of a payment method
    public override string ToString()
    {
      return Selection.ToString();
    }


  }// /cla 'PaymentMethod'
}// /ns '..Money'
 // [EoF]