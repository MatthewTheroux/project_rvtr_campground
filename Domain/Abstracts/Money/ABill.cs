// [I]. HEAD
//  A] Libraries
using System;
using System.Text;

using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Models.Money;

///
namespace Campgrounds.Domain.Abstracts.Money
{

  ///
  public abstract class ABill : AnEntity
  {
    //  B] Properties
    //   1.

    public string Name { get; set; }

    public Price OriginalAmount { get; private set; }

    public Price AmountPaid { get; private set; }

    public Price AmountStillOwed { get; private set; }

    public Price NextPaymentAmount { get; private set; }

    //   2.
    public string Purpose { get; private set; }
    public APerson OneWhoOwes { get; private set; }

    public APerson OneWhoIsOwed { get; private set; }


    //   3.
    public DateTime DateWritten { get; private set; }
    public DateTime DateDue { get; private set; }

    // [II]. BODY
    /// an empty parameterless constructor
    public ABill() { }


    // [III]. FOOT
    ///
    public override string ToString()
    {
      //  a) head
      StringBuilder sb = new StringBuilder();

      //  b) body
      sb.AppendLine($"{DateWritten}");
      sb.AppendLine($"{Name}");
      sb.AppendLine($"  {OriginalAmount} Original Total Amount for {Purpose}.");
      sb.AppendLine($"- {AmountPaid} Amount Paid, so far.");
      sb.AppendLine($"= {AmountStillOwed} Amount Remaining Owed.");
      sb.AppendLine("------------------------------------------------------------");
      sb.AppendLine($"{NextPaymentAmount}");
      sb.AppendLine($"Due {DateDue}");

      //  c) foot
      return sb.ToString();
    }// /'ToString'

  }// /cla 'ARent'
}// /ns '..Abstracts.Money'
 // [EoF]