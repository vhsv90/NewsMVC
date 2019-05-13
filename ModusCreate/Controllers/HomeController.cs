using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModusCreate.Models;
using ModusCreate.Models.Repository;

namespace ModusCreate.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDataRepository<News> _dataRepository;
        private readonly IDataRepository<Subscription> _dataRepositorySubscription;

        public HomeController(IDataRepository<News> dataRepository, IDataRepository<Subscription> dataRepositorySubscription)
        {
            _dataRepository = dataRepository;
            _dataRepositorySubscription = dataRepositorySubscription;
        }

        public IActionResult Index()
        {
            return View(_dataRepository.GetAll());
        }

        public IActionResult ViewNews(long id)
        {
            var newsItem = _dataRepository.Get(id);

            if (newsItem is null)
                return NotFound();
            else
                return View(newsItem);
        }

        public IActionResult Government()
        {
            return View(_dataRepository.GetAllByCategory("Government"));
        }

        public ActionResult Weather()
        {
            return View(_dataRepository.GetAllByCategory("Weather"));
        }

        public ActionResult Traffic()
        {
            return View(_dataRepository.GetAllByCategory("Traffic"));
        }

        public ActionResult Sports()
        {
            return View(_dataRepository.GetAllByCategory("Sports"));
        }

        public ActionResult Entertainment()
        {
            return View(_dataRepository.GetAllByCategory("Entertainment"));
        }

        public ActionResult Technology()
        {
            return View(_dataRepository.GetAllByCategory("Technology"));
        }

        public ActionResult Health()
        {
            return View(_dataRepository.GetAllByCategory("Health"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult Search(string searchTerm)
        {
            ViewBag.searchKey = searchTerm;

            return View(_dataRepository.Search(searchTerm));
        }

        [HttpPost]
        public ActionResult Subscribe(string email, string category)
        {
            _dataRepositorySubscription.Add(new Subscription
            {
                Id = Guid.NewGuid(),
                Email = email,
                Category = category
            });

            return View();
        }
    }
}
