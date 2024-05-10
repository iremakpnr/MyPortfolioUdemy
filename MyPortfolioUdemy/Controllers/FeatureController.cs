using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IActionResult FeaturePage()
        {
            var values = Context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            Context.Features.Add(feature);
            Context.SaveChanges();
            return RedirectToAction("FeaturePage");
        }

        public IActionResult DeleteFeature(int ID)
        {
            var value = Context.Features.Find(ID);
            Context.Features.Remove(value);
            Context.SaveChanges();
            return RedirectToAction("FeaturePage");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int ID)
        {
            var value = Context.Features.Find(ID);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            Context.Features.Update(feature);
            Context.SaveChanges();
            return RedirectToAction("featurePage");
        }
    }
}
