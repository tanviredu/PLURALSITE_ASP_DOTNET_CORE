using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    class OdetoFoodDbContext :DbContext
    {


        // now we make a a field witch based on the 
        // Resturant class
        public DbSet<Resturant> Resturants { get; set; }
        // this will create a CRUD autometically

    }
}
