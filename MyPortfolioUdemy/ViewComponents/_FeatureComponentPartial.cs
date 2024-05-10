using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
