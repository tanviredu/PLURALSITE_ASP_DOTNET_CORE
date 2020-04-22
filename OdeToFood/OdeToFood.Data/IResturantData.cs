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

        IEnumerable <Resturant> GetAll();
        // this will get all the resturant object
        // and we can loop through it
    }


    // make an in memory implementation
    // of the resturant data

    public class InMemoryRestaurantData : IResturantData
    {

        // make some dummy data for inmemory uses

        List<Resturant> restaurants;




        // make a constructor

        public InMemoryRestaurantData()
        {
            // init the list
            restaurants = new List<Resturant>() { 
            
                // make some Restaurant data
           new Resturant{Id = 1,Name="Tanvir Rahman",Location="Bangladesh",Cuisine = Resturant.CuisineType.Indian
                },
           new Resturant{Id = 2,Name="Muktadir Rahman",Location="australia",Cuisine = Resturant.CuisineType.Italian
                },

            new Resturant{Id = 3,Name="rakibul kabir",Location="Mexico",Cuisine = Resturant.CuisineType.Mexican
                },


           new Resturant{Id = 4,Name="Tanvir Rahman Ornob",Location="England",Cuisine = Resturant.CuisineType.None
                }

              };

        }





        // implement the interface
        public IEnumerable<Resturant> GetAll()
        {

            // now we implement the method here
            // wwe can return a total loop
            // this is a LinQ query
            // its a c# featre
            return from r in restaurants
                   orderby r.Name
                   select r;

        }

        // now we have to send this data to razor page
        // but this interfce may have multiple
        //implementation like database,or nosql database,or filestorage
        // you can init the required method in the razor page
        // but we dont init any object in razor page
        // insted we change the service file
        // and tell them when we create the instalce of this Iresturant class
        // you will load only the InMemory method not other
        // later we can swith to databse just changing the configuration
        // this is called dependeny inversion
        // when ever we instanciate this class
        // only this method will be applied throughout the program

        // to do this go to Startup.cs file


    }
}
