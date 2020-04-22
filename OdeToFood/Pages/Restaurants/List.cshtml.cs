using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



// list.cshtml is like the view of the page
// and List.cshtml.cs is the controller 
// of the pages

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {

        // make a varitable with getter and setter
        public string Message { get; set; }

        // on get process the get request
        public void OnGet()
        {
            // any data this method exposes the razor page
            // has this access to this value
            Message = "hello World";
        }
    }
}
