using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using OdeToFood.Core;
using OdeToFood.Data;
namespace OdeToFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {

        // this is not a implementation
        // this is just make  global type
        // ekta type nilam
        private readonly IResturantData resturantData;


        // type ta fill korlam



        public readonly IHtmlHelper htmlHelper;

        public EditModel(IResturantData resturantdata,IHtmlHelper htmlhelper)
        {











            htmlHelper = htmlhelper;            
            // we are ssigning a object of the Iresturant Data
            // setting the object to the resturantData
            resturantData = resturantdata;
        }



        //make a property if Ienumerable
        // to store the Enum as a list
        // ienumrable have different
        // type this is for rendering
        //it will help you to make HTMl select

        public IEnumerable<SelectListItem> Cuisines { get; set; }



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
        [BindProperty]
        public Resturant Resturant { get; set; }

        // this parameter have to be
        // to match the asp-route parameter


        // normally OnGet doesnot return anything
        // but you have contoll in that 
        // we are going to return  default Iactionresult
        // for handling bad request

        

            // make this parameter optional 
            // to support the create page
            // we make this parameter nullab;e
        public IActionResult OnGet(int? resturentId)
        {

            // checked if the resturantId is inserted
            if (resturentId.HasValue) {
                Cuisines = htmlHelper.GetEnumSelectList<Resturant.CuisineType>();
                Resturant = resturantData.GetById(resturentId);

            }
            else
            {
                // create a new object
                Resturant = new Resturant();

            }
            // page will return a implementation
            // of the Iaction and send the Page

            if (Resturant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }


        public IActionResult OnPost() {

            // handle post request
            // this updated resturent object
            // that is made in the form
            // we pass to the data service of the 
            // Resturant
            // then we apply the commit()
            // then return the same page


            // adding validation

            if (!ModelState.IsValid) {
                return Page();
                
            }

            // check if the resturantId is greated than 0
            // if it is then it is  a edit request
            // other wise it is a create post

            if (Resturant.Id > 0) {
                Resturant = resturantData.Update(Resturant);
                // now send a confirmation string
                // there is a  data structue called tmp data
                // after using it will autometicallly deleted
                // can directly use it


                TempData["Message"] = "Resturant Updated";
            }
            else
            {
                // add it to the data service
                resturantData.Add(Resturant);
                TempData["Message"] = "Resturant Created";
            }
            // confirm it
            resturantData.Commit();


            return RedirectToPage("./Detail", new { resturentId = Resturant.Id }); ;


        }




    }
}
