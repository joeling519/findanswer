﻿//using Api.FindAnswer.Controll;
using System.Web;
using System.Web.Mvc;

namespace findanswer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
           
            filters.Add(new HandleErrorAttribute());
        }
    }
}
