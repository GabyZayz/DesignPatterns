using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsRepository;
using Microsoft.AspNetCore.Mvc;
using Tools.Generator;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesignPattersASP.Controllers
{
    public class GeneratorFileController : Controller
    {
        // GET: /<controller>/
        private IUnitOfWork _unitOfWork;

        private GeneratorConcreteBuilder _generatorConcreteBuilder;


        public GeneratorFileController (IUnitOfWork unitOfWork, GeneratorConcreteBuilder generatorConcretBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcretBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateFile(int optionFile)
        {
            Console.WriteLine("accesing");
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(d => d.Name).ToList();
                 string path = "file" + DateTime.Now.Ticks + new Random().Next(1000)+".txt";

                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (optionFile == 1)
                    generatorDirector.CreateSimpleJsonGenerator(content, path);
                else
                    generatorDirector.CreateSimplePipeGenerator(content, path);

                var generator = _generatorConcreteBuilder.GetGenerator();
                    generator.Save();

                return Json("Archivo Generado");

            }catch(Exception ex)
            {
                return BadRequest();
            }
           
        }
    }
}

