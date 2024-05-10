using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class TestimonialController : Controller
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IActionResult TestimonialList()
        {
            var values = Context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            Context.Testimonials.Add(testimonial);
            Context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult DeleteTestimonial(int ID)
        {
            var value = Context.Testimonials.Find(ID);
            Context.Testimonials.Remove(value);
            Context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int ID)
        {
            var value = Context.Testimonials.Find(ID);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            Context.Testimonials.Update(testimonial);
            Context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
