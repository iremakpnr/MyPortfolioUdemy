using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.Portfolios.ToList();
            return View(values);
        }
    }
}
