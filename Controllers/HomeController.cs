using ProductInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ProductInventory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       //checking users authority
        [HttpPost]
        public ActionResult Index(UserAuthModel person)
        {
          
            return View();
        }
        public ActionResult ProductEdit()
        {
            //converting the json file  to .net 
            List<ItemModel> itModel = new List<ItemModel>();
            JsonReadWrite readWrite = new JsonReadWrite();
            itModel = JsonConvert.DeserializeObject<List<ItemModel>>(readWrite.Read("ProductsList.json", "data"));
            return View(itModel);
        }
       
    }
}