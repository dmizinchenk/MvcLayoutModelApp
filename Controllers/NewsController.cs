using Microsoft.AspNetCore.Mvc;
using MvcLayoutApp.Models;

namespace MvcLayoutApp.Controllers
{
    public class NewsController : Controller
    {
        List<NewsModel> news = new();
        public NewsController()
        {
            news.Add(new NewsModel("Title 1 news", "Body of first news...", "7.12.2018"));
            news.Add(new NewsModel("Title 2 news", "Body of second news...", "15.02.2019"));
            news.Add(new NewsModel("Title 3 news", "Body of third news...", "21.03.2019"));
            news.Add(new NewsModel("Title 4 news", "Body of fourth news...", "1.05.2021"));
        }
        public IActionResult Index()
        {
            return View(news);
        }
    }
}
