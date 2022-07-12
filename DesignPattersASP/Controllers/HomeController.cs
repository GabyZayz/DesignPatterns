using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesignPattersASP.Models;
using Tools;
using Microsoft.Extensions.Options;
using DesignPatternsRepository;
using DesignPatters.Models;

namespace DesignPattersASP.Controllers;

public class HomeController : Controller
{
    private readonly IOptions<DesignPattersASP.Configuration.MyConfig> _config;

    private readonly IRepository<Beer> _repository;

    public HomeController(IOptions<DesignPattersASP.Configuration.MyConfig> config,
            IRepository<Beer> repository)
    {
        _config = config;
        _repository = repository;
    }

    public IActionResult Index()
    { 
        Log.GetInstance(_config.Value.PathLog).Save("Entro a index");
        IEnumerable<Beer> lst = _repository.Get();
        return View("Index", lst);
    }

    public IActionResult Privacy()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entro a privacy");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

