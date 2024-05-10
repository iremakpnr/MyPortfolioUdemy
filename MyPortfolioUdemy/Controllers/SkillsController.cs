using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class SkillsController : Controller
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IActionResult SkillPage()
        {
            var values = Context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            Context.Skills.Add(skill);
            Context.SaveChanges();
            return RedirectToAction("SkillPage");
        }

        public IActionResult DeleteSkill(int ID)
        {
            var value = Context.Skills.Find(ID);
            Context.Skills.Remove(value);
            Context.SaveChanges();
            return RedirectToAction("SkillPage");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int ID)
        {
            var value = Context.Skills.Find(ID);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            Context.Skills.Update(skill);
            Context.SaveChanges();
            return RedirectToAction("SkillPage");
        }
    }
}

