using System.Diagnostics;
using System.Threading.Tasks;
using ChomasP3.Models;
using ChomasP3.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ChomasP3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            //need to go get the data
            DataRetrieval dr = new();
            //tell the instance of dr to go get the data
            var loadedAbout = await dr.GetData("about/");

            //build our model!
            //built, called AboutModel !

            //installed NuGet package Newtonsoft.Json
            var rtnResults = JsonConvert.DeserializeObject<AboutModel>(loadedAbout);

            rtnResults.pageTitle = "About us!";

            return View(rtnResults);
        }

        public async Task<IActionResult> People()
        {
            // get the data
            DataRetrieval dr = new();
            // get the people
            var loadedPeople = await dr.GetData("people/");

            //Newtonsoft.Json 
            var rtnResults = JsonConvert.DeserializeObject<PeopleModel>(loadedPeople);

            rtnResults.pageTitle = "Our People";

            return View(rtnResults);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
