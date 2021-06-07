// [I]. HEAD
//  A] Libraries
using System;

/// 
namespace Campgrounds.Domain.Models.Contact
{
  /// 
  public class PhoneNumber
  {
    //  B] Properties
    //   1.
    private int _countryCode = 1; //USA
    private int _areaCode; // 3 digits
    private int _districtCode; // 3 digits
    private int _index; // 4 digits

    //   2.


    // [II]. BODY: Constructs
    /*
    /// Poll
    public PhoneNumber()
    {
        System.Console.Write("New Phone Number: ");
        string s = System.Console.ReadLine();
        // chain to below
    }// */
    public PhoneNumber(string s)
    {
      // Remove any dashes or whitespace.
      s = s.Replace('-', '\0').Replace(' ', '\0').Replace('\t', '\0');
      int n;
      bool didParse = int.TryParse(s, out n);
      if (didParse) { }//chain to below
      else ReportInvalidPhoneNumber();
    }

    private void ReportInvalidPhoneNumber()
    {
      throw new ArgumentException("The format or value for a phone number is not valid.");
    }

    /// Separate the pieces.

    public PhoneNumber(int n)
    {

    }

    // [III], FOOT
    /// the string representation of a phone number
    public override string ToString()
    {
      return $"+{_countryCode}-{_areaCode}-{_districtCode}-{_index}";
    }
  }// /cla 'PhoneNumber'
}// /ns '..Models.ContactInfo'
// [EoF]