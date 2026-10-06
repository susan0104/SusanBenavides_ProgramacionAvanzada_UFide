using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PAP.Business;
namespace PAP.Mvc.Controllers
{
    public class LibraryController : Controller
    {
        private readonly BookManager _bookManager;

        public LibraryController()
        {
            _bookManager = new BookManager();
        }

        public ActionResult Index()
        {
            var books = _bookManager.GetAllBooksFromDataModel();
            return View(books);
        }
    }
}