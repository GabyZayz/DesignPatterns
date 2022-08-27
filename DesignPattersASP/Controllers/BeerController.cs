using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsRepository;
using DesignPatters.Models;
using DesignPattersASP.Models.ViewModels;
using DesignPattersASP.Strategies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesignPattersASP.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        // GET: /<controller>/

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = d.BeerId,
                                                   Name = d.Name
                                                
                                               };
            return View("Index", beers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            GetBrandsData();
           
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVM)
        {
            if (!ModelState.IsValid)
            {
                GetBrandsData();
                return View("Add", beerVM);
            }

            var context = beerVM.Branid == null ?
                        new BeerContext(new BeerWithBrandStrategy()) :
                        new BeerContext(new BeerStrategy());

            context.Add(beerVM, _unitOfWork);
           
            return RedirectToAction("Index");
        }



        #region Helpers

        private void GetBrandsData()
        {
            var brands = from d in _unitOfWork.Brands.Get()
                         select new BrandViewModel
                         {
                             branid = d.Branid,
                             Name = d.Name

                         };
            ViewBag.Brands = new SelectList(brands, "branid", "Name");
        }

        #endregion
    }


}

