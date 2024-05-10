using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;


namespace MyPortfolioUdemy.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IActionResult PortfolioList()
        {
            var values = Context.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            Context.Portfolios.Add(portfolio);
            Context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult DeletePortfolio(int ID)
        {
            var value = Context.Portfolios.Find(ID);
            Context.Portfolios.Remove(value);
            Context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int ID)
        {
            var value = Context.Portfolios.Find(ID);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            Context.Portfolios.Update(portfolio);
            Context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
