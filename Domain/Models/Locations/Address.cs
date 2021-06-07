// [I]. HEAD
//  A] Libraries
using System.Collections.Generic;
using System.Text;

using Campgrounds.Domain.Abstracts.People;
using Campgrounds.Domain.Abstracts.People.Owners;

/// 
namespace Campgrounds.Domain.Models.Locations
{
  /// 
  public class Address
  {
    //  B] Fields & Properties
    //   1.
    public string Name { get; private set; }

    public StreetAddress StreetAddress { get; private set; }
    public string City { get; private set; }
    public string Province { get; private set; } // 'State'
    public string ProvinceCode { get; private set; }
    public string PostalCode { get; private set; } // 'zip'
    public string Country { get; private set; }
    public string CountryCode { get; private set; }

    //  2. 
    public ALandOwner Owner { get; set; }

    public List<ATennant> Tennants { get; set; }


    // [II]. BODY
    //  A]
    /// parameterless constructor: default address
    /// 300 Alamo Plaza, San Antonio, TX 78205
    public Address()
    {
      //
      Name = "The Alamo";
      StreetAddress = new StreetAddress(300, "Alamo Plaza");
      City = "San Antonio";
      Province = "Texas";
      ProvinceCode = "TX";
      PostalCode = "78205";
      Country = "United States";
      CountryCode = "USA";
    }

    // [III]. FOOT
    /// the string reperesentation of an Address
    public override string ToString()
    {
      //  a) head
      StringBuilder sb = new StringBuilder();

      //  b) body
      sb.AppendLine($"{Name}");
      sb.AppendLine($"{StreetAddress}");

      sb.Append($"{City}, ");
      sb.Append($"{ProvinceCode}, ");
      sb.Append($"{PostalCode}, ");
      sb.Append($"{CountryCode}");
      sb.AppendLine();

      //  c) foot
      return sb.ToString();
    }// /md 'ToString'
  }// /cla
}// /ns