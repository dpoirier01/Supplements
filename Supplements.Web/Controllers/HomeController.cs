using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supplements.Business;
using Supplements.Model;
using Supplements.ServiceAPI.Models.EF;
using Supplements.Web.Models;

namespace Supplements.Web.Controllers   
{
    public class HomeController : Controller
    {

        SupplementsService _service = new SupplementsService();

        public ActionResult Index()
        {
            var supplements = (from supps in _service.GetSupplements()
                               select new Model.SupplementType()
                               {
                                   Id = supps.Id,
                                   Name = supps.Name,
                                   Distributer = supps.Distributer,
                                   IsThirdPartyTesting = supps.IsThirdPartyTesting
                               }).ToList();
            
            return View(supplements);
        }

        public ActionResult ViewReports(int id)
        {

            return View();
        }

        [HttpGet]
        public ActionResult GetDoses()
        {
            DosesViewModel vm = new DosesViewModel();
            return View(vm);
        }

        [HttpGet]
        public ActionResult AddDoses(string id)
        {
            DosesViewModel vm = new DosesViewModel();
            vm.SupplementTypeID = Convert.ToInt32(id);
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddDoses()
        {
            DosesViewModel vm = new DosesViewModel();
            return View(vm);
        }
    }
}