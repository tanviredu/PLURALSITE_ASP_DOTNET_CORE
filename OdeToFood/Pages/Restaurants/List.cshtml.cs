using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;



// list.cshtml is like the view of the page
// and List.cshtml.cs is the controller 
// of the pages
using OdeToFood.Data;
using System.Collections;
using OdeToFood.Core;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {

        // make a varitable with getter and setter
        public string Message { get; set; }

        // to show the resturant just like the Message
        // we need to declate some thing that is iterable
        // this is just  a public field
        public IEnumerable<Resturant> ResturantsField { get; set; }






        public readonly IConfiguration Config; // to make this thing global 
        // we can do it on mono develop and anywhere
        // make a global
        // this is object global
        public readonly IResturantData resturantData; 



        //we can import the configuration here too
        // the app settings.json file
        // lets import this configuration in the constructor
        // it will take IConfiguration object
        // IConfiguration is class config is object
        // passing data to constructor
        public ListModel(IConfiguration config,IResturantData resturantdata)
        {
            Config = config;
            resturantData = resturantdata;

            // we need to make this thing global
        }



        // on get process the get request
        public void OnGet()
        {
            // any data this method exposes the razor page
            // has this access to this value
            //Message = "hello World";
            // this is how you can access settings
            Message = Config["Messages"];


            // now after this we can add 
            // this to our ListModel


            // now fill the Resturants property with data
            ResturantsField = resturantData.GetAll();

            // ok now go to razor pages
        }
    }
}
