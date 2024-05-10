using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class AboutController1 : Controller
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IActionResult AboutPage()
        {
            var values = Context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            Context.Abouts.Add(about);
            Context.SaveChanges();
            return RedirectToAction("AboutPage");
        }

        public IActionResult DeleteAbout(int ID)
        {
            var value = Context.Abouts.Find(ID);
            Context.Abouts.Remove(value);
            Context.SaveChanges();
            return RedirectToAction("AboutPage");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int ID)
        {
            var value = Context.Abouts.Find(ID);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            Context.Abouts.Update(about);
            Context.SaveChanges();
            return RedirectToAction("AboutPage");
        }
    }
}
