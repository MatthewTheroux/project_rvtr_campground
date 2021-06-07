// [I]. HEAD
//  A] Libraries
using System; // for enum

///
namespace Campgrounds.Domain.Models.Money
{
  ///
  public class CreditCardPaymentMethod : PaymentMethod
  {
    ///
    // [Unique][Required]
    public int CardNumber {get;}
    
    ///
    public new enum Choice
    {
      UNDEFINED = 0,
      AMERICAN_EXPRESS = 3,
      VISA = 4,
      MASTER_CARD = 5,
      DISCOVERY,
      DINERS_CLUB
    }

    public new Choice Selection {get; set;} = Choice.UNDEFINED;


    // [II]. BODY: Constructors

    /// direct constructor with choice
    public CreditCardPaymentMethod(Choice choice)
    {
      Selection = choice;
    }

    /// convert from string constructor
    public CreditCardPaymentMethod(string choiceAsString)
    {
      //  a) head 
      Choice selection = Choice.UNDEFINED;

      //  b) body
      Enum.TryParse(choiceAsString, true, out selection);

      //  c) foot
      Selection = selection;
    }

    /// parameterless constructor. default = UNDEFINED
    public CreditCardPaymentMethod() : this(Choice.UNDEFINED) { }


    // [III]. FOOT
    /// the string representation of a credit card payment method
    public override string ToString()
    {
      return $"{Selection.ToString()}: {CardNumber}";
    }


  }// /cla 'CreditCardPayment'
}// /ns '..Money'
// [EoF]