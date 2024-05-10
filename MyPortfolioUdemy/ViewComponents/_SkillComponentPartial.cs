using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.Skills.ToList();
            return View(values);
        }
    }
}
