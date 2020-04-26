using System;
using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;
namespace OdeToFood.Data
{
    public interface IResturantData
    {
        
        IEnumerable<Resturant> GetResturantsByName(string name);
        Resturant GetById(int? id);

        // now the update resturant 
        // it will take a resturant and return a Resturant
        Resturant Update(Resturant updatedResturant);
        // another method to create a resturent
        //cshtml will return a  new resturant object
        // and this will save it to the in memory
        // take a resturant object return a resturant object
        Resturant Add(Resturant newResturant);
        // and implement in the Inmemory data
        int Commit();
        



        // this will get all the resturant object
        // and we can loop through it
    }
}
