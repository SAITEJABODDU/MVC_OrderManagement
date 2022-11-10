using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using WebAppRestaurantDemoApp.Models;

namespace WebAppRestaurantDemoApp.Repositories
{
    public class ItemRepository
    {
        private RestaurantDBEntities2 objrestaurantDBEntities2;
        public ItemRepository()
        {
            objrestaurantDBEntities2 = new RestaurantDBEntities2();
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in objrestaurantDBEntities2.Items
                                    select new SelectListItem
                                    {
                                        Text = obj.ItemName,
                                        Value = obj.ItemId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}