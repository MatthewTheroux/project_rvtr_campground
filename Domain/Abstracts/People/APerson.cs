// [I]. HEAAD
//  A] Libraries
using Campgrounds.Domain.Models.Locations;

/// 
namespace Campgrounds.Domain.Abstracts.People
{
    public abstract class APerson : AnEntity
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string FullName
        {
            get{return $"{FirstName} {LastName}";}
        }

        public int Ssn {get;} = 987654321;

        public Address address {get; set;}

        // [II]. BODY
        public APerson() {  }

        public APerson(string firstName, string lastName):this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public APerson(int ssn):this()
        {
            Ssn = ssn;
        }


        // [III]. FOOT
        public override string ToString()
        {
            return FullName;
        }
        
    }// /cla 'APerson'
}// /ns '..Abstracts'
// [EoF]