using System;
using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;
namespace OdeToFood.Data
{
    public interface IResturantData
    {
        // IEnumerable in C# is an interface that defines one method, 
        //GetEnumerator (GetAll()) which returns an IEnumerator interface. 
        //This allows readonly access to a collection 
        // and you can also apply loop in this collection
        // much like a list

        //IEnumerable <Resturant> GetAll();
        // isted of get all we can search for getAllByName()
        // and when you entered an empty parameter
        // you will get all the result

        IEnumerable<Resturant> GetResturantsByName(string name);
        Resturant GetById(int id);



        // this will get all the resturant object
        // and we can loop through it
    }
}
