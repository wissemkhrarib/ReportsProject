using CustomReports.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomReports.Controllers
{
    public class ReportController : Controller
    {
        private ReportsDbContext dbContext = new ReportsDbContext();
     
        // GET: Report
        public ActionResult Index()
        {
            var reports = dbContext.Reports.ToList();
            return View(reports);
        }

        [HttpPost]
        public ActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var report = dbContext.Reports.FirstOrDefault(r => r.Id == id);
            return View(report);
        }
    }
}