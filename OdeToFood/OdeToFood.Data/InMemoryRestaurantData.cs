using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;
namespace OdeToFood.Data
{
    // make an in memory implementation
    // of the resturant data

    // implement this here
    // Resturant will be the return value
    
    public class InMemoryRestaurantData : IResturantData
    {

        // make some dummy data for inmemory uses

        List<Resturant> restaurants;





        

        // make this nullable too
        public Resturant GetById(int? id){
            // return r if r.id ==id
            // this is Linq
        return restaurants.SingleOrDefault(r=>r.Id==id);
    }





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
        // public IEnumerable<Resturant> GetAll()
        // now insted of implementating the GetAll()
        // we implement Get Resturant By Name

        public IEnumerable<Resturant> GetResturantsByName(string name)
        {

            // now we implement the method here
            // wwe can return a total loop
            // this is a LinQ query
            // its a c# featre
            return from r in restaurants
                       // adding  a where clause
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;

        }

        public Resturant Update(Resturant updatedResturant)
        {
            var resturant = restaurants.SingleOrDefault(r => r.Id == updatedResturant.Id);
            if (resturant != null) {

                // change the value with the new value
                // not the id
                // id remain the same
                resturant.Name = updatedResturant.Name;
                resturant.Cuisine = updatedResturant.Cuisine;
                resturant.Location = updatedResturant.Location;
            }
            return resturant;
        }

        public int Commit()
        {
            return 0;
        }

        public Resturant Add(Resturant newResturant)
        {
            // add it to the resurants list thats it
            restaurants.Add(newResturant);
            // now even wit the inmemory
            // we want to save it like the database
            // so we increment the id after every time we addit
            newResturant.Id = restaurants.Max(r => r.Id) + 1;
            return newResturant;
            // now go to the OnPost to change when update
            // is executed and when the Add
        }

        

    }
}
