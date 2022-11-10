using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using WebAppRestaurantDemoApp.Models;

namespace WebAppRestaurantDemoApp.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities2 restaurantDBEntities2;
        public PaymentTypeRepository()
        {
            objrestaurantDBEntities2 = new RestaurantDBEntities2();
        }

        public RestaurantDBEntities2 objrestaurantDBEntities2 { get; private set; }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in objrestaurantDBEntities2.PaymentTypes
                                    select new SelectListItem
                                    {
                                        Text = obj.PaymentTypeName,
                                        Value = obj.PaymentTypeId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}