using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shopping.Client.Models;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json.Serialization;

namespace Shopping.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _HttpClientFactory;
        private readonly HttpClient _httpClient;

//        public HomeController(ILogger<HomeController> logger, HttpClient httpClient)
        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _HttpClientFactory = httpClientFactory;
            _httpClient = _HttpClientFactory.CreateClient("ShoppingAPIClient");
        }

        public async Task<IActionResult> Index()
        {
            var r = await _httpClient.GetAsync("/product");
            var c = await r.Content.ReadAsStringAsync();
            var p = JsonConvert.DeserializeObject<IEnumerable<Product>>(c);
            return View(p);
            //return View(ProductContext.Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
