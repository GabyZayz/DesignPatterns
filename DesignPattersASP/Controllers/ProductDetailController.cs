using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPattersASP.Views
{
    public class ProductDetailController : Controller
    {
        public EarnFactory _localEarnFactory;
        public ProductDetailController(LocalEarnFactory localEarnFactory)
        {
            _localEarnFactory = localEarnFactory;

        }
      
        public IActionResult Index(decimal total) 
        {
            //factories
            
            ForeingEarnFactory foreingEarnFactore = new ForeingEarnFactory(0.30m, 20);


           
            //productos
            var localEarn = _localEarnFactory.GetEarn();

            var foreingEarn = foreingEarnFactore.GetEarn();


            //total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeing = total + foreingEarn.Earn(total);


            return View();
        }
    }
}