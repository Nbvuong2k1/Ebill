using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ebill.Models;
using Ebill.Repository;

namespace Ebill.Controllers
{
    public class EbillController : Controller
    {
        // GET: Ebill
        public ActionResult Index()
        {
            Data data = new Data();
            var list = data.GetAllDetail();
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BillDetail details)
        {
            Data data = new Data(); 
            data.SaveBillDetails(details);
            ModelState.Clear();
            return View();
        }
      public ActionResult CreateItem(Items item) 
        { 
        
            return PartialView("_CreateItem",item);
        }
        public ActionResult ViewBill(int Id)
        {
            Data data = new Data();
            var details = data.GetDetail(Id);
            return View(details);
        }
    }
}