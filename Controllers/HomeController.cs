using Dem_Telerik.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dem_Telerik.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ToString());
        IIPL_Customer_ManagementEntities2 ddl = new IIPL_Customer_ManagementEntities2();
        public ActionResult Demo()
        {

            return View("../Home/Demo");
        }
        public ActionResult New ()
        {

            return View("../Home/Demo");
        }
        public ActionResult fetchname()
        {

            return View("../Home/Demo");
        }




    }
}
