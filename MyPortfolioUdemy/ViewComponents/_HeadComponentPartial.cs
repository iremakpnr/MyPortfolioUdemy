using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();  
        } 
    }
}
