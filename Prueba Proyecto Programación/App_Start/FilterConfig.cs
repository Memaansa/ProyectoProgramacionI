﻿using System.Web;
using System.Web.Mvc;

namespace Prueba_Proyecto_Programación
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
