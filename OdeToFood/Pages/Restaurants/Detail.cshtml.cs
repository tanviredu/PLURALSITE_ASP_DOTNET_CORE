using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {

        // we make a global public property
        // so we can send and invoke in onGEt
        // we make a property type resturants
        // fromtthe ode to food core Restaurent class


        // this attribute is set to make 
        // the restaurent object in the onget
        // global
        public Resturant Resturant {get;set;}

        // this parameter have to be
        // to match the asp-route parameter
        public void OnGet(int resturentId)
        {
            Console.WriteLine(resturentId);
            Resturant = new Resturant();
        }
    }
}
