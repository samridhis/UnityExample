using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookIOC.Models;
using Newtonsoft.Json;

namespace BookIOC.Controllers
{
    public class CompanyController : Controller
    {
        readonly ICompanyRepository repo;
        public CompanyController(ICompanyRepository tempProduct)
        {
            this.repo = tempProduct;
        }
        public ActionResult Index()
        {
            var data = repo.GetAll();
            //return JsonConvert.SerializeObject(data);
            ViewBag.data = data;
            return View();
        }
    }
}