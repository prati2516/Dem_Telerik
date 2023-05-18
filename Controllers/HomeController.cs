using Dem_Telerik.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Css.Ast.Selectors;

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


        ////checked by aniket
        public ActionResult newfunction ()
        {

            return View("../Home/Demo");
            //Ashkered changes 
            //vhngesbjb cdni 
        }


     
        ////checked by aniket

        public ActionResult Pratiksh()
        {

            return View("../Home/Demo");
        }
        //fhgjjkllkjhvfcf



        // pratiksha kapare

    }
}
