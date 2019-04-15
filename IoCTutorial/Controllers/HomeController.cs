using IoCTutorial.Services;
using IoCTutorial.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoCTutorial.Controllers
{
    public class HomeController : Controller
    {
        private IQuoteService quoteService;

        public HomeController(IQuoteService quoteService)
        {
            this.quoteService = quoteService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = this.quoteService.GetRandomQuote();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = RandomUtil.GetRandomQuote();

            return View();
        }
    }
}