using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class EperienceController : Controller
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = Context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience experience) 
        {
            Context.Experiences.Add(experience);
            Context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience( int ID)
        {
            var value = Context.Experiences.Find(ID);
            Context.Experiences.Remove(value);
            Context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int ID)
        {
            var value = Context.Experiences.Find(ID);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            Context.Experiences.Update(experience);
            Context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
