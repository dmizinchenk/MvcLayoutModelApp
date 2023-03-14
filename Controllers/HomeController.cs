using Microsoft.AspNetCore.Mvc;
using MvcLayoutApp.Models;
using System.Diagnostics;

namespace MvcLayoutApp.Controllers
{
    public class HomeController : Controller
    {
        List<NewsModel> news = new();
        public HomeController()
        {
            news.Add(new NewsModel("Title 1 news from model", "Body of first news...", "7.12.2018"));
            news.Add(new NewsModel("Title 2 news from model", "Body of second news...", "15.02.2019"));
            news.Add(new NewsModel("Title 3 news from model", "Body of third news...", "21.03.2019"));
            news.Add(new NewsModel("Title 4 news from model", "Body of fourth news...", "1.05.2021"));
        }

        public IActionResult Index()
        {
            return View(news);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}