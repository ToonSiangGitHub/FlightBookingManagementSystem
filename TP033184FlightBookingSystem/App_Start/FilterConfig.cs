﻿using System.Web;
using System.Web.Mvc;

namespace TP033184FlightBookingSystem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
