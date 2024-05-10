using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IActionResult ContactList()
        {
            var values = Context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            Context.Contacts.Add(contact);
            Context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int ID)
        {
            var value = Context.Contacts.Find(ID);
            Context.Contacts.Remove(value);
            Context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public IActionResult UpdateContact(int ID)
        {
            var value = Context.Contacts.Find(ID);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            Context.Contacts.Update(contact);
            Context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
