using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restaurant.Models.EF;

namespace Restaurant.Models.DAO
{
    public class BaseDAO
    {
        protected RestaurantEntities1 _context;

        public BaseDAO()
        {
            _context = new RestaurantEntities1();
        }
    }
}