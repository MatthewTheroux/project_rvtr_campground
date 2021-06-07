using Campgrounds.Domain.Abstracts.People.Owners;

///
namespace Campgrounds.Domain.Abstracts.Things
{
  public abstract class AThing : AnEntity
  {
    //  Properties
    /// 
    public string Name { get; set; }

    ///
    public AnOwner Owner {get; set;}

    ///
    public string WhatItIs { get; set; }

    

  }// /cla 'AThing'
}// /ns '..Abstracts.Things'
 // [EoF]