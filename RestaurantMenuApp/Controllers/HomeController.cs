using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace RestaurantMenuApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        database_access_layer.db dbLayer = new database_access_layer.db();
        public ActionResult Index()
        {
            DataSet ds = dbLayer.getCategory();
            ViewBag.category = ds.Tables[0];

            return View();
        }
    }
}