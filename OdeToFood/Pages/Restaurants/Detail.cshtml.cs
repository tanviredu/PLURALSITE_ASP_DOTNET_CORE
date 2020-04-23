using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;
namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {

        // this is not a implementation
        // this is just make  global type
        // ekta type nilam
        private readonly IResturantData resturantData;


        // type ta fill korlam

        public DetailModel(IResturantData resturantdata)
        {

            // we are ssigning a object of the Iresturant Data
            // setting the object to the resturantData
            resturantData = resturantdata;
        }

        // this type can hold a single resturant object
        // because this is a details page
        // resturantData type
        // from the interaface







        // we make a global public property
        // so we can send and invoke in onGEt
        // we make a property type resturants
        // fromtthe ode to food core Restaurent class






        // because this 





        // this attribute is set to make 
        // the restaurent object in the onget
        // global

        // model output fild toiru korlam
        public Resturant Resturant {get;set;}

        // this parameter have to be
        // to match the asp-route parameter


        // normally OnGet doesnot return anything
        // but you have contoll in that 
        // we are going to return  default Iactionresult
        // for handling bad request
        public IActionResult OnGet(int resturentId)
        {

            // now everytime you create a resturant 
            // object some method will come with it
            // because of the implementaion of the Resturane
            // we make another method in the Interface IresturantData
            // Inodetofood.Data project
            // so implement this too
            //GetById
            // first maeke the method that returns a resturant

            //Console.WriteLine(resturentId);

            // this Iresturant gives us the method
            // if you go to the GetById in the
            // in memory model
            // you will see that it return
            // a searchresult from the search result
            // so here the resturaantdata type has method GetById
            // and for inmemory it returns a Resturant object
            // in the output field

            Resturant = resturantData.GetById(resturentId);
            // page will return a implementation
            // of the Iaction and send the Page

            if (Resturant == null){
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
