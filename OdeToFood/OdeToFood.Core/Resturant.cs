using System;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{
    public partial class Resturant
    {

        // all theinformation and logic wil be stored
        /// here 
        /// you can ad simple validation in the 
        /// resturant class properties
        /// getter and setter to add validation 
        /// and force user to fill the data
        
        // you can also add password validation
        // in this process
        // and then you need to go to the OnPost()
        // method to use that where you need it
        // if the data is entered is valid 
        // that will be detected and you can access this data
        // by model state
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Name { get; set; }
        [Required, StringLength(250)]
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
        // now we set a type 
        // now we create a new project for 
        // storing resturant object
        // and then we make two way in memory and 
        // databse




    }
}
