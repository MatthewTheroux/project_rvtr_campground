// [I]. HEAD
//  A] Libraries
using System;
using System.Collections.Generic;

using Campgrounds.Domain.Abstracts.Money;

///
namespace Campgrounds.Domain.Abstracts.People {

  ///
  public abstract class ARenter : APerson
  {
    //  B] Properties
    public List<ARent> Rents { get; private set; }


    // [II]. BODY
    private ARent AddRent(ARent rent)
    {

      //  b) body
      Rents.Add(rent);

      //  c) foot
      return rent;
    }// /md 'AddRent'


    // [III]. FOOT
    public override string ToString()
    {


      //  c) foot
      return "";// <!>
    }// /'ToString'

  }// /cla 'A'
}// /ns '..Abstracts.People'
// [EoF]